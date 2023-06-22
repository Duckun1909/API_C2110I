using API_C2110I_22_6_CURD_relationship.Models;
using Microsoft.EntityFrameworkCore;

namespace API_C2110I_22_6_CURD_relationship.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions? options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
