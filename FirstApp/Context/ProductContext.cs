using FirstApp.Models;
using System.Data.Entity;

namespace FirstApp.Context
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}