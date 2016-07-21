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
    public class ComputerCases1Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public ComputerCases1Controller(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: ComputerCases1
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ComputerCases.Include(c => c.Brand).Include(c => c.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ComputerCases1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }

            return View(computerCase);
        }

        // GET: ComputerCases1/Create
        public IActionResult Create()
        {
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "Brand");
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "Employee");
            return View();
        }

        // POST: ComputerCases1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AvarTagNumber,BrandId,CPUFrequency,CPUType,Cost,EmployeeId,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,WLANMAC,Warranty")] ComputerCase computerCase)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computerCase);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "Brand", computerCase.BrandId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "Employee", computerCase.EmployeeId);
            return View(computerCase);
        }

        // GET: ComputerCases1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "Brand", computerCase.BrandId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "Employee", computerCase.EmployeeId);
            return View(computerCase);
        }

        // POST: ComputerCases1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AvarTagNumber,BrandId,CPUFrequency,CPUType,Cost,EmployeeId,HDDSize,LANMAC,LaptopScreenSize,MachineName,MemorySize,ModelNo,ModelSeries,Note,OEMLicense,OEMOperatingSystem,OfficeLocation,OrderNo,PurchaseDate,Retired,SerialNumber,UpgradeLicense,UpgradedTo,WLANMAC,Warranty")] ComputerCase computerCase)
        {
            if (id != computerCase.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computerCase);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputerCaseExists(computerCase.ID))
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
            ViewData["BrandId"] = new SelectList(_context.Brands, "BrandId", "Brand", computerCase.BrandId);
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "EmployeeID", "Employee", computerCase.EmployeeId);
            return View(computerCase);
        }

        // GET: ComputerCases1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            if (computerCase == null)
            {
                return NotFound();
            }

            return View(computerCase);
        }

        // POST: ComputerCases1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computerCase = await _context.ComputerCases.SingleOrDefaultAsync(m => m.ID == id);
            _context.ComputerCases.Remove(computerCase);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ComputerCaseExists(int id)
        {
            return _context.ComputerCases.Any(e => e.ID == id);
        }
    }
}
