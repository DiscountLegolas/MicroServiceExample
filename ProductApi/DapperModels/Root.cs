namespace ProductApi.DapperModels
{
    public class Product
    {
        public int id { get; set; }
        public int price { get; set; }
        public double discountPercentage { get; set; }
    }

    public class Root
    {
        public List<Product> products { get; set; }
    }
}
