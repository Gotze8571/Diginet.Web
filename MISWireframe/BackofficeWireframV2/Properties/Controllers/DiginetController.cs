using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackofficeWireframV2.Controllers
{
    public class DiginetController : Controller
    {
        // GET: Diginet
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login(string returnUrl, string username, string password)
        {
            return  View("~/diginet-html/login.html");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username == null && password == null)
            return View("~/diginet-html/login.html");
            else
            {
                return View("~/diginet-html/index.html");
            }
        }

        public ActionResult TradeAction()
        {
            return View();
        }
        public ActionResult GoldLedger()
        {
            return View();
        }
        public ActionResult SilverLedger()
        {
            return View();
        }
        public ActionResult DigiTokenLedger()
        {
            return View();
        }
    }
}