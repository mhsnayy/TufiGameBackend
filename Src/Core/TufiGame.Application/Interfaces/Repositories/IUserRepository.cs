using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Entities;

namespace TufiGame.Application.Interfaces.Repositories
{
    public interface IUserRepository:IGenericRepositoryAsync<User>
    {
    }
}
