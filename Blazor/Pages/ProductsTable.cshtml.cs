using Blazor.Data.EFCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blazor.Pages
{
    [Authorize]
    public class ProductsTableModel : PageModel
    {
        public ProductDbContext _context;
        public ProductsTableModel()
        {
            _context=new ProductDbContext();
        }
        public List<Product> products;
        public void OnGet()
        {
            products=_context.Products.ToList();
        }
    }
}
