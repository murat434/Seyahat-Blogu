using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
   
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        [Authorize]
        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult YeniBlog(Blog p)

        {
            c.Blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult BlogSil(int id)
        {
            var b=c.Blogs.Find(id); 
            c.Blogs.Remove(b);
            c.SaveChanges() ;
            return RedirectToAction("Index");   
        }
        [Authorize]
        public ActionResult BlogGetir(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("BlogGetir",bl);
        }
        [Authorize]
        public ActionResult BlogGuncelle(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Aciklama=b.Aciklama;
            blg.Baslik=b.Baslik;
            blg.BlogImage=b.BlogImage;  
            blg.Tarih=b.Tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        [Authorize]
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        [Authorize]
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir",yr);
        }
        [Authorize]
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yr= c.Yorumlars.Find(y.ID);
            yr.KullaniciAdi = y.KullaniciAdi;
            yr.Mail = y.Mail;
            yr.Yorum = y.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
       

        // Hakkımızda listesi
        public ActionResult HakkimizdaListe()
        {
            var bilgi = c.Hakkimizdas.ToList();
            return View(bilgi);
        }

        // Güncelleme için veriyi getir
        [HttpGet]
        public ActionResult HakkimizdaGetir(int id)
        {
            var bilgi = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", bilgi);
        }

        // Güncelleme işlemi
        [HttpPost]
        public ActionResult HakkimizdaGuncelle(Hakkimizda h)
        {
            var bilgi = c.Hakkimizdas.Find(h.ID);
            bilgi.FotoUrl = h.FotoUrl;
            bilgi.Aciklama = h.Aciklama;
            c.SaveChanges();
            return RedirectToAction("HakkimizdaListe");
        }
        // Iletisim mesajlarını listele
        public ActionResult haberlesmeListe()
        {
            var mesajlar = c.haberlesmes.ToList();
            return View(mesajlar);
        }

        // Mesajı getir
        [HttpGet]
        public ActionResult haberlesmeGetir(int id)
        {
            var mesaj = c.haberlesmes.Find(id);
            return View("haberlesmeGetir", mesaj);
        }

        // Mesajı sil
        public ActionResult haberlesmeSil(int id)
        {
            var silinecek = c.haberlesmes.Find(id);
            c.haberlesmes.Remove(silinecek);
            c.SaveChanges();
            return RedirectToAction("haberlesmeListe");
        }

    }
}