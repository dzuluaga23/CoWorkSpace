using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Inscripcion
    {
        public int Id { get; set; }

        [JsonIgnore]
        public Evento Eventos { get; set; }
        public int EventoId { get; set; }

        [JsonIgnore]
        public Miembro Miembros { get; set; }
        public int MiembroId { get; set; }
    }
}
