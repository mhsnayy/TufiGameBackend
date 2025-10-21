using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Entity.Abstract;

namespace TufiGame.Entity.Concrete
{
    public class Item:IEntity
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int CustomerId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
