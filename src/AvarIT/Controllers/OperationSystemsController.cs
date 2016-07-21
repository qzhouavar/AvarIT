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
    public class OperationSystemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OperationSystemsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OperationSystems
        public async Task<IActionResult> Index()
        {
            return View(await _context.OperationSystems.ToListAsync());
        }

        // GET: OperationSystems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationSystem = await _context.OperationSystems.SingleOrDefaultAsync(m => m.OSId == id);
            if (operationSystem == null)
            {
                return NotFound();
            }

            return View(operationSystem);
        }

        // GET: OperationSystems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OperationSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OSId,OSName")] OperationSystem operationSystem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(operationSystem);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(operationSystem);
        }

        // GET: OperationSystems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationSystem = await _context.OperationSystems.SingleOrDefaultAsync(m => m.OSId == id);
            if (operationSystem == null)
            {
                return NotFound();
            }
            return View(operationSystem);
        }

        // POST: OperationSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OSId,OSName")] OperationSystem operationSystem)
        {
            if (id != operationSystem.OSId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(operationSystem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperationSystemExists(operationSystem.OSId))
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
            return View(operationSystem);
        }

        // GET: OperationSystems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var operationSystem = await _context.OperationSystems.SingleOrDefaultAsync(m => m.OSId == id);
            if (operationSystem == null)
            {
                return NotFound();
            }

            return View(operationSystem);
        }

        // POST: OperationSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var operationSystem = await _context.OperationSystems.SingleOrDefaultAsync(m => m.OSId == id);
            _context.OperationSystems.Remove(operationSystem);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OperationSystemExists(int id)
        {
            return _context.OperationSystems.Any(e => e.OSId == id);
        }
    }
}
