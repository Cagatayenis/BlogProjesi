using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Entity
{
    public class Rol
    {
        public Rol()
        {
            Uyeler = new List<Uye>();
        }
        public int ID { get; set; }
        public string RolAdi { get; set; }

        public List<Uye> Uyeler { get; set; }

    }
}