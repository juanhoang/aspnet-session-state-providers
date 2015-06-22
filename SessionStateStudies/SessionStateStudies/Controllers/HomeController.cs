using System;
using System.Web.Mvc;

namespace SessionStateStudies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            TrySetAndGetFromSession(ViewBag);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void TrySetAndGetFromSession(dynamic viewBag)
        {
            if (Session["LastVisit"] == null)
            {
                Session["LastVisit"] = DateTime.Now;
            }
            viewBag.LastVisit = Session["LastVisit"];
        }
    }
}
