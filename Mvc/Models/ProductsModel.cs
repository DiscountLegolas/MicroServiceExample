using Newtonsoft.Json;

namespace Mvc.Models
{
    public class ProductsModel
    {
        public string ToJson()
        {
            string json = JsonConvert.SerializeObject(this);
            return json;
        }
        public List<ProductModel> Products { get; set; }
    }

    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductImage { get; set; }
        public double Price { get; set; }
        public string PriceFormated { get; set; }

    }
}
