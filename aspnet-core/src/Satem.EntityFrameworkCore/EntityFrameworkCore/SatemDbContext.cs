using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Satem.Authorization.Roles;
using Satem.Authorization.Users;
using Satem.MultiTenancy;

namespace Satem.EntityFrameworkCore
{
    public class SatemDbContext : AbpZeroDbContext<Tenant, Role, User, SatemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SatemDbContext(DbContextOptions<SatemDbContext> options)
            : base(options)
        {
        }
    }
}
