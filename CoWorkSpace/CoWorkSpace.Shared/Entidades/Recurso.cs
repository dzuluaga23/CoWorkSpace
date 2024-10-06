using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Recurso
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de recurso")]
        [MaxLength(40, ErrorMessage = "El nombre del recurso no permite más de 40 caracteres")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del recurso")]
        [MaxLength(100, ErrorMessage = "La descripción del recurso no permite más de 100 caracteres")]
        [Required(ErrorMessage = "La descripción es obligatorio")]
        public string Descripcion { get; set; }

    }
}
