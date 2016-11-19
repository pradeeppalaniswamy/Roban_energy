using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RobanEnergy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }





        public ActionResult currentprojects()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult upcommingprojects()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Projecttanzania()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult products()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}