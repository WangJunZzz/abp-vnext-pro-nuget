using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Lion.AbpProNuget.Data;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace Lion.AbpProNuget.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpProNugetDbSchemaMigrator
        : IAbpProNugetDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpProNugetDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpProNugetMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpProNugetDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}