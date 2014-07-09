using Abp.Web.Mvc.Controllers;

namespace RestoAddicted.Web.Controllers
{
    public abstract class RestoAddictedControllerBase : AbpController
    {
        protected RestoAddictedControllerBase()
        {
            LocalizationSourceName = "RestoAddicted";
        }
    }
}