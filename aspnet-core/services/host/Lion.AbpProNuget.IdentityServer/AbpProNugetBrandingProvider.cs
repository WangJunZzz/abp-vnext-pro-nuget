using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Lion.AbpProNuget
{
    [Dependency(ReplaceServices = true)]
    public class AbpProNugetBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpProNuget";
    }
}
