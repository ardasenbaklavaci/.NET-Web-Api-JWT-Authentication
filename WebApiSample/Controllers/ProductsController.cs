using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    public class ProductsController : Controller
    {
        WebApiSampleContext context;
        public ProductsController(WebApiSampleContext context)
        {
            this.context = context;
        }

        // GET: api/products
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetProducts()
        {
            var products = await context.Products.ToListAsync();
            return Ok(products);
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        /*
        public IActionResult Index()
        {
            return View();
        } */
    }
}
