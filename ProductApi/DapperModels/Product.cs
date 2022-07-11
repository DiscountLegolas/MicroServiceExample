namespace ProductApi.DapperModels
{
    public class ProductInsert
    {
        public string product_code { get; set; }
        public int currency_id { get; set; }

        public float Price { get; set; }
    }
    public class ProductSelect
    {
        public string product_code { get; set; }
        public Currency Currency { get; set; }

        public float Price { get; set; }
    }
}
