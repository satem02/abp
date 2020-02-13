using System.Threading.Tasks;
using Abp.Application.Services;
using Satem.Authorization.Accounts.Dto;

namespace Satem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
