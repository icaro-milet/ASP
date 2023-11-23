using Microsoft.EntityFrameworkCore;

namespace ASP.Infra.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Domain.Aggregates.Products.Entities.Product> Produts { get; set; }
        public DbSet<Domain.Aggregates.Products.Entities.Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }

}
