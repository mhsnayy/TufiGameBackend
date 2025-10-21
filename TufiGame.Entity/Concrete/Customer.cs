using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Entity.Abstract;

namespace TufiGame.Entity.Concrete
{
    public class Customer:IEntity
    {
        public  int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string TradeLink { get; set; }
        public int SteamId { get; set; }


    }
}
