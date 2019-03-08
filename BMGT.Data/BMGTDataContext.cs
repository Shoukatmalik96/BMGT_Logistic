using BMGT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGT.Data
{
    public class BMGTDataContext:DbContext
    {
        public BMGTDataContext():base("name=BMGTConnection")
        {

        }

        public DbSet<Trip> MyProperty { get; set; }
    }
}
