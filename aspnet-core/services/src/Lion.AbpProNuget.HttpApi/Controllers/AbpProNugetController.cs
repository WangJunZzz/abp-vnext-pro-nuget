using Lion.AbpProNuget.Localization;
using Volo.Abp.Application.Services;
using Volo.Abp.AspNetCore.Mvc;

namespace Lion.AbpProNuget.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpProNugetController : AbpController
    {
        protected AbpProNugetController()
        {
            LocalizationResource = typeof(AbpProNugetResource);
        }
    }
}