using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Satem.MultiTenancy.Dto;

namespace Satem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

