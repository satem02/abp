using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Satem.Configuration.Dto;

namespace Satem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SatemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
