using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRetful.Data;
using ApiRetful.Modelo;

namespace ApiRetful.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcajesController : ControllerBase
    {
        private readonly ApiRetfulContext _context;

        public MarcajesController(ApiRetfulContext context)
        {
            _context = context;
        }

        // GET: api/Marcajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Marcaje>>> GetMarcaje()
        {
            return await _context.Marcaje.ToListAsync();
        }

        // GET: api/Marcajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Marcaje>> GetMarcaje(int id)
        {
            var marcaje = await _context.Marcaje.FindAsync(id);

            if (marcaje == null)
            {
                return NotFound();
            }

            return marcaje;
        }

        // PUT: api/Marcajes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcaje(int id, Marcaje marcaje)
        {
            if (id != marcaje.EmployeeID)
            {
                return BadRequest();
            }

            _context.Entry(marcaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcajeExists(id))
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

        // POST: api/Marcajes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Marcaje>> PostMarcaje(Marcaje marcaje)
        {
            _context.Marcaje.Add(marcaje);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMarcaje", new { id = marcaje.EmployeeID }, marcaje);
        }

        // DELETE: api/Marcajes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Marcaje>> DeleteMarcaje(int id)
        {
            var marcaje = await _context.Marcaje.FindAsync(id);
            if (marcaje == null)
            {
                return NotFound();
            }

            _context.Marcaje.Remove(marcaje);
            await _context.SaveChangesAsync();

            return marcaje;
        }

        private bool MarcajeExists(int id)
        {
            return _context.Marcaje.Any(e => e.EmployeeID == id);
        }
    }
}
