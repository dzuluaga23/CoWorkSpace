
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/membresias")]
    public class MembresiasController : ControllerBase
    {

        private readonly DataContext _context;
        public MembresiasController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Membresias.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var membresia = await _context.Membresias.FirstOrDefaultAsync(x => x.Id == id);
            if (membresia == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(membresia);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Membresia  membresia)
        {
            _context.Add(membresia);
            await _context.SaveChangesAsync();

            return Ok(membresia);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Membresia membresia)
        {

            _context.Update(membresia);
            await _context.SaveChangesAsync();

            return Ok(membresia);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Membresias
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {

                return NotFound();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
