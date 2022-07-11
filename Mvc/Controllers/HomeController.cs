using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Mvc.Data;
using Mvc.Models;
using Mvc.Data.EFCore;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;

namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductDbContext _context;
        public HomeController(ILogger<HomeController> logger)
        {
            _context = new ProductDbContext();
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("/products")]
        public IActionResult Products()
        {
            string auth = "Bearer " + Token.GetToken().access_token + "";
            var client = new RestClient("https://localhost:44351/product-service/products");
            var req = new RestRequest();
            req.AddHeader("Authorization", auth);
            var responsebody = client.Get(req).Content;
            List<ProductApi> productSelects=JsonConvert.DeserializeObject<List<ProductApi>>(responsebody);
            var products = _context.Products;
            ProductsModel model = new ProductsModel() { Products=new List<ProductModel>()};
            foreach (var item in products)
            {
                var pr = Convert.ToDouble(productSelects.Single(a => a.product_code == item.ProductCode).Price);
                var symbol = productSelects.Single(a => a.product_code == item.ProductCode).Currency.Symbol;
                model.Products.Add(new ProductModel() { ProductId=item.ProductId,ProductCode=item.ProductCode,ProductImage=item.ProductImageUrl,Price=pr,PriceFormated=pr.ToString()+symbol});
            }
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}