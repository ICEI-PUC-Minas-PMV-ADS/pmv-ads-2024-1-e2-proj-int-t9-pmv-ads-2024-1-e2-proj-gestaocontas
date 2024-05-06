using Microsoft.EntityFrameworkCore;

namespace Trabalho_PUC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }
    }
}
