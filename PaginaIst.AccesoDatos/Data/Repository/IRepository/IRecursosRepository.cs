using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.Data;
using PaginaIst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
