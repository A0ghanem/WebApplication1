using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Models.users u )
        {

            Session["userID"] = "1";

                return View();
        }


        public ActionResult Logout()
        {
            Session["userID"] = null;
            return RedirectToAction("Login");
        }
    }
}