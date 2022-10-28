using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatSitesiMVC.Models.siniflar;
namespace seyahatSitesiMVC.Controllers
{
    public class BlogController : Controller
    {
        context veri = new context();

        BlogYorum by = new BlogYorum();



        // GET: Blog
        public ActionResult Index()
        {
            by.Deger1 = veri.blogs.ToList(); // Sql de veri tabanı içerisindeki blogs tablosu içindeki verileri çektik.
            by.Deger3 = veri.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            by.Deger4 = veri.yorumlars.Take(3).ToList();
            return View(by);
        }


      
        public ActionResult BlogDetay(int id)
        {
            // var BlogBul = veri.blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = veri.blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = veri.yorumlars.Where(x => x.blogId == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(yorumlar y)
        {
            veri.yorumlars.Add(y);
            veri.SaveChanges();
            return PartialView();
        }
    }
}