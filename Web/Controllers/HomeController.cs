using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
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

        public ActionResult TitanX()
        {
            ViewBag.Message = "Your TitanX page.";

            return View();
        }
        public ActionResult RX480()
        {
            ViewBag.Message = "Your TitanX page.";

            return View();
        }
        public ActionResult Upcoming()
        {
            ViewBag.Message = "Your TitanX page.";

            return View();
        }
        public ActionResult clock()
        {
            ViewBag.Message = "clock";

            return View();
        }


    }
}