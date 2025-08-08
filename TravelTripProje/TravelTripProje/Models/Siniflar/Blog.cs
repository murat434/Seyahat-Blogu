﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Başlık")]
        public string Baslik { get; set; }

        [Display(Name = "Tarih")]
        public DateTime Tarih { get; set; }

        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        [Display(Name = "Fotoğraf")]
        public string BlogImage { get; set; }

        [Display(Name = "Yorumlar")]
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}