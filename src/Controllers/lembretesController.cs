using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kippa.Data;
using Kippa.Models;

namespace Kippa.Controllers
{
    public class lembretesController : Controller
    {
        private readonly KippaContext _context;

        public lembretesController(KippaContext context)
        {
            _context = context;
        }

        // GET: lembretes
        public async Task<IActionResult> Index()
        {
            return View(await _context.lembrete.ToListAsync());
        }

        // GET: lembretes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.lembrete
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (lembrete == null)
            {
                return NotFound();
            }

            return View(lembrete);
        }

        // GET: lembretes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: lembretes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Codigo,Nome,Lembrete,Email")] lembrete lembrete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lembrete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lembrete);
        }

        // GET: lembretes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.lembrete.FindAsync(id);
            if (lembrete == null)
            {
                return NotFound();
            }
            return View(lembrete);
        }

        // POST: lembretes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Codigo,Nome,Lembrete,Email")] lembrete lembrete)
        {
            if (id != lembrete.Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lembrete);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!lembreteExists(lembrete.Codigo))
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
            return View(lembrete);
        }

        // GET: lembretes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.lembrete
                .FirstOrDefaultAsync(m => m.Codigo == id);
            if (lembrete == null)
            {
                return NotFound();
            }

            return View(lembrete);
        }

        // POST: lembretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lembrete = await _context.lembrete.FindAsync(id);
            if (lembrete != null)
            {
                _context.lembrete.Remove(lembrete);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool lembreteExists(int id)
        {
            return _context.lembrete.Any(e => e.Codigo == id);
        }
    }
}
