using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class UyeMap:EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            HasKey(x => x.ID);
            Property(x => x.Ad).IsRequired().HasMaxLength(20);
            Property(x => x.Soyad).IsRequired().HasMaxLength(30);
            Property(x => x.KullaniciAdi).IsRequired().HasMaxLength(20);
            Property(x => x.Sifre).IsRequired().HasMaxLength(10);
            Property(x => x.Email).IsRequired().HasMaxLength(20);
            Property(x => x.Cinsiyet).IsOptional();

            HasMany(mak => mak.Makaleler).WithOptional(uy => uy.Uye).HasForeignKey(mak => mak.UyeID);
            HasMany(yor => yor.Yorumlar).WithOptional(uy => uy.Uye).HasForeignKey(yor => yor.UyeID);
        }

    }
}