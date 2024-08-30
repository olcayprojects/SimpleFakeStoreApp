using Microsoft.AspNetCore.Mvc.RazorPages;
using SimpleFakeStoreApp.Models;
using SimpleFakeStoreApp.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleFakeStoreApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<string> Categories { get; set; } = new List<string>();

        public async Task OnGetAsync()
        {
            Products = await _productService.GetProductsAsync();
            Categories = Products.Select(p => p.category).Distinct().ToList();
        }
    }
}
