using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.ViewModel
{
    public class MakaleDetayViewModel
    {
        public MakaleDetayViewModel()
        {
            Yorumlar = new List<Yorum>();
        }
        public Makale Makale { get; set; }

        public List<Yorum> Yorumlar { get; set; }

       
    }

    
}