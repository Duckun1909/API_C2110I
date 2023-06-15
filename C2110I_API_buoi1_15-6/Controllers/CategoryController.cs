using C2110I_API_buoi1_15_6.Data;
using C2110I_API_buoi1_15_6.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace C2110I_API_buoi1_15_6.Controllers
{
    [ApiController]
    [Route("/api/")]
    public class CategoryController : ControllerBase
    {

        public readonly DBConnect db;
        public CategoryController(DBConnect db)
        {
            this.db = db;
        }
        [HttpGet]
        [Route("[Controller]/[Action]")]
        public IEnumerable<Category> List()
        {
            return db.category.ToArray();
        }
    }
}
