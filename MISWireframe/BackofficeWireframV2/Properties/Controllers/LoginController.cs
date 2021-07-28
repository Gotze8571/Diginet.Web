using BackofficeWireframV2.Extension;
using BackofficeWireframV2.Models;
using DiginetSite.Domain.Data;
using DiginetSite.Domain.Entity;
using DiginetSite.Domain.Extension;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackofficeWireframV2.Controllers
{
    public class LoginController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private readonly LoginDbContext context;
        // GET: Login
        public ActionResult Index(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Customer user, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    LoginUserDB login = new LoginUserDB();
                    //string hostName;
                    //hostName = Dns.GetHostEntry(Request.ServerVariables["REMOTE_HOST"]).HostName;

                    string machineName = System.Environment.MachineName;

                    //ViewBag.Message = hostName;
                    ViewBag.Message = machineName;
                    if (login.ValidLogin(user.Email, user.Password, machineName))
                    {

                       // FormsAuthentication.SetAuthCookie(user.UserId, true);

                        logger.Info("Signed in User: " + user.Email);

                        string UserId = Session["user.Email"] as string;
                        //Customer customer = new Customer()
                        //{
                        //    First_Name = "null",
                        //    Last_Name = "null",
                        //    ExternalSystem_ID = "null",
                        //    Email = user.Email,
                        //    Password = user.Password,
                        //    WebhookResponse_ID = 1,
                        //    Is_Active = 1,
                        //    Creation_Date = DateTime.Now,
                        //    CustomerType_ID = 1,
                        //    Join_Date = DateTime.Now,
                        //    Updated_Date = DateTime.Now,
                        //    Phone = "08066581487",
                        //    Rank_ID = 1,
                        //    Updated_By = 1
                        //};
                        //context.Customers.Add(customer);
                        //context.SaveChanges();

                        logger.Info("IP Address: " + UserIPAddress.GetIPAddress());
                        
                        logger.Info("IP Address: " + machineName);
                        ViewBag.Message = "hostName";

                        // return RedirectToLocal(returnUrl);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("message", "incorrect login details!");
                        ViewBag.Message = "Incorrect login details";

                        //logger.Info("Incorrect login details");
                        // return RedirectToAction("Index", "Login");
                        return View();
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("message", "Unable to connect to server");
                    //logger.Error(ex);
                }
            }
            else
            {
                ModelState.AddModelError("message", "Server not connected!");
                ViewBag.Message = "Server not connected!";
                //ErrorLoan err = new ErrorLoan
                //{
                //    //StartDate = ,
                //    //EndDate = DateTime.Now,
                //    LoginUser = user.UserId,
                //    FetchedData = false,
                //    ErrorName = "ADService not reachable!!",
                //    ErrorDate = DateTime.Now
                //};

            }
            return View(user);
        }


    }
}