
using ramirez_villarejo_abel_ReparaMAUI.Models;

namespace ramirez_villarejo_abel_ReparaMAUI.Data
{
    public class ReparaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Coche> Vehiculos { get; set; }

        public ReparaDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "repara_maui.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}