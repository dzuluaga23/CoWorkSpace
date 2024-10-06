using CoWorkSpace.Shared.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CoWorkSpace.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //Entidades
        public DbSet<Espacio> Espacios { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Inscripcion> Inscripcions { get; set; }
        public DbSet<Membresia> Membresias { get; set; }
        public DbSet<Miembro> Miembros { get; set; }
        public DbSet<Recurso> Recursos { get; set; }
        public DbSet<Asignacion> Asignacions { get; set; }
        public DbSet<Reserva> Reservas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
