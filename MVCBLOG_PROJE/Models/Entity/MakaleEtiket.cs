using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class MakaleEtiket
    {
        public int MakaleID { get; set; }
        public int EtiketID { get; set; }

        public virtual Makale Makale { get; set; }
        public virtual Etiket Etiket { get; set; }
    }
}