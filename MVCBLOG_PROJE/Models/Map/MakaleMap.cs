using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class MakaleMap:EntityTypeConfiguration<Makale>
    {
        public MakaleMap()
        {
            HasKey(x => x.ID);
            Property(x => x.Baslik).HasMaxLength(500).IsRequired();
            Property(x => x.Icerik).HasMaxLength(1000).IsRequired();
            Property(x => x.EklenmeTarihi).IsOptional();
            Property(x => x.Onaylandimi).IsOptional();
            Property(x => x.Yayindami).IsOptional();
            
            HasMany(yor => yor.Yorumlar).WithOptional(mak => mak.Makale).HasForeignKey(mak => mak.MakaleID);
        }
    }
}