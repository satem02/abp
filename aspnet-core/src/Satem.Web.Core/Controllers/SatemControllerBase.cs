using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Satem.Controllers
{
    public abstract class SatemControllerBase: AbpController
    {
        protected SatemControllerBase()
        {
            LocalizationSourceName = SatemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
