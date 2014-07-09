using Abp.Web.Mvc.Views;

namespace RestoAddicted.Web.Views
{
    public abstract class RestoAddictedWebViewPageBase : RestoAddictedWebViewPageBase<dynamic>
    {

    }

    public abstract class RestoAddictedWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected RestoAddictedWebViewPageBase()
        {
            LocalizationSourceName = "RestoAddicted";
        }
    }
}