using Microsoft.EntityFrameworkCore;
using WebApiCrud.Models;
namespace WebApiCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<TopGames> TopGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}