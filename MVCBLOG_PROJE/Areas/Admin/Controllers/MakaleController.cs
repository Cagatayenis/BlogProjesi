using MVCBLOG_PROJE.Models;
using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBLOG_PROJE.Areas.Admin.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Admin/Makale

        BlogContext db = new BlogContext();

        public ActionResult Index()
        {
            var makaleler = db.Makaleler.ToList();
            return View(makaleler);
        }

        public ActionResult MakaleEkle()
        {

            List<SelectListItem> kategoriler = new List<SelectListItem>();

            foreach (var item in db.Kategoriler.ToList())
            {
                kategoriler.Add(new SelectListItem { Text = item.Ad, Value = item.ID.ToString() });
            }
            ViewBag.KategoriID = kategoriler;


            return View();
        }

        [HttpPost]
        public ActionResult MakaleEkle(Makale makale)
        {
            makale.EklenmeTarihi = DateTime.Now;
            makale.Onaylandimi = false;
            makale.Yayindami = false;

            db.Makaleler.Add(makale);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {          
            Makale guncellenecek = db.Makaleler.Find(id);
            int kid =(int)guncellenecek.KategoriID;
            ViewBag.KategoriID = new SelectList(db.Kategoriler.ToList(), "ID", "Ad",kid);
            return View(guncellenecek);
        }
        [HttpPost]
        public ActionResult Update(Makale item)
        {
            Makale guncellenecek = db.Makaleler.Find(item.ID);
            db.Entry(guncellenecek).CurrentValues.SetValues(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            db.Makaleler.Remove(db.Makaleler.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumEkle()
        {

            return View();
        }

        [HttpPost]
        public ActionResult YorumEkle(Yorum m)
        {
            Uye u = db.Uyelerler.FirstOrDefault(x => x.KullaniciAdi == User.Identity.Name);
            m.UyeID = u.ID;
            db.Yorumlar.Add(m);
            db.SaveChanges();
            return RedirectToAction("MakaleDetay", "Home", new { id = m.MakaleID, area = "" });
        }
    }
}