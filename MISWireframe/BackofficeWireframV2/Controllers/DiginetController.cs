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