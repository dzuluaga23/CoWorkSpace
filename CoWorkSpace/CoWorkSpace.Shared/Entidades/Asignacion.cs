using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Asignacion
    {
        public int Id { get; set; }

        [JsonIgnore]
        public Recurso Recursos { get; set; }
        public int RecursoId { get; set; }

        [JsonIgnore]
        public Espacio Espacio { get; set; }
        public int EspacioId { get; set; }
    }
}
