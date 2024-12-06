using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface IDocumentarRepository : IRepository<Documentar>
    {
        void Update (Documentar documentar);

        IEnumerable<SelectListItem> GetListaCategorias ();
        void Add (Recursos recursos);
    }
}
