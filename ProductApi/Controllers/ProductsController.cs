using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Npgsql;
using ProductApi.DapperModels;
using RestSharp;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetProducts()
        {
            using (var connection = new NpgsqlConnection("User ID=postgres;Password=ozgur;Host=localhost;Port=5432;Database=ProductDb;"))
            {
                var count= connection.QueryFirst<int>("SELECT Count(*) FROM Products");
                if (count==0)
                {
                    List<ProductInsert> inserts=new List<ProductInsert>();
                    var currencies= connection.Query<Currency>("SELECT * FROM Currencies").ToArray();
                    RestClient client = new RestClient("https://dummyjson.com/products");
                    Random random = new Random();
                    RestRequest request = new RestRequest();
                    Root root = JsonConvert.DeserializeObject<Root>(client.GetAsync(request).GetAwaiter().GetResult().Content);
                    foreach (var item in root.products)
                    {
                        inserts.Add(new ProductInsert { product_code = ("A" + item.id.ToString()), currency_id = random.Next(1, 3), Price=item.price});
                    }
                    string sqlQuery = @"INSERT INTO Products (product_code, currency_id ,Price) VALUES(@product_code, @currency_id,@Price)";
                    int rowsaffected=connection.Execute(sqlQuery,inserts.ToArray());
                }
                var products= connection.Query<ProductSelect,Currency,ProductSelect>(@"SELECT * FROM Products p inner join Currencies c on p.currency_Id=c.currency_Id", (product, currency) =>
                {
                    product.Currency = currency;
                    return product;
                },splitOn: "currency_Id");
                return Ok(products);
            }
        }
    }
}
