using Lion.AbpProNuget.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lion.AbpProNuget.Permissions
{
    public class AbpProNugetPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpProNugetResource>(name);
        }
    }
}