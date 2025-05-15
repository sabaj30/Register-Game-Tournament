using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Tournament.InfraStructure.Contexts;

namespace TournamentUI.Data
{
    public class SampleClassFactory : IDesignTimeDbContextFactory<TourneyContext>
    {
        public TourneyContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<TourneyContext>();
            var connectionString = configuration.GetConnectionString("TourneyConnectionString");
            builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("TournamentUI"));
            return new TourneyContext(builder.Options);
        }
    }
}
