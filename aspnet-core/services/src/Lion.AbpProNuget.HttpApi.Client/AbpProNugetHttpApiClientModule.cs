using Lion.AbpPro;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Lion.AbpProNuget
{
    [DependsOn(
        typeof(AbpProNugetApplicationContractsModule),
        typeof(AbpProHttpApiClientModule)
    )]
    public class AbpProNugetHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Default";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(AbpProNugetApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
