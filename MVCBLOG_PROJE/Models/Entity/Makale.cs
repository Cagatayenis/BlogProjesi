using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Makale
    {
        public Makale()
        {
            Yorumlar = new List<Yorum>();
           
        }
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Nullable<DateTime> EklenmeTarihi { get; set; }
        //public byte Foto { get; set; }
        public bool Onaylandimi { get; set; }
        public bool Yayindami { get; set; }

        public int? KategoriID { get; set; }
        public virtual Kategori Kategori{ get; set; }

        public Nullable<int> UyeID { get; set; }
        public virtual Uye Uye { get; set; }

        public List<Yorum> Yorumlar { get; set; }

        public List<MakaleEtiket> MakaleEtiket { get; set; }
    }
}