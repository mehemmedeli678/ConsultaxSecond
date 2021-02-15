using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Consultaxsecond.Data;
using Consultaxsecond.Models;

namespace Consultaxsecond.Areas.K207Admin.Controllers
{
    [Area("K207Admin")]
    public class Section2Controller : Controller
    {
        private readonly ConsultaxSecondDB _context;

        public Section2Controller(ConsultaxSecondDB context)
        {
            _context = context;
        }

        // GET: K207Admin/Section2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Section2.ToListAsync());
        }

        // GET: K207Admin/Section2/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section2 = await _context.Section2
                .FirstOrDefaultAsync(m => m.ID == id);
            if (section2 == null)
            {
                return NotFound();
            }

            return View(section2);
        }

        // GET: K207Admin/Section2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: K207Admin/Section2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Header,description,Icon")] Section2 section2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(section2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(section2);
        }

        // GET: K207Admin/Section2/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section2 = await _context.Section2.FindAsync(id);
            if (section2 == null)
            {
                return NotFound();
            }
            return View(section2);
        }

        // POST: K207Admin/Section2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Header,description,Icon")] Section2 section2)
        {
            if (id != section2.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(section2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Section2Exists(section2.ID))
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
            return View(section2);
        }

        // GET: K207Admin/Section2/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var section2 = await _context.Section2
                .FirstOrDefaultAsync(m => m.ID == id);
            if (section2 == null)
            {
                return NotFound();
            }

            return View(section2);
        }

        // POST: K207Admin/Section2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var section2 = await _context.Section2.FindAsync(id);
            _context.Section2.Remove(section2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Section2Exists(int id)
        {
            return _context.Section2.Any(e => e.ID == id);
        }
    }
}
