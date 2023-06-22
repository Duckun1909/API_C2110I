using API_C2110I_22_6_CURD_relationship.Data;
using API_C2110I_22_6_CURD_relationship.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_C2110I_22_6_CURD_relationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly MyDbContext db;
        public ProductController(MyDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("api/[Controller]/[Action]")]
        public IActionResult List()
        {
            IEnumerable<Product> products = db.Products.ToArray();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost]
        [Route("api/[Controller]/[Action]/{id}")]
        public IActionResult GetById(int id)
        {
            Product product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }
            return Ok(product);
        }

        [HttpPut]
        [Route("api/[Controller]/[Action]/{id}")]
        public IActionResult Update(int id, Product prd)
        {
            Product product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }

            product.Name = prd.Name;
            product.Price = prd.Price;
            product.CategoryId = prd.CategoryId;

            return Ok(product);
        }

        [HttpPut]
        [Route("api/[Controller]/[Action]/{id}")]
        public IActionResult Delete(int id)
        {
            Product product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(id);
            }

            db.Products.Remove(product);

            return Ok(product);
        }
    }
}
