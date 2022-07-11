using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RestSharp;

namespace Blazor.Data.EFCore
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProductDB.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            RestClient client = new RestClient("https://dummyjson.com/products");
            RestRequest request = new RestRequest();
            Root root = JsonConvert.DeserializeObject<Root>(client.GetAsync(request).GetAwaiter().GetResult().Content);
            foreach (var item in root.products)
            {
                modelBuilder.Entity<Product>().HasData(new Product() { ProductId =item.id, ProductCode = ("A"+item.id.ToString()),ProductImageUrl=item.thumbnail });
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
