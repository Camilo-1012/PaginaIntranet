using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface ImantenimientoRepository : IRepository<Mantenimiento>
    {
        void Update (Mantenimiento mantenimiento);

        IEnumerable<SelectListItem> GetListaCategorias ();
        void Add (Recursos recursos);
    }
}
