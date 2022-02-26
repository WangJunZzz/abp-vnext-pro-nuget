using Lion.AbpProNuget.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Lion.AbpProNuget
{
    [DependsOn(
        typeof(AbpProNugetEntityFrameworkCoreTestModule)
        )]
    public class AbpProNugetDomainTestModule : AbpModule
    {

    }
}