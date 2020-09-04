using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBLOG_PROJE.Models;
using MVCBLOG_PROJE.Models.Entity;
using MVCBLOG_PROJE.ViewModel;

namespace MVCBLOG_PROJE.Controllers
{
    public class HomeController : Controller
    {
        BlogContext db = new BlogContext();

        MakaleDetayViewModel mdl = new MakaleDetayViewModel();

        public ActionResult Index()
        {
            List<Makale> aktif = db.Makaleler.Where(x => x.Onaylandimi == true && x.Yayindami == true).Take(4).ToList();


            return View(aktif);
        }

        

        public ActionResult MakaleDetay(int id)
        {
            mdl.Makale = db.Makaleler.Find(id);
            mdl.Yorumlar = db.Yorumlar.Where(x => x.MakaleID == id).ToList();
            return View(mdl);
        }

        public PartialViewResult PopularPost()
        {
            var populer = db.Makaleler.Where(x => x.Onaylandimi == true && x.Yayindami == true).Take(3).ToList();
            return PartialView(populer);
        }

        [Authorize(Roles ="Admin")]
        public ActionResult MakaleListe()
        {
            
            var aktif = db.Makaleler.Where(x => x.Onaylandimi == true && x.Yayindami == true).ToList();
            return View(aktif);
        }
        public PartialViewResult _kategoriler()
        {
            var sorgu = from k in db.Kategoriler
                        join m in db.Makaleler on
                        k.ID equals m.KategoriID
                        group k by new {k.ID,k.Ad}
                        into g
                        select new Deneme
                        {
                            Ad=g.Key.Ad,
                            ID=g.Key.ID,
                            Adet=g.Count()
                        };

            //var kategoriler = db.Kategoriler.ToList();


            return PartialView(sorgu.ToList());
        }

        public ActionResult Listeleme(int id)
        {
            var katid = db.Makaleler.Where(x => x.KategoriID == id).ToList();
            return View("MakaleListe", katid);


        }


    }
}