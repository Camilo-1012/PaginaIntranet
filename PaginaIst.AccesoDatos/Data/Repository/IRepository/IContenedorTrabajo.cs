namespace PaginaIst.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        // Aqui se deben ir agregando los diferentes metodos
        ImantenimientoRepository Mantenimiento { get; }
        IRecursoRepository Recursos { get; }

        IDocumentarRepository Documentar { get; }

        void Save ();
    }
}
