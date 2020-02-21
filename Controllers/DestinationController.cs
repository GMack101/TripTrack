
using Microsoft.AspNetCore.Mvc;  
using System.Collections.Generic;
using TripTrack.Models;
using TripTrack.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripTrack.Controllers
{
    public class DestinationController : Controller

    {
        
                // GET: /<controller>/
        public IActionResult Index()
        {


            List<Destination> destinations = DestinationData.GetAll();

            return View(destinations);
        }

        public IActionResult Add()
        {
            AddDestinationViewModel addDestinationViewModel = new AddDestinationViewModel();


            return View(addDestinationViewModel);
        }

        [HttpPost]
        
        public IActionResult Add(AddDestinationViewModel addDestinationViewModel)
        {

            if (ModelState.IsValid)
            {
                //Add the new destination to my existing destinations
                Destination newDestination = new Destination
                {
                    Trip = addDestinationViewModel.Trip,
                    Date = addDestinationViewModel.Date,
                    Location = addDestinationViewModel.Location,
                    Airline = addDestinationViewModel.Airline,
                    Hotel = addDestinationViewModel.Hotel,
                    RentaCar= addDestinationViewModel.RentaCar,
                    Code = addDestinationViewModel.Code


                };
               
                DestinationData.Add(newDestination);

                return Redirect("/Destination");
            }
            return View(addDestinationViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Destinations";
            ViewBag.destinations = DestinationData.GetAll();
            return View();
        }


        [HttpPost]
        public IActionResult Remove(int[] destinationIds)
        {
            //TODO - remove destinations from list
            foreach (int destinationId in destinationIds)
            {
                DestinationData.Remove(destinationId);
            }
            return Redirect("/");
        }


    }
} 
    