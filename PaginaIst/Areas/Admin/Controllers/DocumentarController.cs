using Microsoft.AspNetCore.Mvc;
using PaginaIst.AccesoDatos.Data.Repository.IRepository;
using PaginaIst.Models;
using System.Diagnostics;

namespace PaginaIst.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Administrador")]
    [Area("Admin")]
    public class DocumentarController : Controller
    {
        private readonly ILogger<DocumentarController> _logger;

        public DocumentarController (ILogger<DocumentarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error ()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}

