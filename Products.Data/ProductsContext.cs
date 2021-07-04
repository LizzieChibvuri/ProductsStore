using Microsoft.EntityFrameworkCore;


namespace Product.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Productt> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
