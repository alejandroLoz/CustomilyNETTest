using CutomilyNetCoreTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CutomilyNetCoreTest
{
    public class PagesDbContext : DbContext
    {
        public PagesDbContext()
        {

            
        }
        public PagesDbContext(DbContextOptions<PagesDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Image> Images { get; set; }
    }

}
