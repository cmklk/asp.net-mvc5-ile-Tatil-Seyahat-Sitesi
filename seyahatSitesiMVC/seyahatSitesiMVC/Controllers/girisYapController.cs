using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using seyahatSitesiMVC.Models.siniflar;
namespace seyahatSitesiMVC.Controllers
{
    public class girisYapController : Controller
    {
        // GET: girisYap
        context veri = new context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(admin a)
        {
            var bilgiler = veri.admins.FirstOrDefault(x => x.kullanici == a.kullanici && x.sifre == a.sifre);
            if(bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullanici, false);
                Session["kullanıcı"] = bilgiler.kullanici.ToString();
               
                return RedirectToAction("Index", "Admin");
            }

            else
            {
                return View();
            }
        }


        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","girisYap");
        }
    }
}