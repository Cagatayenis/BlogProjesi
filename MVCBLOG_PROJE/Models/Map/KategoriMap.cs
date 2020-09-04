using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MVCBLOG_PROJE.Models.Entity;

namespace MVCBLOG_PROJE.Models.Map
{
    public class KategoriMap:EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            HasKey(x => x.ID);
            Property(x => x.Ad).HasMaxLength(30).IsRequired();
            Property(x => x.Aciklama).HasMaxLength(50).IsOptional();

            HasMany(ma => ma.Makaleler).WithOptional(kat => kat.Kategori).HasForeignKey(ma => ma.KategoriID);
        }
    }
}