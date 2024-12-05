using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.Models
{
    public class Equipo_Software
    {
        [Key]
        [Required(ErrorMessage = "ID Equipo es obligatorio")]
        [Display(Name = "ID Equipo")]
        public int ID_EQÚIPO { get; set; }

        [Required(ErrorMessage = "ID Software es obligatorio")]
        [Display(Name = "ID Software")]
        public int ID_SOFTWARE { get; set; }
    }
}
