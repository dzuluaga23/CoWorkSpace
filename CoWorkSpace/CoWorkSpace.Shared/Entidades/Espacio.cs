using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Espacio
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de espacio")]
        [MaxLength(40, ErrorMessage = "El nombre del espacio no permite más de 40 caracteres")]
        [Required(ErrorMessage = "El nombre del espacio es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del espacio")]
        [MaxLength(100, ErrorMessage = "La descripción del espacio no permite más de 100 caracteres")]
        [Required(ErrorMessage = "La descripción del espacio es obligatorio")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad máxima del espacio")]
        [Required(ErrorMessage = "La cantidad máxima es obligatoria")]
        public int CantidadMax { get; set; }

    }
}
