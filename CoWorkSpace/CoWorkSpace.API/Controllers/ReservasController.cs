
using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoWork.API.Controllers
{
    [ApiController]
    [Route("/api/reservas")]
    public class ReservasController : ControllerBase
    {
        private readonly DataContext _context;
        public ReservasController(DataContext context)
        {
            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Reservas.ToListAsync());

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {

            var reservas = await _context.Reservas.FirstOrDefaultAsync(x => x.Id == id);
            if (reservas == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(reservas);

            }
        }

        [HttpPost]

        public async Task<ActionResult> Post(Reserva reserva)
        {
            _context.Add(reserva);
            await _context.SaveChangesAsync();

            return Ok(reserva);
        }

        [HttpPut]

        public async Task<ActionResult> Put(Reserva reserva)
        {

            _context.Update(reserva);
            await _context.SaveChangesAsync();

            return Ok(reserva);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Reservas
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
