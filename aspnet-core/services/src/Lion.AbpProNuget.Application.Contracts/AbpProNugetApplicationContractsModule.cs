using Lion.AbpPro;
using Volo.Abp.Modularity;

namespace Lion.AbpProNuget
{
    [DependsOn(
        typeof(AbpProNugetDomainSharedModule),
        typeof(AbpProApplicationContractsModule)
    )]
    public class AbpProNugetApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AbpProNugetDtoExtensions.Configure();
        }
    }
}
