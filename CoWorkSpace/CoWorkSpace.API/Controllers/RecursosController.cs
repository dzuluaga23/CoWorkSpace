
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{

    [ApiController]
    [Route("/api/recursos")]
    public class RecursosController : ControllerBase
    {
        private readonly DataContext _context;
        public RecursosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Recursos.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var recurso = await _context.Recursos.FirstOrDefaultAsync(x => x.Id == id);
            if (recurso == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(recurso);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Recurso recurso)
        {
            _context.Add(recurso);
            await _context.SaveChangesAsync();

            return Ok(recurso);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Recurso recurso)
        {

            _context.Update(recurso);
            await _context.SaveChangesAsync();

            return Ok(recurso);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Recursos
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
