using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.Entities.Abstract;

namespace ScaleTransfer.Entities.Concrete
{
    public class Yevmiye : IEntity
    {
        public int SabitId { get; set; }
        public int GrupNo { get; set; }
        public int HizmetYili { get; set; }
        public double GunlukCalismaBedeli { get; set; }
    }
}
