using CoWorkSpace.API.Data;
using CoWorkSpace.Shared.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CoWorkSpace.Api.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckMembresiaAsync();
        }

        public async Task CheckMembresiaAsync()
        {
            if (!_context.Membresias.Any())
            {
                _context.Membresias.Add(new Membresia { Tipo = "Premium" });
                _context.Membresias.Add(new Membresia { Tipo = "Estándar" });
            }
            await _context.SaveChangesAsync();
        }
    }
}
