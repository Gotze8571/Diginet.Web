using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackofficeWireframe.Controllers
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

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult TradeAction()
        {
            return View();
        }

        public ActionResult GoldAccount()
        {
            return View();
        }

        public ActionResult SilverAccount()
        {
            return View();
        }

        public ActionResult TokenAccount()
        {
            return View();
        }
    }
}