using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proyecto4programacion.Data;
using proyecto4programacion.Entities;

namespace proyecto4programacion.Controllers
{
    public class RecordatoriosController : Controller
    {
        private readonly PrometeoContext _context;

        public RecordatoriosController(PrometeoContext context)
        {
            _context = context;
        }

        // GET: Recordatorios
        public async Task<IActionResult> Index()
        {
            return View(await _context.recordatorios.ToListAsync());
        }

        // GET: Recordatorios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recordatorio = await _context.recordatorios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recordatorio == null)
            {
                return NotFound();
            }

            return View(recordatorio);
        }

        // GET: Recordatorios/Create
        public async Task<IActionResult> Create()
        {
            var recordatorios = await _context.recordatorios.ToListAsync();
            ViewBag.recordatorios = new SelectList(recordatorios, "Id", "Titulo");
            return View();
        }

        // POST: Recordatorios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,titulo,fechaRecordatorio,hora")] Recordatorio recordatorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(recordatorio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(recordatorio);
        }

        // GET: Recordatorios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recordatorio = await _context.recordatorios.FindAsync(id);
            if (recordatorio == null)
            {
                return NotFound();
            }
            return View(recordatorio);
        }

        // POST: Recordatorios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,titulo,fechaRecordatorio,hora")] Recordatorio recordatorio)
        {
            if (id != recordatorio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(recordatorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecordatorioExists(recordatorio.Id))
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
            return View(recordatorio);
        }

        // GET: Recordatorios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var recordatorio = await _context.recordatorios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (recordatorio == null)
            {
                return NotFound();
            }

            return View(recordatorio);
        }

        // POST: Recordatorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var recordatorio = await _context.recordatorios.FindAsync(id);
            if (recordatorio != null)
            {
                _context.recordatorios.Remove(recordatorio);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RecordatorioExists(int id)
        {
            return _context.recordatorios.Any(e => e.Id == id);
        }
    }
}
