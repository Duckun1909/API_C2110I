using API_C2110I_22_6_CURD_relationship.Data;
using API_C2110I_22_6_CURD_relationship.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.Common;

namespace API_C2110I_22_6_CURD_relationship.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public readonly MyDbContext db;
        public CategoryController(MyDbContext db)
        {
            this.db = db;
        }

        private bool Dupplicated(string? cat)
        {
            Category category = db.Categories.SingleOrDefault(c => c.Name == cat);
            if(category == null)
            {
                return false;
            }
            return true;
        }

        [HttpGet]
        [Route("api/[Controller]/[Action]")]
        public IActionResult List()
        {
            IEnumerable<Category> categories = db.Categories.ToArray();
            if(categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }

        [HttpPost]
        [Route("api/[Controller]/[Action]")]
        public IActionResult Create(Category cat)
        {
            Boolean flag = true;
            if (!ModelState.IsValid)
            {
                return Ok(ModelState);
            }
            if (Dupplicated(cat.Name))
            {
                ModelState.AddModelError("DupplicatedCategoryNamme", "Category name was existed");
                return Ok(ModelState);
            }

            if (flag)
            {
                db.Add(cat);
                db.SaveChangesAsync();
            }

            if (cat == null)
            {
                return NotFound();
            }
                return Ok(cat);
        }

       

        [HttpPut]
        [Route("api/[Controller]/[Action]/{id}")]
        public IActionResult Update(int id, Category cat)
        {
            Category category = db.Categories.SingleOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound(id);
            }

            category.Name = cat.Name;

            return Ok(category);
        }
    }
}
