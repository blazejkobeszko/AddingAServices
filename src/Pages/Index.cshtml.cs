using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.WebSite.Data;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService, ProductContext context)
        {
            _logger = logger;
            ProductService = productService;
            _context = context;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

       // public IList<Product> Productss { get; set; }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
           // Productss = _context.ProductTable.ToList();
        }
    }
}
