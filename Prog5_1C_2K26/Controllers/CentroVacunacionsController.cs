using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prog5_1C_2K26.Models;
using Prog5_1C_2K26.Data;

namespace Prog5_1C_2K26.Controllers
{
    public class CentroVacunacionsController : Controller
    {
        private readonly AppDbContext _context;

        public CentroVacunacionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CentroVacunacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.CentrosVacunacion.ToListAsync());
        }

        // GET: CentroVacunacions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centroVacunacion = await _context.CentrosVacunacion
                .FirstOrDefaultAsync(m => m.id == id);
            if (centroVacunacion == null)
            {
                return NotFound();
            }

            return View(centroVacunacion);
        }

        // GET: CentroVacunacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CentroVacunacions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,descripcion,ProvincialId")] CentroVacunacion centroVacunacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(centroVacunacion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(centroVacunacion);
        }

        // GET: CentroVacunacions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centroVacunacion = await _context.CentrosVacunacion.FindAsync(id);
            if (centroVacunacion == null)
            {
                return NotFound();
            }
            return View(centroVacunacion);
        }

        // POST: CentroVacunacions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,descripcion,ProvincialId")] CentroVacunacion centroVacunacion)
        {
            if (id != centroVacunacion.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(centroVacunacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CentroVacunacionExists(centroVacunacion.id))
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
            return View(centroVacunacion);
        }

        // GET: CentroVacunacions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var centroVacunacion = await _context.CentrosVacunacion
                .FirstOrDefaultAsync(m => m.id == id);
            if (centroVacunacion == null)
            {
                return NotFound();
            }

            return View(centroVacunacion);
        }

        // POST: CentroVacunacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var centroVacunacion = await _context.CentrosVacunacion.FindAsync(id);
            if (centroVacunacion != null)
            {
                _context.CentrosVacunacion.Remove(centroVacunacion);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CentroVacunacionExists(int id)
        {
            return _context.CentrosVacunacion.Any(e => e.id == id);
        }
    }
}
