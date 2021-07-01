using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MISWireframe.Controllers
{
    public class MISController : Controller
    {
        // GET: MIS
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerReport()
        {
            return View();
        }
    }
}