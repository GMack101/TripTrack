using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrack.Models
{
    public class Destination
    {
        public int Trip { get; set; }
        public string Date { get; set; }
        public string Location { get; set; }


        public string Airline { get; set; }
        public string Hotel { get; set; }
        public string RentaCar {get; set; }


        public int DestinationId { get; set; }
        private static int nextId = 1;

        public Destination()
        {
            DestinationId = nextId;
            nextId++;
        }
        
        //public Destination() { } 
        
        public int DestinationID { get; set; }
        //public CodeCategory CodeCategory { get; set; }
    }
}
