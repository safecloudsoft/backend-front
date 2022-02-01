using BusinessLayer;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userProfileManager = new UserProfileManager();
        public ActionResult Index(string p)
        {
            
            p = (string)Session["UserName"];
            var profileValues = userProfileManager.GetUserByUserName(p);
            
            return View(profileValues);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("UserLogin", "Login");
        }
    }
}