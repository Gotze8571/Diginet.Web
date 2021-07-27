using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackofficeWireframV2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gold()
        {
            return View();
        }
        
        public ActionResult Silver()
        {
            return View();
        }
        public ActionResult DigiToken()
        {
            return View();
        }
    }
}