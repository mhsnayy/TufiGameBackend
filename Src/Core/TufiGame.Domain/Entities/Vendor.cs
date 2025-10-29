using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Common;

namespace TufiGame.Domain.Entities
{
    public class Vendor:BaseEntity
    {
        public Guid UserId{ get; set; }
        public ICollection<Item> Items { get; set; }
        public ICollection<Trade> Trades { get; set; }
        public ICollection<TradeUrl> TradeUrls { get; set; }
        public User User { get; set; }
    }
}
