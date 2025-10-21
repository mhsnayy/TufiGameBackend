using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Entity.Abstract;

namespace TufiGame.Entity.Concrete
{
    public class ItemCategory:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
    }
}
