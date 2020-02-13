using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Satem.EntityFrameworkCore
{
    public static class SatemDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SatemDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SatemDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
