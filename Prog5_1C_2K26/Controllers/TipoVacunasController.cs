using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prog5_1C_2K26.Models;
using Prog5_1C_2K26.Data;

namespace Prog5_1C_2K26.Controllers
{
    public class TipoVacunasController : Controller
    {
        private readonly AppDbContext _context;

        public TipoVacunasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: TipoVacunas
        public async Task<IActionResult> Index()
        {
            return View("~/Views/TiposVacuna/Index.cshtml",
                await _context.TipoVacuna.ToListAsync());
        }

        // GET: TipoVacunas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var tipoVacuna = await _context.TipoVacuna
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoVacuna == null) return NotFound();

            return View("~/Views/TiposVacuna/Details.cshtml", tipoVacuna);
        }

        // GET: TipoVacunas/Create
        public IActionResult Create()
        {
            return View("~/Views/TiposVacuna/Create.cshtml");
        }

        // POST: TipoVacunas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descripcion,codigo")] TipoVacuna tipoVacuna)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoVacuna);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/TiposVacuna/Create.cshtml", tipoVacuna);
        }

        // GET: TipoVacunas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var tipoVacuna = await _context.TipoVacuna.FindAsync(id);
            if (tipoVacuna == null) return NotFound();

            return View("~/Views/TiposVacuna/Edit.cshtml", tipoVacuna);
        }

        // POST: TipoVacunas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descripcion,codigo")] TipoVacuna tipoVacuna)
        {
            if (id != tipoVacuna.id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoVacuna);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoVacunaExists(tipoVacuna.id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View("~/Views/TiposVacuna/Edit.cshtml", tipoVacuna);
        }

        // GET: TipoVacunas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var tipoVacuna = await _context.TipoVacuna
                .FirstOrDefaultAsync(m => m.id == id);
            if (tipoVacuna == null) return NotFound();

            return View("~/Views/TiposVacuna/Delete.cshtml", tipoVacuna);
        }

        // POST: TipoVacunas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoVacuna = await _context.TipoVacuna.FindAsync(id);
            if (tipoVacuna != null)
                _context.TipoVacuna.Remove(tipoVacuna);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoVacunaExists(int id)
        {
            return _context.TipoVacuna.Any(e => e.id == id);
        }
    }
}