using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TufiGame.Application.Features.CQRS.Queries.UserQueries
{
    public class GetUserByIdQuery
    {
        public Guid Id { get; set; }
    }
}
