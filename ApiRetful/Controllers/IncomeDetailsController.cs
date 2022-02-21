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
    public class IncomeDetailsController : ControllerBase
    {
        private readonly ApiRetfulContext _context;

        public IncomeDetailsController(ApiRetfulContext context)
        {
            _context = context;
        }

        // GET: api/IncomeDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IncomeDetail>>> GetIncomeDetail()
        {
            return await _context.IncomeDetail.ToListAsync();
        }

        // GET: api/IncomeDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IncomeDetail>> GetIncomeDetail(int id)
        {
            var incomeDetail = await _context.IncomeDetail.FindAsync(id);

            if (incomeDetail == null)
            {
                return NotFound();
            }

            return incomeDetail;
        }

        // PUT: api/IncomeDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutIncomeDetail(int id, IncomeDetail incomeDetail)
        {
            if (id != incomeDetail.idincome_detail)
            {
                return BadRequest();
            }

            _context.Entry(incomeDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncomeDetailExists(id))
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

        // POST: api/IncomeDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<IncomeDetail>> PostIncomeDetail(IncomeDetail incomeDetail)
        {
            _context.IncomeDetail.Add(incomeDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetIncomeDetail", new { id = incomeDetail.idincome_detail }, incomeDetail);
        }

        // DELETE: api/IncomeDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<IncomeDetail>> DeleteIncomeDetail(int id)
        {
            var incomeDetail = await _context.IncomeDetail.FindAsync(id);
            if (incomeDetail == null)
            {
                return NotFound();
            }

            _context.IncomeDetail.Remove(incomeDetail);
            await _context.SaveChangesAsync();

            return incomeDetail;
        }

        private bool IncomeDetailExists(int id)
        {
            return _context.IncomeDetail.Any(e => e.idincome_detail == id);
        }
    }
}
