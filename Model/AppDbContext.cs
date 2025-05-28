using Microsoft.EntityFrameworkCore;

namespace WebApplicationGr3.Model
{
    public class AppDbContext : DbContext
    {

        private string dbPath = Path.Combine(Environment.CurrentDirectory, "database.db");
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source = {dbPath}");
        }

    }
}
