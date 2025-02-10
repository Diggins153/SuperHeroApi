using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroApi.Data;
using SuperHeroApi.Models;

namespace SuperHeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillainsController : ControllerBase
    {
        private readonly DataContext _context;

        public VillainsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Villains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Villain>>> GetVillain()
        {
            return await _context.Villain.ToListAsync();
        }

        // GET: api/Villains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Villain>> GetVillain(int id)
        {
            var villain = await _context.Villain.FindAsync(id);

            if (villain == null)
            {
                return NotFound();
            }

            return villain;
        }

        // PUT: api/Villains/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVillain(int id, Villain villain)
        {
            if (id != villain.id)
            {
                return BadRequest();
            }

            _context.Entry(villain).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VillainExists(id))
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

        // POST: api/Villains
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Villain>> PostVillain(Villain villain)
        {
            _context.Villain.Add(villain);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVillain", new { id = villain.id }, villain);
        }

        // DELETE: api/Villains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVillain(int id)
        {
            var villain = await _context.Villain.FindAsync(id);
            if (villain == null)
            {
                return NotFound();
            }

            _context.Villain.Remove(villain);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VillainExists(int id)
        {
            return _context.Villain.Any(e => e.id == id);
        }
    }
}
