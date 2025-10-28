using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Common;

namespace TufiGame.Domain.Entities
{
    public class Trade:BaseEntity
    {
        public int Statu { get; set; }//enum ile yapmam lazım oluştu mu beklemede mi gibi gibi
        public Guid VendorId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ItemId { get; set; }
    }
}
