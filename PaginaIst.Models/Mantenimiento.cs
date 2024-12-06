using System.ComponentModel.DataAnnotations;

namespace PaginaIst.Models
{
    public class Mantenimiento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El comentario es obligatorio")]
        [Display(Name = "Comentario")]
        public string? Comentario { get; set; }

        [Required(ErrorMessage = "La ruta es obligatoria")]
        [Display(Name = "Ruta_evidencias")]
        public string Ruta_evidencias { get; set; }
    }
}
