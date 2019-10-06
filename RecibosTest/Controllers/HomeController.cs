using RecibosTest.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecibosTest.Controllers
{    
    public class HomeController : Controller
    {      
        public ActionResult Index()
        {           
            if (Session["user"] == null)
            {
                return RedirectToAction("Index", "Login", null);
            }

            var user = (CustomMembershipUser)Session["user"];

            ViewBag.Title = "Registros";
            ViewBag.UserId = user.UserId;

            return View();
        }
    }
}
