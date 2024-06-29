using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Entity
{
    public class Kiralamalar : BaseEntity
    {
        public int ArabaID { get; set; }
        public int YoneticiID { get; set; }

        public virtual Arabalar Arabalar { get; set; }
        public virtual Yoneticiler Yoneticiler { get; set; }

        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int? KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }
    }
}
