using Microsoft.AspNetCore.Mvc.Rendering;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Data;
using PaginaIst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PaginaIst.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo (ApplicationDbContext db)
        {
            _db = db;
            Mantenimiento = new MantenimientoRepository(_db);
            //Recursos = new RecursoRepository(_db);  
        }

        public ImantenimientoRepository Mantenimiento { get; private set; }

        public IRecursoRepository Recursos => throw new NotImplementedException();

        public object Documento => throw new NotImplementedException();

        public void Dispose ()
        {
            _db.Dispose();
        }

        public void Save ()
        {
            _db.SaveChanges();
        }
    }
}