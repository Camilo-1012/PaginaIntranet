using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface ImantenimientoRepository : IRepository<Mantenimiento>
    {
        void Update (Mantenimiento mantenimiento);

        IEnumerable<SelectListItem> GetListaCategorias ();
        void Add (Recursos recursos);
    }
}
