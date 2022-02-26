using Lion.AbpProNuget.Localization;

namespace Lion.AbpProNuget
{
    public abstract class AbpProNugetDomainTestBase : AbpProNugetTestBase<AbpProNugetDomainTestModule> 
    {
        public AbpProNugetDomainTestBase()
        {
            ServiceProvider.InitializeLocalization();;
        }
    }
}
