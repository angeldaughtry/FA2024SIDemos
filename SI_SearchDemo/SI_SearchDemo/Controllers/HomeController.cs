using System;
using Microsoft.AspNetCore.Mvc;
using SI_SerchDemo.DAL;
using SI_SearchDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; //for selectlist
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SI_SearchDemo.Controllers
{
	public class HomeController : Controller
	{
        public IActionResult Index ()
        {
            return View();
        }

    }
}

