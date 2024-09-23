using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SI_ModelPractice1Solution.Models;

namespace SI_ModelPractice1Solution.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //TODO: Create a new instance of the rental property class
            RentalProperty rentalProperty = new RentalProperty();

            //TODO: Set the properties of the object
            rentalProperty.RentalPropertyID = 1234;
            rentalProperty.RentalPropertyName = "Jester West";
            rentalProperty.MonthlyRent = 1200;
            rentalProperty.LeaseTermInMonths = 12;


            //TODO: Update the return statement to include the object
            return View(rentalProperty);
        }
    }
}

