using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrack.Models
{
    public class CodeCategory
    {
        public int ID { get; set;  }
        public string Name { get; set;  }

        public IList<Destination> Codes { get; set; }
    }
}
  