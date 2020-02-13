using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Satem.Configuration;
using Satem.Web;

namespace Satem.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SatemDbContextFactory : IDesignTimeDbContextFactory<SatemDbContext>
    {
        public SatemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SatemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SatemDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SatemConsts.ConnectionStringName));

            return new SatemDbContext(builder.Options);
        }
    }
}
