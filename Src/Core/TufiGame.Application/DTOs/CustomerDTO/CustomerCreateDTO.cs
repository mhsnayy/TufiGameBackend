using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Entities;

namespace TufiGame.Application.DTOs.CustomerDTO
{
    public class CustomerCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SteamId { get; set; }
        public ICollection<TradeUrl> TradeUrls { get; set; }
    }
}
