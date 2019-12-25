
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Models;

namespace Shop.DBContext
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            var configuration = builder.Build();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Poster;Username=postgres;Password=zxcasdqwe");
        }
    }
}