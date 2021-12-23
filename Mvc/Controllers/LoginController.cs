using BusinessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Mvc.Controllers
{
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager();
        // GET: Login
        [HttpGet]
        public ActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserLogin(User p)
        {
            Context context = new Context();
            var girisKontrol = context.Users.FirstOrDefault(x => x.UserName == p.UserName && x.Password == p.Password);
            if (girisKontrol != null)
            {
                FormsAuthentication.SetAuthCookie(girisKontrol.UserName, false);
                Session["UserName"] = girisKontrol.UserName.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
               return RedirectToAction("UserLogin", "Login");
            }
            
        }
        [HttpGet]
        public ActionResult UserRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegister(User user)
        {
            userManager.AddUserBL(user);
            return RedirectToAction("UserLogin", "Login");
        }
    }
}