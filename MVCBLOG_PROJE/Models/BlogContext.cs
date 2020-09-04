using MVCBLOG_PROJE.Models.Entity;
using MVCBLOG_PROJE.Models.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext():base("Server=CAGI\\SQLEXPRESS; Database=BLOG_MVC; UID=sa; PWD=123")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new YorumMap());
            modelBuilder.Configurations.Add(new EtiketMap());
            modelBuilder.Configurations.Add(new MakaleEtiketMap());
            modelBuilder.Configurations.Add(new RolMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Makale> Makaleler { get; set; }
        public DbSet<Uye> Uyelerler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Etiket> Etiketler { get; set; }
        public DbSet<MakaleEtiket> MakaleEtiketler { get; set; }
        public DbSet<Rol> Rol { get; set; }
    }
}