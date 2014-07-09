using System.Web;
using Abp.Localization.Sources.Xml;

namespace RestoAddicted.Web.Localization.RestoAddicted
{
    public class RestoAddictedLocalizationSource : XmlLocalizationSource
    {
        public RestoAddictedLocalizationSource()
            : base("RestoAddicted", HttpContext.Current.Server.MapPath("/Localization/RestoAddicted"))
        {
        }
    }
}