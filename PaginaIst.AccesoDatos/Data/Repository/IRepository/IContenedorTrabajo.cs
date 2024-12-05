using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        // Aqui se deben ir agregando los diferentes metodos
        ImantenimientoRepository Mantenimiento { get; }
        IRecursoRepository Recursos { get; }
        object Documento { get; }

        void Save ();
    }
}
