using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using seyahatSitesiMVC.Models.siniflar;
namespace seyahatSitesiMVC.Controllers
{
    public class AdminController : Controller
    {
        context veri = new context();
      
        // GET: Admin
     [Authorize]
        public ActionResult Index()
        {
            var bloglar = veri.blogs.ToList();

            return View(bloglar);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(blog p)
        {
            veri.blogs.Add(p); // contextten oluşturmuş olduğum nesneye bağlı olarak blog tablosuna değerleri ekle p (textboxfordan gelen değerler)
            veri.SaveChanges();

            return RedirectToAction("Index");
        }


        public ActionResult BlogSil(int id)
        {
            var sil = veri.blogs.Find(id);
            veri.blogs.Remove(sil);
            veri.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BlogVeriGetir(int id)
        {
            var v = veri.blogs.Find(id);
            return View("BlogVeriGetir",v);
        }


        public ActionResult BlogGuncelle(blog b)
        {
            var blg = veri.blogs.Find(b.ID); // bloglar tablosuna b den göndermiş olduğum id ye göre ilgili alanı bul. 
            blg.Baslik = b.Baslik; // yeni açıklama değeri b den gelen açıklama değeri olacak.
            blg.Aciklama = b.Aciklama;
            blg.Tarih = b.Tarih;
            blg.BlogImage = b.BlogImage;
            veri.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult YorumListesi()
        {
            var liste = veri.yorumlars.ToList();
            return View(liste);
        }

        public ActionResult yorumSil(int id)
        {
            var sil = veri.yorumlars.Find(id);
            veri.yorumlars.Remove(sil);
            veri.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult yorumGetir(int id)
        {
            var v = veri.yorumlars.Find(id);
            return View("yorumGetir", v); // blog getir sayfasına git ve ordan gelecek değerlerle birlikte.
        }


        public ActionResult yorumGuncelle(yorumlar yrm)
        {
            var adminYorum = veri.yorumlars.Find(yrm.ID);
            adminYorum.KullaniciAdi = yrm.KullaniciAdi;
            adminYorum.Mail = yrm.Mail;
            adminYorum.Yorum = yrm.Yorum;
            veri.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}