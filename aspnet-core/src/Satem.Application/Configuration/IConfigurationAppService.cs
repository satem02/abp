using System.Threading.Tasks;
using Satem.Configuration.Dto;

namespace Satem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
