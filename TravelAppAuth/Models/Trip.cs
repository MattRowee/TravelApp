using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelAppAuth.Models
{
    public class Trip
    {
        //A travel agent can create a trip for a client. 
        //The trip should have a start date, end date, and location.
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }

    }
}
