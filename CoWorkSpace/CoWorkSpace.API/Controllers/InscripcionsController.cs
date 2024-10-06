
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/inscripcions")]
    public class InscripcionsController : ControllerBase
    {
        private readonly DataContext _context;
        public InscripcionsController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Inscripcions.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var inscripcion = await _context.Inscripcions.FirstOrDefaultAsync(x => x.Id == id);
            if (inscripcion == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(inscripcion);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Inscripcion inscripcion)
        {
            _context.Add(inscripcion);
            await _context.SaveChangesAsync();

            return Ok(inscripcion);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Inscripcion inscripcion)
        {

            _context.Update(inscripcion);
            await _context.SaveChangesAsync();

            return Ok(inscripcion);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Inscripcions
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
