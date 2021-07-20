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
            return new FilePathResult("~/diginet-html/login.html", "text/html");
        }
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if(username == null && password == null)
            return new FilePathResult("~/diginet-html/login.html", "text/html");
            else
            {
                return new FilePathResult("~/diginet-html/index.html", "text/html");
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