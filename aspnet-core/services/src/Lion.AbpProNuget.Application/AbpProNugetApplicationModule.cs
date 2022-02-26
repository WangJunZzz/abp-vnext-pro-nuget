using Lion.AbpPro;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Lion.AbpProNuget
{
    [DependsOn(
        typeof(AbpProNugetDomainModule),
        typeof(AbpProNugetApplicationContractsModule),
        typeof(AbpProApplicationModule)
        )]
    public class AbpProNugetApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AbpProNugetApplicationModule>();
            });
            
          
        }
    }
}
