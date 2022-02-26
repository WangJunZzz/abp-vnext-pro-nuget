using Lion.AbpProNuget.Localization;
using Volo.Abp.Localization;
using Volo.Abp.Settings;

namespace Lion.AbpProNuget.Settings
{
    public class AbpProNugetSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpProNugetSettings.MySetting1));
            OverrideDefalutSettings(context);
        }

        /// <summary>
        /// 重写默认setting添加自定义属性
        /// </summary>
        private static void OverrideDefalutSettings(ISettingDefinitionContext context)
        {
            
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpProNugetResource>(name);
        }
    }
}