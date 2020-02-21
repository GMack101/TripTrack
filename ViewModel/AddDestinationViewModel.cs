using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripTrack.ViewModel
{
    public class AddDestinationViewModel
    {
        [Required]
        [Display(Name = "Trip Number")]       
        public int Trip { get; set; }

        [Display(Name = "Date")]
        public string Date { get; set; }


        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Airline")]
        public string Airline { get; set; }

        [Display(Name = "Hotel")]
        public string Hotel { get; set; }

        [Display(Name = "RentaCar")]
        public string RentaCar { get; set; }

<<<<<<< HEAD
        [Display(Name = "Code")]
        public string Code { get; set; }

=======
>>>>>>> master





    }
}
