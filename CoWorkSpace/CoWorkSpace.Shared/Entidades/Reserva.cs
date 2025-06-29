﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoWorkSpace.Shared.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }

        [Display(Name = "Fecha Reserva")]
        [Required(ErrorMessage = "¡Esta fecha es obligatoria!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        public DateTime FechaReserva { get; set; }

        [Display(Name = "Hora inicio reserva")]
        [Required(ErrorMessage = "Obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm", ApplyFormatInEditMode = true)]
        public DateTime HoraInicio { get; set; }

        [Display(Name = "Hora Final reserva")]
        [Required(ErrorMessage = "Obligatoria")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm", ApplyFormatInEditMode = true)]
        public DateTime HoraFinal { get; set; }

        [JsonIgnore]
        public Miembro Miembros { get; set; }
        public int MiembroId { get; set; }

        [JsonIgnore]
        public Espacio Espacios { get; set; }
        public int EspacioId { get; set; }

    }
}
