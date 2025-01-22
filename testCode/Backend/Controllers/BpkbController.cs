using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Models;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BpkbController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BpkbController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBpkb(TrBpkb bpkb)
        {
            _context.TrBpkbs.Add(bpkb);
            await _context.SaveChangesAsync();
            return Ok(bpkb);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBpkb(string id)
        {
            var bpkb = await _context.TrBpkbs.FindAsync(id);
            if (bpkb == null)
                return NotFound("BPKB not found.");
            return Ok(bpkb);
        }
    }
}
