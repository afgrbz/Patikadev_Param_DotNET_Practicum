global using Microsoft.EntityFrameworkCore;

namespace RestfulAPI_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=superherodb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
