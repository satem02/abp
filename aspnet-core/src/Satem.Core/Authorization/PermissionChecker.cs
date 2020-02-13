using Abp.Authorization;
using Satem.Authorization.Roles;
using Satem.Authorization.Users;

namespace Satem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
