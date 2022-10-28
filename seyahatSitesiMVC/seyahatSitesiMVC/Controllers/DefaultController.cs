using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatSitesiMVC.Models.siniflar;
namespace seyahatSitesiMVC.Controllers
{
    public class DefaultController : Controller
    {

        context veri = new context();
        public ActionResult Index()
        {
            var degerler = veri.blogs.Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }


        public PartialViewResult partial1()
        {
            var degerler = veri.blogs.OrderByDescending(x => x.ID).Take(2).ToList(); // z den a ya göre sadece 2 id yi al.
            return PartialView(degerler);
        }

        public PartialViewResult partial2()
        {
            var degerler = veri.blogs.Where(x => x.ID == 1).ToList(); // blogs tablosundan ıd si 1 olan alanın listesini partialView e atacak.
            return PartialView(degerler);
        }


        public PartialViewResult partial3()
        {
            var degerler = veri.blogs.Take(10).ToList();
            return PartialView(degerler);
        }


        public PartialViewResult partial4()
        {
            var degerler = veri.blogs.Take(3).ToList();
            return PartialView(degerler);
        }


        public PartialViewResult partial5()
        {
            var degerler = veri.blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }
    }
}