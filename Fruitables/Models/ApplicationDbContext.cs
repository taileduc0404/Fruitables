using Microsoft.EntityFrameworkCore;

namespace Fruitables.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
