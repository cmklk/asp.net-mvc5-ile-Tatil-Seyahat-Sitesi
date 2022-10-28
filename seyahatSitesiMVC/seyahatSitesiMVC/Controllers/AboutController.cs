using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatSitesiMVC.Models.siniflar;
namespace seyahatSitesiMVC.Controllers
{
    public class AboutController : Controller
    {
        context sinif = new context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = sinif.hakkimizdas.ToList();
            return View(degerler);
        }
    }
}