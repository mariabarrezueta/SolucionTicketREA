using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebTicketREA.Data;
using WebTicketREA.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTicketREA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoDetalleController : ControllerBase
    {
        private readonly WebTicketREAContext _context;

        public EventoDetalleController(WebTicketREAContext context)
        {
            _context = context;
        }

        // GET: api/EventoDetalle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventoDetalle>>> GetDetailEvents()
        {
            return await _context.DetailEvents.ToListAsync();
        }

        // GET: api/EventoDetalle/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventoDetalle>> GetDetailEvent(int id)
        {
            var detailEvent = await _context.DetailEvents.FindAsync(id);

            if (detailEvent == null)
            {
                return NotFound();
            }

            return detailEvent;
        }

        // POST: api/EventoDetalle
        [HttpPost]
        public async Task<ActionResult<EventoDetalle>> PostDetailEvent(EventoDetalle detailEvent)
        {
            _context.DetailEvents.Add(detailEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetailEvent", new { id = detailEvent.Id }, detailEvent);
        }

        // PUT: api/EventoDetalle/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetailEvent(int id, EventoDetalle detailEvent)
        {
            if (id != detailEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(detailEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetailEventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/EventoDetalle/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetailEvent(int id)
        {
            var detailEvent = await _context.DetailEvents.FindAsync(id);
            if (detailEvent == null)
            {
                return NotFound();
            }

            _context.DetailEvents.Remove(detailEvent);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetailEventExists(int id)
        {
            return _context.DetailEvents.Any(e => e.Id == id);
        }
    }
}
