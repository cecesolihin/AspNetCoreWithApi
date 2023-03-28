using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderApps.Data
{
    public class ApplicationDbContext: DbContext
    {
        //(DbContextOptions options): base(options) {}
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }
    }
}
