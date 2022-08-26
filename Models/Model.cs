using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC_Day07.Models
{
    public class Model:DbContext
    {
        public Model(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<employee> emps { get; set; }
        public DbSet<Department> depts { get; set; }

    }
}
