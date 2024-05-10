using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kippa.Models;

namespace Kippa.Controllers
{
    public class LembretesController : Controller
    {
        private readonly KippaContext _context;

        public LembretesController(KippaContext context)
        {
            _context = context;
        }

        // GET: Lembretes
        public async Task<IActionResult> Index()
        {
            var kippaContext = _context.Lembretes.Include(l => l.Usuario);
            return View(await kippaContext.ToListAsync());
        }

        // GET: Lembretes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.Lembretes
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.IdLembrete == id);
            if (lembrete == null)
            {
                return NotFound();
            }

            return View(lembrete);
        }

        // GET: Lembretes/Create
        public IActionResult Create()
        {
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Lembretes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdLembrete,UsuarioId,NomeLembrete,DataLembrete,HoraLembrete,Notificacoes")] Lembrete lembrete)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lembrete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", lembrete.UsuarioId);
            return View(lembrete);
        }

        // GET: Lembretes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.Lembretes.FindAsync(id);
            if (lembrete == null)
            {
                return NotFound();
            }
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", lembrete.UsuarioId);
            return View(lembrete);
        }

        // POST: Lembretes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdLembrete,UsuarioId,NomeLembrete,DataLembrete,HoraLembrete,Notificacoes")] Lembrete lembrete)
        {
            if (id != lembrete.IdLembrete)
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
                    if (!LembreteExists(lembrete.IdLembrete))
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
            ViewData["UsuarioId"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", lembrete.UsuarioId);
            return View(lembrete);
        }

        // GET: Lembretes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.Lembretes
                .Include(l => l.Usuario)
                .FirstOrDefaultAsync(m => m.IdLembrete == id);
            if (lembrete == null)
            {
                return NotFound();
            }

            return View(lembrete);
        }

        // POST: Lembretes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lembrete = await _context.Lembretes.FindAsync(id);
            if (lembrete != null)
            {
                _context.Lembretes.Remove(lembrete);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LembreteExists(int id)
        {
            return _context.Lembretes.Any(e => e.IdLembrete == id);
        }
    }
}
