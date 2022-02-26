using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Lion.AbpProNuget.EntityFrameworkCore
{
    public static class AbpProNugetDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpProNuget(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpProNugetConsts.DbTablePrefix + "YourEntities", AbpProNugetConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}