using Lion.AbpProNuget.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Lion.AbpProNuget.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpProNugetEntityFrameworkCoreModule),
        typeof(AbpProNugetApplicationContractsModule)
        )]
    public class AbpProNugetDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
