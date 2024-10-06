
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/espacios")]
    public class EspaciosController : ControllerBase
    {
        private readonly DataContext _context;
        public EspaciosController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Espacios.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var espacio = await _context.Espacios.FirstOrDefaultAsync(x => x.Id == id);
            if (espacio == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(espacio);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Espacio espacio)
        {
            _context.Add(espacio);
            await _context.SaveChangesAsync();

            return Ok(espacio);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Espacio espacio)
        {

            _context.Update(espacio);
            await _context.SaveChangesAsync();

            return Ok(espacio);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Espacios
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
