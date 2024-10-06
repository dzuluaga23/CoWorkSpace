using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Membresia
    {
        public int Id { get; set; }
        public string Tipo { get; set; } //premium,standar o medium
        public string Descripcion { get; set; } // detallar que contiene cada tipo de membresia

    }
}
