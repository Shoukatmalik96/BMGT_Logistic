using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMGT.Entities
{
    public class Trip:BaseEntitiy
    {
        public DateTime LoadingDate { get; set; }
        public decimal Fare { get; set; }
        public string FreightDescription { get; set; }
        public int Weight { get; set; }
        public DateTime ReturnLoading { get; set; }
        public decimal RetunFare { get; set; }
        public string Broker { get; set; }

    }
}
