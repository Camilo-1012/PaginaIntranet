using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface IRecursoRepository : IRepository<Recurso>
    {
        void Update (Recurso recurso);

        // Método para obtener una lista de categorías asociadas a los recursos
        IEnumerable<SelectListItem> GetListaCategorias ();
        void Update (Recursos recursos);
    }
}
