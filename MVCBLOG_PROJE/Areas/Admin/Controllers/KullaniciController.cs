using MVCBLOG_PROJE.Models;
using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBLOG_PROJE.Areas.Admin.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Admin/Kullanici
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult UyeOL()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UyeOL(Uye uye)
        {
            Rol rolid = db.Rol.FirstOrDefault(x => x.RolAdi == "Uye");
            uye.RolID = rolid.ID;
            db.Uyelerler.Add(uye);
            db.SaveChanges();

            return RedirectToAction("Index", "Home", new { area = "" });
        }

        public ActionResult YazarBasvuru()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YazarBasvuru(Uye u,string Yazar)
        {
            Uye yo = db.Uyelerler.FirstOrDefault(x => x.KullaniciAdi == u.KullaniciAdi && x.Sifre == u.Sifre);

            if (yo != null && Yazar=="on")
            {
                Rol r = db.Rol.FirstOrDefault(x => x.RolAdi == "Yazar");
                yo.Yazar = true;
                yo.Onaylandimi = false;
                yo.RolID = r.ID;
                db.SaveChanges();
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewBag.Hata = "Kutucugu işaretleyiniz.";
            return View();
        }


    }
}