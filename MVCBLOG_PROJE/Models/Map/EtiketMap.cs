using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class EtiketMap:EntityTypeConfiguration<Etiket>
    {
        public EtiketMap()
        {
            ToTable("Etiket");
            HasKey(x => x.ID);
            Property(x => x.Ad).HasMaxLength(30).IsOptional();
        }
    }
}