using MVCBLOG_PROJE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBLOG_PROJE.Models.Entity;

namespace MVCBLOG_PROJE.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Admin/Category
        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            var cat = db.Kategoriler.ToList();
            return View(cat);
        }

        public ActionResult Yeni()
        {
            return View("KatForm");
        }

        [HttpPost]
        public ActionResult Kaydet(Kategori item)
        {
            if(item.ID==0)
            {
                db.Kategoriler.Add(item);
                
            }
            else
            {
                Kategori guncellenecek = db.Kategoriler.Find(item.ID);
                db.Entry(guncellenecek).CurrentValues.SetValues(item);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Guncelle(int id)
        {
            Kategori güncellenecek = db.Kategoriler.Find(id);
            return View("KatForm",güncellenecek);
        }

        public ActionResult Sil(int id)
        {
            db.Kategoriler.Remove(db.Kategoriler.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}