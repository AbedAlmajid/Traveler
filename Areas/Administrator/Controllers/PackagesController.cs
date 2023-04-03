using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoTraveler.Data;
using DemoTraveler.Models;

namespace DemoTraveler.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class PackagesController : Controller
    {
        private readonly AppDbContext _context;

        public PackagesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/Packages
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Packages.Include(p => p.Country);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Administrator/Packages/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .Include(p => p.Country)
                .FirstOrDefaultAsync(m => m.PackageId == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // GET: Administrator/Packages/Create
        public IActionResult Create()
        {
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryName");
            return View();
        }

        // POST: Administrator/Packages/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PackageId,CountryName,Duration,Person,CountryDesc,Prize,HotelStars,CountryImg,DepartDate,ReturnDate,CountryId,IsDeleted,IsActive,CreationDate,ModificationDate")] Package package)
        {
            if (ModelState.IsValid)
            {
                package.PackageId = Guid.NewGuid();
                _context.Add(package);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryName", package.CountryId);
            return View(package);
        }

        // GET: Administrator/Packages/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages.FindAsync(id);
            if (package == null)
            {
                return NotFound();
            }
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryName", package.CountryId);
            return View(package);
        }

        // POST: Administrator/Packages/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PackageId,CountryName,Duration,Person,CountryDesc,Prize,HotelStars,CountryImg,DepartDate,ReturnDate,CountryId,IsDeleted,IsActive,CreationDate,ModificationDate")] Package package)
        {
            if (id != package.PackageId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(package);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackageExists(package.PackageId))
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
            ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryName", package.CountryId);
            return View(package);
        }

        // GET: Administrator/Packages/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var package = await _context.Packages
                .Include(p => p.Country)
                .FirstOrDefaultAsync(m => m.PackageId == id);
            if (package == null)
            {
                return NotFound();
            }

            return View(package);
        }

        // POST: Administrator/Packages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var package = await _context.Packages.FindAsync(id);
            _context.Packages.Remove(package);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackageExists(Guid id)
        {
            return _context.Packages.Any(e => e.PackageId == id);
        }
    }
}
