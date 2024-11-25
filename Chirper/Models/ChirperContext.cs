using Microsoft.EntityFrameworkCore;

//todo Where am I putting the models if I'm moving the service out?
namespace Chirper.Models
{
    public class ChirperContext : DbContext
    {
        public ChirperContext(DbContextOptions<ChirperContext> options) : base(options)
        {
        }

        public DbSet<Chirp> Chirps { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chirp>();//.ToTable("Chirp");
            modelBuilder.Entity<User>();//.ToTable("User");
        }
    }
}
