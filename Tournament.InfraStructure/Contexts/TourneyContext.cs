using Microsoft.EntityFrameworkCore;
using Tournament.InfraStructure.ConnectionStrings;
using Tournament.Model.Models;

namespace Tournament.InfraStructure.Contexts
{
    public class TourneyContext : DbContext
    {
        public DbSet<Game> Game { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TourneyConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
