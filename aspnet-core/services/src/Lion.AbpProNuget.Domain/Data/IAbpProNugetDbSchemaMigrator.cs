using System.Threading.Tasks;

namespace Lion.AbpProNuget.Data
{
    public interface IAbpProNugetDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
