using Microsoft.EntityFrameworkCore;


namespace Trabalho_PUC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Card> Cards { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<PhysicalMoney> PhysicalMoneys { get; set; }

        public DbSet<Grupo> Grupos { get; set; }

        public DbSet<Boletos> Boletos { get; set; }
     

    }
}
