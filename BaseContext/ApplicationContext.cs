using Microsoft.EntityFrameworkCore;
using ShopV2.Model;

namespace ShopV2.BaseContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInform> ProductInforms { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   
        }
    }
}
