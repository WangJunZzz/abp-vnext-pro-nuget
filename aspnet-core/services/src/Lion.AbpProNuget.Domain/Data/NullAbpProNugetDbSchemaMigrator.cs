using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Lion.AbpProNuget.Data
{
    /* This is used if database provider does't define
     * IAbpProNugetDbSchemaMigrator implementation.
     */
    public class NullAbpProNugetDbSchemaMigrator : IAbpProNugetDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}