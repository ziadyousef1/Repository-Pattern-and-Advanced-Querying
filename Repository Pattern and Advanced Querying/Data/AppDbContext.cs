using Microsoft.EntityFrameworkCore;
using Repository_Pattern_and_Advanced_Querying.Models;

namespace Repository_Pattern_and_Advanced_Querying.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
