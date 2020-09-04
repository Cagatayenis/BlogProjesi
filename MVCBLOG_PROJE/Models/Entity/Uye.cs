using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Uye
    {

        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Email { get; set; }
        public bool Cinsiyet { get; set; }
        public bool Yazar { get; set; }
        public bool Onaylandimi { get; set; }
        

        public Nullable<int> RolID { get; set; }
        public virtual Rol Rol { get; set; }

        public List<Makale> Makaleler { get; set; } = new List<Makale>();
        public List<Yorum> Yorumlar { get; set; } = new List<Yorum>();
    }
}