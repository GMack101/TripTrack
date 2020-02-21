using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrack.Models
{
    public class DestinationData
    {
        static private List<Destination> destinations = new List<Destination>();
    
        // GetAll  
        public static List<Destination> GetAll() 
        {
            return destinations;
        }
        
        // Add
        public static void Add(Destination newDestination)
        {
            destinations.Add(newDestination);
        }

        // Remove
        public static void Remove(int id)
        {
            Destination destinationToRemove = GetById(id);
            destinations.Remove(destinationToRemove);
        }

        // GetById 
        public static Destination GetById(int id)
        {
            return destinations.Single(X => X.DestinationId == id);
        }
    }
}
