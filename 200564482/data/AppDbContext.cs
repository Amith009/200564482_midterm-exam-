using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace _200564482.data
{
    public class AppDbContext(IConfiguration config) : DbContext
    {
        public IConfiguration Config { get; set; } = config;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.GetConnectionString("DatabaseConnection"));
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
