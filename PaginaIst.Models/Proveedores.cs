using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.Models
{
    public class Proveedores
    {
        [Key]
        public int NIT { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string NOMBRE { get; set; }

        [Required(ErrorMessage = "La Dirección es obligatoria")]
        [Display(Name = "Dirección")]
        public string DIRECCION { get; set; }

        [Display(Name = "Fecha de Inicio")]
        public DateTime? FECHA_INICIO { get; set; }

        [Display(Name = "Fecha de Fin")]
        public DateTime? FECHA_FIN { get; set; }
    }
}
