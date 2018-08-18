using System.Configuration;
using System.Web.Mvc;

namespace LegacyMvcExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var message = ConfigurationManager.AppSettings["Message"];
            var model = new Models.Example(message);
            return View(model);
        }
    }
}