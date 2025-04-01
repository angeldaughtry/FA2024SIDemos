using System;
using Microsoft.AspNetCore.Mvc;
using SI_SearchDemoSolution.DAL;
using SI_SearchDemoSolution.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; //for selectlist
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SI_SearchDemoSolution.Controllers
{
	public class HomeController : Controller
	{
        public IActionResult Index ()
        {
            return View();
        }

    }
}

