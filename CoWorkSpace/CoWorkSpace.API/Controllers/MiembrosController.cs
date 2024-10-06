
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/miembros")]
    public class MiembrosController : ControllerBase
    {
        private readonly DataContext _context;
        public MiembrosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Miembros.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var miembro = await _context.Miembros.FirstOrDefaultAsync(x => x.Id == id);
            if (miembro == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(miembro);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Miembro miembro)
        {
            _context.Add(miembro);
            await _context.SaveChangesAsync();

            return Ok(miembro);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Miembro miembro)
        {

            _context.Update(miembro);
            await _context.SaveChangesAsync();

            return Ok(miembro);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Miembros
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

