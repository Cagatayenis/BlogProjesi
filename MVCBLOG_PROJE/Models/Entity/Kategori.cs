using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Kategori
    {
        public Kategori()
        {
            Makaleler = new List<Makale>();
        }
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Aciklama{ get; set; }

        public List<Makale> Makaleler { get; set; }
    }
}