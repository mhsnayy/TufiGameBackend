using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TufiGame.Application.Features.CQRS.Commands.UserCommands
{
    public class RemoveUserCommand
    {
        public Guid Id { get; set; }
    }
}
