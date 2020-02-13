using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Satem.Authorization;

namespace Satem
{
    [DependsOn(
        typeof(SatemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SatemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SatemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SatemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
