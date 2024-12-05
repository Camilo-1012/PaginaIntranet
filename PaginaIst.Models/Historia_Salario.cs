using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.Models
{
    public class Historia_Salario
    {
        [Key]
        public int ID_EMPLEADO { get; set; }

        [Required(ErrorMessage = "El Salario es obligatorio")]
        [Display(Name = "Salario")]
        public string? SALARIO { get; set; }

        [Display(Name = "Fecha de Inicio")]
        public DateTime? FECHA_INICIO { get; set; }

        [Display(Name = "Fecha de Fin")]
        public DateTime? FECHA_FIN { get; set; }
    }
}
