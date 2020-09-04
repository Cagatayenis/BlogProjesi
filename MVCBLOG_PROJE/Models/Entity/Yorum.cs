using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Yorum
    {
        public int ID { get; set; }
        public string Icerik { get; set; }
        public Nullable<DateTime> YorumTarihi { get; set; }

        public int? MakaleID { get; set; }
        public virtual Makale Makale { get; set; }

        public Nullable<int> UyeID { get; set; }
        public virtual Uye Uye { get; set; }
    }
}