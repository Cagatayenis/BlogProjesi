using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Etiket
    {
        public int ID { get; set; }
        public string Ad { get; set; }

        public List<MakaleEtiket> MakaleEtiket { get; set; } = new List<MakaleEtiket>();
    }
}