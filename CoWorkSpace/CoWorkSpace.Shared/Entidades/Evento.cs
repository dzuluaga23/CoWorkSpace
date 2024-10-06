using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Evento
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del evento")]
        [MaxLength(40, ErrorMessage = "El nombre del evento no permite más de 40 caracteres")]
        [Required(ErrorMessage = "El nombre del evento es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del evento")]
        [MaxLength(100, ErrorMessage = "La descripción del evento no permite más de 100 caracteres")]
        [Required(ErrorMessage = "La descripción del evento es obligatorio")]
        public string Descripcion { get; set; }

        [Display(Name = "Fecha del evento")]
        [Required(ErrorMessage = "La fecha del evento es obligatorio")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        [Display(Name = "Hora del evento")]
        [Required(ErrorMessage = "La hora del evento es obligatoria")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Hora { get; set; }

        [Display(Name = "Cantidad máxima del evento")]
        [Required(ErrorMessage = "La cantidad máxima del evento es obligatoria")]
        public int CantidadMax { get; set; }

        [JsonIgnore]
        public ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
