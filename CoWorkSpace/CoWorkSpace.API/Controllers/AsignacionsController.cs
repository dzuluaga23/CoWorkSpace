using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/asignacions")]
    public class AsignacionsController : ControllerBase
    {
        private readonly DataContext _context;
        public AsignacionsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Asignacions.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var asignacion = await _context.Asignacions.FirstOrDefaultAsync(x => x.Id == id);
            if (asignacion == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(asignacion);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Asignacion asignacion)
        {
            _context.Add(asignacion);
            await _context.SaveChangesAsync();

            return Ok(asignacion);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Asignacion asignacion)
        {

            _context.Update(asignacion);
            await _context.SaveChangesAsync();

            return Ok(asignacion);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Asignacions
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
