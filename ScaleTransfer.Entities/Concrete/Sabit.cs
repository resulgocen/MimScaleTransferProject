using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScaleTransfer.Entities.Abstract;

namespace ScaleTransfer.Entities.Concrete
{
    public class Sabit : IEntity
    {
        public int Id { get; set; }
        public string MaasAciklama { get; set; }
    }
}
