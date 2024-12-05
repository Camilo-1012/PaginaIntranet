using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El área es obligatorio")]
        [Display(Name = "Nombre Area")]
        public string? Nombre { get; set; }

    }
}