using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class YorumMap:EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            ToTable("Yorumlar");
            HasKey(x => x.ID);
            Property(x => x.Icerik).HasMaxLength(300).IsOptional();
            Property(x => x.YorumTarihi).IsOptional();
        }
    }
}