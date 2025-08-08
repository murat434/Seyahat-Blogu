using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Kullanıcı adı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "Kullanıcı adı en fazla 50 karakter olabilir.")]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Mail adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir mail adresi giriniz.")]
        [Display(Name = "E-Posta")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Yorum alanı boş bırakılamaz.")]
        [StringLength(500, ErrorMessage = "Yorum en fazla 500 karakter olabilir.")]
        [Display(Name = "Yorum")]
        public string Yorum { get; set; }

        [Required]
        [Display(Name = "Blog ID")]
        public int Blogid { get; set; }

        [ForeignKey("Blogid")]
        public virtual Blog Blog { get; set; }
    }
}