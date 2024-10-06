using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pratik_Survivor.Context;
using Pratik_Survivor.Entities;

namespace Pratik_Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET: api/competitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CompetitorsEntity>>> GetAll()
        {
            var competitors = await _context.Competitors
                                .Where(c => !c.IsDeleted)  
                                .ToListAsync();
            return Ok(competitors);
        }

        // GET: api/competitors/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CompetitorsEntity>> GetById(int id)
        {
            var competitor = await _context.Competitors
                                .Where(c => c.Id == id && !c.IsDeleted)  
                                .FirstOrDefaultAsync();

            if (competitor == null)
            {
                return NotFound();
            }

            return Ok(competitor);
        }

        // GET: api/competitors/categories/{CategoryId}
        [HttpGet("categories/{CategoryId}")]
        public async Task<ActionResult<IEnumerable<CompetitorsEntity>>> GetByCategoryId(int CategoryId)
        {
            var competitors = await _context.Competitors
                                .Where(c => c.CategoryId == CategoryId && !c.IsDeleted)  
                                .ToListAsync();

            if (competitors == null || !competitors.Any())
            {
                return NotFound();
            }

            return Ok(competitors);
        }

        // POST: api/competitors
        [HttpPost]
        public async Task<ActionResult<CompetitorsEntity>> Create(CompetitorsEntity competitor)
        {
            _context.Competitors.Add(competitor);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = competitor.Id }, competitor);
        }

        // PUT: api/competitors/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CompetitorsEntity competitor)
        {
            if (id != competitor.Id)
            {
                return BadRequest();
            }

            _context.Entry(competitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Competitors.Any(e => e.Id == id))
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

        // DELETE: api/competitors/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var competitor = await _context.Competitors.FindAsync(id);
            if (competitor == null || competitor.IsDeleted)
            {
                return NotFound();
            }

            competitor.IsDeleted = true;  
            competitor.ModifiedDate = DateTime.Now;  

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
