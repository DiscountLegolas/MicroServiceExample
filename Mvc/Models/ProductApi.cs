namespace Mvc.Models
{
    public class ProductApi
    {
        public string product_code { get; set; }
        public Currency Currency { get; set; }

        public float Price { get; set; }
    }

    public class Currency
    {
        public int currency_Id { get; set; }
        public string currency_Name { get; set; }
        public char Symbol { get; set; }
    }
}
