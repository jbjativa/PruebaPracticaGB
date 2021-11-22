using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaPracticaGB.Models;

namespace PruebaPracticaGB.Controllers
{
    public class EmployeePayHistoriesController : Controller
    {
        private readonly AdventureWorksContext _context;

        public EmployeePayHistoriesController(AdventureWorksContext context)
        {
            _context = context;
        }

        // GET: EmployeePayHistories
        public async Task<IActionResult> Index()
        {
            var adventureWorksContext = _context.EmployeePayHistory.Include(e => e.BusinessEntity);
            return View(await adventureWorksContext.ToListAsync());
        }

        // GET: EmployeePayHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayHistory = await _context.EmployeePayHistory
                .Include(e => e.BusinessEntity)
                .FirstOrDefaultAsync(m => m.BusinessEntityId == id);
            if (employeePayHistory == null)
            {
                return NotFound();
            }

            return View(employeePayHistory);
        }

        // GET: EmployeePayHistories/Create
        public IActionResult Create()
        {
            ViewData["BusinessEntityId"] = new SelectList(_context.Employee, "BusinessEntityId", "Gender");
            return View();
        }

        // POST: EmployeePayHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BusinessEntityId,RateChangeDate,Rate,PayFrequency,ModifiedDate")] EmployeePayHistory employeePayHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeePayHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BusinessEntityId"] = new SelectList(_context.Employee, "BusinessEntityId", "Gender", employeePayHistory.BusinessEntityId);
            return View(employeePayHistory);
        }

        // GET: EmployeePayHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayHistory = await _context.EmployeePayHistory.FindAsync(id);
            if (employeePayHistory == null)
            {
                return NotFound();
            }
            ViewData["BusinessEntityId"] = new SelectList(_context.Employee, "BusinessEntityId", "Gender", employeePayHistory.BusinessEntityId);
            return View(employeePayHistory);
        }

        // POST: EmployeePayHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BusinessEntityId,RateChangeDate,Rate,PayFrequency,ModifiedDate")] EmployeePayHistory employeePayHistory)
        {
            if (id != employeePayHistory.BusinessEntityId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeePayHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeePayHistoryExists(employeePayHistory.BusinessEntityId))
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
            ViewData["BusinessEntityId"] = new SelectList(_context.Employee, "BusinessEntityId", "Gender", employeePayHistory.BusinessEntityId);
            return View(employeePayHistory);
        }

        // GET: EmployeePayHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeePayHistory = await _context.EmployeePayHistory
                .Include(e => e.BusinessEntity)
                .FirstOrDefaultAsync(m => m.BusinessEntityId == id);
            if (employeePayHistory == null)
            {
                return NotFound();
            }

            return View(employeePayHistory);
        }

        // POST: EmployeePayHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeePayHistory = await _context.EmployeePayHistory.FindAsync(id);
            _context.EmployeePayHistory.Remove(employeePayHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeePayHistoryExists(int id)
        {
            return _context.EmployeePayHistory.Any(e => e.BusinessEntityId == id);
        }
    }
}
