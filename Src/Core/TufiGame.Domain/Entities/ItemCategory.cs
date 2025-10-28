using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Common;

namespace TufiGame.Domain.Entities
{
    public class ItemCategory:BaseEntity
    {
        public string Name { get; set; }
        public Guid GameId { get; set; }
    }
}
