using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Common;

namespace TufiGame.Domain.Entities
{
    public class Item:BaseEntity
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int Statu { get; set; }//bunu enum ile düzenleyeceğiz
        public Guid VendorId { get; set; }
        public Guid CategoryId { get; set; }
    }
}
