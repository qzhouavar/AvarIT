using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvarIT.Data;
using AvarIT.Models.InventoryModels;

namespace AvarIT.Controllers
{
    public class OfficeLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OfficeLocationsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OfficeLocations
        public async Task<IActionResult> Index()
        {
            return View(await _context.OfficeLocations.ToListAsync());
        }

        // GET: OfficeLocations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLocation = await _context.OfficeLocations.SingleOrDefaultAsync(m => m.Id == id);
            if (officeLocation == null)
            {
                return NotFound();
            }

            return View(officeLocation);
        }

        // GET: OfficeLocations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OfficeLocations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] OfficeLocation officeLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(officeLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(officeLocation);
        }

        // GET: OfficeLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLocation = await _context.OfficeLocations.SingleOrDefaultAsync(m => m.Id == id);
            if (officeLocation == null)
            {
                return NotFound();
            }
            return View(officeLocation);
        }

        // POST: OfficeLocations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] OfficeLocation officeLocation)
        {
            if (id != officeLocation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(officeLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OfficeLocationExists(officeLocation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(officeLocation);
        }

        // GET: OfficeLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var officeLocation = await _context.OfficeLocations.SingleOrDefaultAsync(m => m.Id == id);
            if (officeLocation == null)
            {
                return NotFound();
            }

            return View(officeLocation);
        }

        // POST: OfficeLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var officeLocation = await _context.OfficeLocations.SingleOrDefaultAsync(m => m.Id == id);
            _context.OfficeLocations.Remove(officeLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OfficeLocationExists(int id)
        {
            return _context.OfficeLocations.Any(e => e.Id == id);
        }
    }
}
