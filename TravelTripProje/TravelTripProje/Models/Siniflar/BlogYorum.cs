using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Deger1 { get; set; } //	Blog listesi veya detay
        public IEnumerable<Yorumlar> Deger2 { get; set; } //	Bloga ait yorumlar (veya son yorumlar)
        public IEnumerable<Blog> Deger3 { get; set; } // 	Son bloglar

    }
}