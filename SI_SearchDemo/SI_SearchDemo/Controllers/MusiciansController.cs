using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SI_SearchDemo.DAL;
using SI_SearchDemo.Models;

namespace SI_Search.Controllers
{
    public class MusiciansController : Controller
    {
        private readonly AppDbContext _context;

        public MusiciansController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Musicians
        public async Task<IActionResult> Index()
        {

            //Populate the view bag with a count of all musicians 
            ViewBag.AllMusicians = _context.Musicians.Count();

            //Populate the view bag with a count of selected musicians
            // this logic technically only makes sense if you add quick search functionality

            ViewBag.SelectedMusicians = _context.Musicians.Count();
            return View(await _context.Musicians.Include(m => m.Instrument).ToListAsync());
        }

        // GET: Musicians/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var musician = await _context.Musicians
                .FirstOrDefaultAsync(m => m.MusicianId == id);
            if (musician == null)
            {
                return NotFound();
            }

            return View(musician);
        }

        
        
    }
}
