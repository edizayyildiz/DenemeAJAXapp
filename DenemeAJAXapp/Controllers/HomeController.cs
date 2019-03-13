using DenemeAJAXapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenemeAJAXapp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Kroki()
        {
            return PartialView("KrokiPartial");
        }
        public ActionResult KrokiYolunuGetir()
        {
            var yol = "/Images/kroki.jpg";
            return Json(yol, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FeedBackIndex()
        {
            using (var db = new ApplicationDbContext())
            {
                var feedback = db.FeedBacks.ToList();
                return PartialView(feedback);
            }
        }

        public ActionResult FeedBackCreate()
        {
            var feedback = new FeedBack();
            return PartialView(feedback);
        }

        [HttpPost]
        public ActionResult FeedBackCreate(FeedBack entity)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ApplicationDbContext())
                {
                    db.FeedBacks.Add(entity);
                    db.SaveChanges();
                }
                return RedirectToAction("FeedBackIndex");
            }
            return View();
            
        }
        
    }
}