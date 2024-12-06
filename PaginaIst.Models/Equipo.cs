using System.ComponentModel.DataAnnotations;

namespace PaginaIst.Models
{
    public class Equipo
    {
        [Key]
        public int PLACA { get; set; }

        [Required(ErrorMessage = "La id empleado es obligatorio")]
        [Display(Name = "Id Empleado")]
        public string ID_EMPLEADO { get; set; }

        [Required(ErrorMessage = "El Hostname es obligatoria")]
        [Display(Name = "Hostname")]
        public string HOSTNAME { get; set; }

        [Display(Name = "Fecha Inicio")]
        public string FECHA_INICIO { get; set; }

        [Display(Name = "Fecha Fin")]
        public string FECHA_FIN { get; set; }

        [Required(ErrorMessage = "El Id tipo equipo es obligatorio")]
        [Display(Name = "Id tipo equipo")]
        public string ID_TIPOEQUIPO { get; set; }

        [Required(ErrorMessage = "La Marca es obligatoria")]
        [Display(Name = "Marca")]
        public string MARCA { get; set; }

        [Required(ErrorMessage = "El modelo es obligatoria")]
        [Display(Name = "Modelo")]
        public string MODELO { get; set; }

        [Required(ErrorMessage = "El serial es obligatoria")]
        [Display(Name = "Serial")]
        public string SERIAL { get; set; }

        [Required(ErrorMessage = "El NIT Proveedor es obligatoria")]
        [Display(Name = "Nit Proveedor")]
        public string NIT_PROVEEDOR { get; set; }

        [Required(ErrorMessage = "La Garantia es obligatoria")]
        [Display(Name = "Garantia")]
        public string GARANTIA { get; set; }

        [Required(ErrorMessage = "La Vida Util es obligatoria")]
        [Display(Name = "Vida Util")]
        public string VIDA_UTIL { get; set; }

        [Required(ErrorMessage = "La Fuente y Accesorios es obligatoria")]
        [Display(Name = "Fuente y Accesorios")]
        public string FUENTE_Y_DEMAS_ACCESORIOS { get; set; }

        [Display(Name = "Capacidad Fuente")]
        public string CAPACIDAD_FUENTE { get; set; }

        [Required(ErrorMessage = "El Procesador es obligatoria")]
        [Display(Name = "Procesador")]
        public string PROCESADOR { get; set; }

        [Required(ErrorMessage = "El Disco N°1 es obligatoria")]
        [Display(Name = "Disco N°1 ")]
        public string CLASE_DE_DISCO_No1 { get; set; }

        [Required(ErrorMessage = "La Capacidad del Disco N°1 es obligatoria")]
        [Display(Name = "Capacidad del Disco N°1 ")]
        public string CAPACIDAD_DISCO_No1 { get; set; }

        [Required(ErrorMessage = "El Disco N°2 es obligatoria")]
        [Display(Name = "Disco N°2 ")]
        public string CLASE_DE_DISCO_No2 { get; set; }

        [Required(ErrorMessage = "La Capacidad del Disco N°2 es obligatoria")]
        [Display(Name = "Capacidad del Disco N°2 ")]
        public string CAPACIDAD_DISCO_No2 { get; set; }

        [Required(ErrorMessage = "La Memoria RAM N°1 es obligatoria")]
        [Display(Name = "Memoria RAM N°1 ")]
        public string MEMORIA_RAM_1 { get; set; }

        [Required(ErrorMessage = "La Memoria RAM N°2 es obligatoria")]
        [Display(Name = "Memoria RAM N°2 ")]
        public string MEMORIA_RAM_2 { get; set; }

    }
}
