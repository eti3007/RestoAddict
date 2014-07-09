using System.Web.Mvc;

namespace RestoAddicted.Web.Controllers
{
    public class HomeController : RestoAddictedControllerBase
    {
        public ActionResult Index()
        { 
            return View();
        }
	}
}