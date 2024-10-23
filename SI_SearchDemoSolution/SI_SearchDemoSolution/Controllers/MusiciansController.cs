using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SI_SearchDemoSolution.DAL;
using SI_SearchDemoSolution.Models;

namespace SI_SearchDemoSolution.Controllers
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

        public IActionResult DetailedSearch()
        {
            //populate viebag with list of genres
            ViewBag.AllInstruments = GetAllInstrumentsSelectList();

            //set default properties
            MusicianSearchViewModel svm = new MusicianSearchViewModel();
            svm.SelectedInstrumentId = 0;

            return View(svm);
        }

        public IActionResult DisplaySearchResults(MusicianSearchViewModel svm)
        {
            //set up initial query
            var query = from m in _context.Musicians
                        select m;

            //check Name criteria (textbox)
            if (String.IsNullOrEmpty(svm.SelectedName) == false)
            {
                query = query.Where(m => m.Name.Contains(svm.SelectedName));
            }

            //check Age criteria (numeric input)

            //if they put an age
            if (svm.SelectedAge != null)
            {
                TryValidateModel(svm);
                if (ModelState.IsValid == false)
                {
                    //re-populate ViewBag to have a list of all genres
                    ViewBag.AllGenres = GetAllInstrumentsSelectList();
                    return View("DetailedSearch", svm);
                }

                switch (svm.SelectedAgeRange)
                {
                    case AgeRange.GreaterThan:
                        query = query.Where(m => m.Age >= svm.SelectedAge);
                        break;

                    case AgeRange.LessThan:
                        query = query.Where(m => m.Age <= svm.SelectedAge);
                        break;

                }
            }

            //check Instrument criteria (dropdown)
            if (svm.SelectedInstrumentId != 0)//they picked an insturment
            {
                //Instrument SearchedInstrument = _context.Instruments.Find(svm.SelectedInstrumentID);
                query = query.Where(m => m.Instrument.InstrumentId == svm.SelectedInstrumentId);
            }


            //execute the query
            List<Musician> SelectedMusicians = query.OrderBy(m => m.Name).Include(m => m.Instrument).ToList();

            //Populate the view bag with a count of all musicians 
            ViewBag.AllMusicians = _context.Musicians.Count();

            //Populate the view bag with a count of selected musicians 
            ViewBag.SelectedMusicians = SelectedMusicians.Count;

            return View("Index", SelectedMusicians);

        }

        // HELPER METHOD
        private SelectList GetAllInstrumentsSelectList()
        {
            //get the list of instrument from the database
            List<Instrument> instrumentList = _context.Instruments.ToList();

            //add a dummy entry so the user can select all instruments
            Instrument SelectNone = new Instrument() { InstrumentId = 0, Name = "All Instruments" };
            instrumentList.Add(SelectNone);

            //convert the list to a SelectList by calling SelectList constructor
            SelectList instrumentSelectList = new SelectList(instrumentList.OrderBy(i => i.InstrumentId), "InstrumentId", "Name");

            //return the SelectList
            return instrumentSelectList;

        }


        //CRUD METHODS

        // GET: Musicians/Create
        public IActionResult Create()
            {
                return View();
            }

            // POST: Musicians/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("MusicianId,Name,Age")] Musician musician)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(musician);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(musician);
            }

            // GET: Musicians/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var musician = await _context.Musicians.FindAsync(id);
                if (musician == null)
                {
                    return NotFound();
                }
                return View(musician);
            }

            // POST: Musicians/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("MusicianId,Name,Age")] Musician musician)
            {
                if (id != musician.MusicianId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(musician);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MusicianExists(musician.MusicianId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(musician);
            }

            // GET: Musicians/Delete/5
            public async Task<IActionResult> Delete(int? id)
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

        // POST: Musicians/Delete/5
        [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var musician = await _context.Musicians.FindAsync(id);
                if (musician != null)
                {
                    _context.Musicians.Remove(musician);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool MusicianExists(int id)
            {
                return _context.Musicians.Any(e => e.MusicianId == id);
            }
        }
}
