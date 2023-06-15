using C2110I_API_buoi1_15_6.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace C2110I_API_buoi1_15_6.Data
{
    public class DBConnect:DbContext
    {
        public DBConnect(DbContextOptions<DBConnect> options) : base(options) { }
        public DbSet<Category> category { get; set; }
        public DbSet<Product> product { get; set; }
    }
}
