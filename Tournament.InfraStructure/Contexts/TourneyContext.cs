using Microsoft.EntityFrameworkCore;
using Tournament.InfraStructure.ConnectionStrings;
using Tournament.Model.Models;

namespace Tournament.InfraStructure.Contexts
{
    public class TourneyContext : DbContext
    {

        public TourneyContext()
        {
        }

        public TourneyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Game>? Game { get; set; }
        public DbSet<VirtualItem>? VirtualItems { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<Team>? Teams { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TourneyConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasIndex(p => p.UserName)
                .IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(p => p.Email)
                .IsUnique();
        }

    }

}
