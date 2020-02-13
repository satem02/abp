using System.Threading.Tasks;
using Abp.Application.Services;
using Satem.Sessions.Dto;

namespace Satem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
