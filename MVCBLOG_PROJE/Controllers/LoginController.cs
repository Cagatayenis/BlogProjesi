using MVCBLOG_PROJE.Models;
using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
namespace MVCBLOG_PROJE.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        BlogContext db = new BlogContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Giris()
        {

            return View();
        }


        [HttpPost]
        public ActionResult Giris(Uye u)
        {
            Uye uye = db.Uyelerler.FirstOrDefault(x => x.KullaniciAdi == u.KullaniciAdi && x.Sifre == u.Sifre);
            if (uye != null)
            {
                if (uye.Rol.RolAdi == "Admin")
                {
                    FormsAuthentication.SetAuthCookie(u.KullaniciAdi, false);
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }

                FormsAuthentication.SetAuthCookie(u.KullaniciAdi, false);
                return RedirectToAction("Index", "Home");
            }
            return View("Giris");
        }

        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}