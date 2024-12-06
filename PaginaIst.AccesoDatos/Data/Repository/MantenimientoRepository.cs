using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.AccesoDatos.Data.Repository;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Data;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository
{
}
public class MantenimientoRepository : Repository<Mantenimiento>, ImantenimientoRepository
{
    private readonly ApplicationDbContext _db;

    public MantenimientoRepository (ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Add (Recursos recursos)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SelectListItem> GetListaCategorias ()
    {
        return _db.Mantenimiento.Select(i => new SelectListItem()
        {
            Text = i.Comentario,
            Value = i.Id.ToString()
        });
    }


    public void Update (Mantenimiento mantenimiento)
    {
        var
        objDesdeDb = _db.Mantenimiento.FirstOrDefault(s => s.Id == mantenimiento.Id);
        objDesdeDb.Comentario = mantenimiento.Comentario;
        objDesdeDb.Ruta_evidencias = mantenimiento.Ruta_evidencias;

        //_db.SaveChanges();
    }
}

