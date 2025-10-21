using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Entity.Abstract;

namespace TufiGame.Entity.Concrete
{
    public class Trade:IEntity
    {
        public int Id { get; set; }
        public int CustomerReqId { get; set; }
        public int CustomerReplyId { get; set; }
        public int GameId { get; set; }
        public int ItemId { get; set; }
        public string Status { get; set; }

    }
}
