using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTicketREA.Data;
using WebTicketREA.Models;

namespace WebTicketREA.Controllers
{
    public class DetailEventsController : Controller
    {
        private readonly WebTicketREAContext _context;

        public DetailEventsController(WebTicketREAContext context)
        {
            _context = context;
        }

        // GET: DetailEvents
        public async Task<IActionResult> Index()
        {
            return View(await _context.DetailEvents.ToListAsync());
        }

        // GET: DetailEvents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailEvent = await _context.DetailEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detailEvent == null)
            {
                return NotFound();
            }

            return View(detailEvent);
        }

        // GET: DetailEvents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DetailEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EventName,EventImage,EventDate,EventLocation,EventDescription")] DetailEvent detailEvent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detailEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(detailEvent);
        }

        // GET: DetailEvents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailEvent = await _context.DetailEvents.FindAsync(id);
            if (detailEvent == null)
            {
                return NotFound();
            }
            return View(detailEvent);
        }

        // POST: DetailEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EventName,EventImage,EventDate,EventLocation,EventDescription")] DetailEvent detailEvent)
        {
            if (id != detailEvent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detailEvent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetailEventExists(detailEvent.Id))
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
            return View(detailEvent);
        }

        // GET: DetailEvents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detailEvent = await _context.DetailEvents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (detailEvent == null)
            {
                return NotFound();
            }

            return View(detailEvent);
        }

        // POST: DetailEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detailEvent = await _context.DetailEvents.FindAsync(id);
            if (detailEvent != null)
            {
                _context.DetailEvents.Remove(detailEvent);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetailEventExists(int id)
        {
            return _context.DetailEvents.Any(e => e.Id == id);
        }
    }
}
