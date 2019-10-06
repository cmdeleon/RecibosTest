using Newtonsoft.Json;
using RecibosTest.Models;
using RecibosTest.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace RecibosTest.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index(string ReturnUrl = "")
        {
            if (User.Identity.IsAuthenticated)
            {
                return LogOut();
            }
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario loginView, string ReturnUrl = "")
        {
            if (ModelState.IsValid)
            {
                if (Membership.ValidateUser(loginView.Username, loginView.Password))
                {
                    var user = (CustomMembershipUser)Membership.GetUser(loginView.Username, false);
                    if (user != null)
                    {
                        Session.Add("user", user);
                    }

                    if (Url.IsLocalUrl(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", null);
                    }
                }
            }
            ModelState.AddModelError("", "Something Wrong : Username or Password invalid");
            return View(loginView);
        }

        public ActionResult LogOut()
        {
            Session.Clear();

            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login", null);
        }

    }
}