using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Miembro
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del miembro")]
        [MaxLength(30, ErrorMessage = "El nombre no puede tener más de 30 caracteres.")]
        [Required(ErrorMessage = "Obligatorio")]
        public string Nombre { get; set; }


        [Display(Name = "Apellido del miembro")]
        [MaxLength(30, ErrorMessage = "El apellido no puede tener más de 30 caracteres.")]
        [Required(ErrorMessage = "Obligatorio")]
        public String Apellido { get; set; }

        [Display(Name = "Email del miembro")]
        [MaxLength(40, ErrorMessage = "El email no puede tener más de 40 caracteres, recuerde el formato ----@correo.com")]
        [Required(ErrorMessage = "Obligatorio")]
        public String Email { get; set; }

        [Display(Name = "Telefono del Miembro")]
        [MaxLength(10, ErrorMessage = "El Telefono no puede tener más de 10 caracteres")]
        public string TelefonoMovil { get; set; }

        [JsonIgnore]
        public Membresia Membresias { get; set; }
        public int MembresiaId { get; set; }

        [JsonIgnore]
        public ICollection<Reserva> Reservas { get; set; }

        [JsonIgnore]
        public ICollection<Inscripcion> Inscripcions { get; set; }
    }
}
