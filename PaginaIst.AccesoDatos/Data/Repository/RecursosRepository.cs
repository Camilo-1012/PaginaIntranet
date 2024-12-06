using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Data;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository
{
    public class RecursoRepository : Repository<Recurso>, IRecursoRepository
    {
        private readonly ApplicationDbContext _db;

        public RecursoRepository (ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update (Recurso recurso)
        {
            var objDesdeDb = _db.Recursos.FirstOrDefault(r => r.Id == recurso.id);
            if (objDesdeDb != null)
            {
                objDesdeDb.Nombre = recurso.Nombre;
                objDesdeDb.Descripcion = recurso.Descripcion;
            }
        }

        public IEnumerable<SelectListItem> GetListaCategorias ()
        {
            return _db.Recursos.Select(r => new SelectListItem
            {
                Text = r.Nombre,
                Value = r.Id.ToString()
            });
        }

        public void Update (Recursos recursos)
        {
            throw new NotImplementedException();
        }
    }
}



