using System.ComponentModel.DataAnnotations;

namespace PaginaIst.Models
{
    public class Documentar
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatorio")]
        [Display(Name = "Comentario")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "La ruta es obligatoria")]
        [Display(Name = "Ruta_evidencias")]
        public string? Ruta_evidencias { get; set; }
    }
}
