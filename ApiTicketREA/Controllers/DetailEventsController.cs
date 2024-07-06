using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiTicketREA.Data;
using ApiTicketREA.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTick.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailEventsController : ControllerBase
    {
        private readonly ApiTicketREAContext _context;

        public DetailEventsController(ApiTicketREAContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetailEvent>>> GetDetailEvents()
        {
            return await _context.DetailEvents.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetailEvent>> GetDetailEvent(int id)
        {
            var detailEvent = await _context.DetailEvents.FindAsync(id);

            if (detailEvent == null)
            {
                return NotFound();
            }

            return detailEvent;
        }

        [HttpPost]
        public async Task<ActionResult<DetailEvent>> PostDetailEvent(DetailEvent detailEvent)
        {
            _context.DetailEvents.Add(detailEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetailEvent", new { id = detailEvent.Id }, detailEvent);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutDetailEvent(int id, DetailEvent detailEvent)
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

