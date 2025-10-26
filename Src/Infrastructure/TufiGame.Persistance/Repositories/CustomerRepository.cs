using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Application.Interfaces.Repository;
using TufiGame.Domain.Entities;
using TufiGame.Persistance.Context;

namespace TufiGame.Persistance.Repositories
{
    public class CustomerRepository:GenericRepository<Customer>, ICustomerRespository
    {
        public CustomerRepository(ApplicationDbContext dbContext): base(dbContext)
        {
        }
    }
}
