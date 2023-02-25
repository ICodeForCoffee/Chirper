using Microsoft.EntityFrameworkCore;

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
