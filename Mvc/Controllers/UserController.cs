using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userProfileManager = new UserProfileManager();
        public ActionResult Index(string p)
        {
           
            var profileValues = userProfileManager.GetUserByUserName(p);
            return View(profileValues);
        }
    }
}