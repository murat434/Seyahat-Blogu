using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
       
        public ActionResult Index()
        {
            BlogYorum by = new BlogYorum();
            //var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger2 = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            BlogYorum by = new BlogYorum();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).OrderByDescending(x => x.ID).ToList(); // Tüm yorumlar gelsin
            by.Deger3 = c.Blogs.OrderByDescending(x => x.Tarih).Take(3).ToList();
            return View(by);
        }


        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            BlogYorum by = new BlogYorum();
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            BlogYorum by = new BlogYorum();
            c.Yorumlars.Add(y);
            c.SaveChanges();
            //BlogYorum blogYorum = new BlogYorum();
            //blogYorum.Deger1 = c.Blogs.Where(a => a.ID == y.Blogid);
            //blogYorum.Deger2 = c.Yorumlars.Where(x => x.Blogid == y.Blogid).ToList();

            // Yorum yapıldıktan sonra yorumları tekrar çek
            var yorumlar = c.Yorumlars.Where(x => x.Blogid == y.Blogid).ToList();

            return PartialView("YorumYap", "Blog"); // PartialView ismi doğru olmalı

        }
    }
}