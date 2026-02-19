using Microsoft.EntityFrameworkCore;
using ramirez_villarejo_abel_ReparaMAUI.Models;

namespace ramirez_villarejo_abel_ReparaMAUI.Data
{
    public class ReparaDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Automovil> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "repara_maui.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}