using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TufiGame.Domain.Entities;

namespace TufiGame.Persistance.Context
{
    public class ApplicationDbContext:DbContext
    {
      
        public DbSet<Customer> Customers { get; set; }

    }
}
