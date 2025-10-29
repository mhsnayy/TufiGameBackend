using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Common;

namespace TufiGame.Domain.Entities
{
    public class TradeUrl:BaseEntity
    {
        public string Url { get; set; }
        public Guid CustomerId { get; set; }
        public Guid VendorId { get; set; }
        public Customer Customer { get; set; }
        public Vendor Vendor { get; set; }
    }
}
