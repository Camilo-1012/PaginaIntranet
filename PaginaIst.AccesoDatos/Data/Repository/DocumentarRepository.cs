using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.AccesoDatos.Data.Repository;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Data;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository
{
}
public class DocumentarRepository : Repository<Documentar>, IDocumentarRepository
{
    private readonly ApplicationDbContext _db;

    public DocumentarRepository (ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Add (Recursos recursos)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<SelectListItem> GetListaCategorias ()
    {
        return _db.Documentar.Select(i => new SelectListItem()
        {
            Text = i.Descripcion,
            Value = i.Id.ToString()
        });
    }


    public void Update (Documentar documentar)
    {
        var
        objDesdeDb = _db.Documentar.FirstOrDefault(s => s.Id == documentar.Id);
        objDesdeDb.Nombre = documentar.Nombre;
        objDesdeDb.Descripcion = documentar.Descripcion;
        objDesdeDb.Ruta_evidencias = documentar.Ruta_evidencias;

        //_db.SaveChanges();
    }
}

