using System;
using System.Collections.Generic;
using System.Text;
using Lion.AbpProNuget.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.Localization;

namespace Lion.AbpProNuget
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpProNugetAppService : ApplicationService
    {
        protected AbpProNugetAppService()
        {
            LocalizationResource = typeof(AbpProNugetResource);
        }
    }
}
