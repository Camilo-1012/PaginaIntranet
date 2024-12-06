﻿using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Data;
using PaginaIst.Models;

namespace PaginaIst.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {
        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo (ApplicationDbContext db)
        {
            _db = db;
            Mantenimiento = new MantenimientoRepository(_db);
            Documentar = new DocumentarRepository(_db);
            Recursos = new RecursoRepository(_db);
        }

        public ImantenimientoRepository Mantenimiento { get; private set; }

        public IRecursoRepository Recursos { get; private set; }

        public IDocumentarRepository Documentar { get; private set; }

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