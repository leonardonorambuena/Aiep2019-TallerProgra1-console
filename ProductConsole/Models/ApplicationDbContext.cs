using Microsoft.EntityFrameworkCore;

namespace ProductConsole.Models
{
    public class ApplicationDbContext : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost;user=root;password=;database=product-console");
        }

        public DbSet<Product> Products {get; set;} 
    }
}