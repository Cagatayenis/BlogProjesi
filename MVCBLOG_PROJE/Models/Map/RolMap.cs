using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class RolMap:EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            ToTable("Roller");
            HasKey(x => x.ID);
            Property(x => x.RolAdi).IsRequired().HasMaxLength(10);

            HasMany(u => u.Uyeler).WithOptional(r => r.Rol).HasForeignKey(ur => ur.RolID);
        }
    }
}