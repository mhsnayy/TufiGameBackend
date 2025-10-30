using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Entities;

namespace TufiGame.Application.Features.CQRS.Results.UserResults
{
    public class GetUserByIdQueryResult
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string SteamId { get; set; }
        public string Balance { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime MembershipDate { get; set; }
        public Guid CustomerId { get; set; }
        public Guid VendorId { get; set; }
        public Customer Customer { get; set; }
        public Vendor Vendor { get; set; }


    }
}
