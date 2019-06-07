using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class CarsDB : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}
