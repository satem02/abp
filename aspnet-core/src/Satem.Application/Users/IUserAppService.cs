using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Satem.Roles.Dto;
using Satem.Users.Dto;

namespace Satem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
