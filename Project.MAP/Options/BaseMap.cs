using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    //Eger C#'ta oldugundan emin oldugunuz bir yapı Intellisense'te gelmiyorsa using tarafına (kütüphane entegrasyonlarınıza bakın)... Eger using secenegi de gelmiyorsa bulundugunuz projenin referanslarına bakarak ilgili referansı vermeniz gerekir

    public abstract class BaseMap<T>:EntityTypeConfiguration<T> where T:BaseEntity
    {
        public BaseMap()
        {
            Property(x => x.CreatedDate).HasColumnName("Veri Yaratma Tarihi");
        }
    }
}
