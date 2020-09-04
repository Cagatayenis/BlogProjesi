using MVCBLOG_PROJE.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace MVCBLOG_PROJE.Models.Map
{
    public class MakaleEtiketMap:EntityTypeConfiguration<MakaleEtiket>
    {
        public MakaleEtiketMap()
        {
            HasKey(x => new { x.MakaleID, x.EtiketID });
            Property(x => x.MakaleID).IsRequired();
            Property(x => x.EtiketID).IsRequired();
        }
    }
}