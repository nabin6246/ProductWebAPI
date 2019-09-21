using Microsoft.EntityFrameworkCore;
using ProductWebApi.Models;

namespace ProductWebApi.DAL
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
