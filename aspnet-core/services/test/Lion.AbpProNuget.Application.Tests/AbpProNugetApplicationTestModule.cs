using Volo.Abp.Modularity;

namespace Lion.AbpProNuget
{
    [DependsOn(
        typeof(AbpProNugetApplicationModule),
        typeof(AbpProNugetDomainTestModule)
        )]
    public class AbpProNugetApplicationTestModule : AbpModule
    {

    }
}