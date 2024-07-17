using Fruitables.Models;
using Microsoft.EntityFrameworkCore;

namespace Fruitables.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Category> categories { get; set; }
		public DbSet<Product> products { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>()
				.HasData(new Category
				{
					CategoryId = 1,
					CategoryName = "Test"
				});
		}
	}
}
