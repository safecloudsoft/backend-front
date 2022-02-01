using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        DataManager dataManager = new DataManager();
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DataList(string p)
        {
           
            p = (string)Session["UserName"];
            int id = context.Users.Where(x => x.UserName == p).Select(y => y.UserId).FirstOrDefault();
            var data = dataManager.GetDataByUserName(id);
            return View(data);
        }

        [HttpGet]
        public ActionResult AddNewImage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddNewImage(Data p)
        {

            if (Request.Files.Count > 0)
            {
                string DosyaAdi = Path.GetFileName(Request.Files[0].FileName);
                string DosyaUzantı = Path.GetExtension(Request.Files[0].FileName);
                string DosyaYolu = "~/Image/" + DosyaAdi + DosyaUzantı;
                Request.Files[0].SaveAs(Server.MapPath(DosyaYolu));
                p.Image = "/Image/" + DosyaAdi + DosyaUzantı;
            }
            context.Dataes.Add(p);
            context.SaveChanges();
            return RedirectToAction("DataList", "Data");
        }

        public ActionResult DeleteImage(int id)
        {
            dataManager.DeleteBlog(id);
            return RedirectToAction("DataList");
        }

    }
}