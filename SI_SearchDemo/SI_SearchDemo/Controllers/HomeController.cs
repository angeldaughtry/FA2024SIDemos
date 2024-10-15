using System;
using Microsoft.AspNetCore.Mvc;
using SI_SearchDemo.DAL;
using SI_SearchDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering; //for selectlist

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

