﻿using System.ComponentModel.DataAnnotations;

namespace PaginaIst.Models
{
    public class Tipo_Mantenimiento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string NOMBRE { get; set; }

    }
}
