using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoveAlgorithm.Data;
using LoveAlgorithm.Models;

namespace LoveAlgorithm.Controllers
{
    public class RecenzijeController : Controller
    {
        private readonly LoveAlgorithmContext _context;

        public RecenzijeController(LoveAlgorithmContext context)
        {
            _context = context;
        }

        // GET: Recenzije
        public async Task<IActionResult> Index()
        {
            return View(await _context.Recenzije.ToListAsync());
        }

        // GET: Recenzije/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije
                .FirstOrDefaultAsync(m => m.ID == id);
            if (recenzije == null)
            {
                return NotFound();
            }

            return View(recenzije);
        }

        // GET: Recenzije/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Recenzije/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Komentar,Ocjena")] Recenzije recenzije)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recenzije);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recenzije);
        }

        // GET: Recenzije/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije.FindAsync(id);
            if (recenzije == null)
            {
                return NotFound();
            }
            return View(recenzije);
        }

        // POST: Recenzije/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Komentar,Ocjena")] Recenzije recenzije)
        {
            if (id != recenzije.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recenzije);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecenzijeExists(recenzije.ID))
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
            return View(recenzije);
        }

        // GET: Recenzije/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recenzije = await _context.Recenzije
                .FirstOrDefaultAsync(m => m.ID == id);
            if (recenzije == null)
            {
                return NotFound();
            }

            return View(recenzije);
        }

        // POST: Recenzije/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recenzije = await _context.Recenzije.FindAsync(id);
            _context.Recenzije.Remove(recenzije);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecenzijeExists(int id)
        {
            return _context.Recenzije.Any(e => e.ID == id);
        }
    }
}
