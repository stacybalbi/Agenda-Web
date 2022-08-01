using Agenda_Web.Data;
using Agenda_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;


namespace Agenda_Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _contexto;

        public IConfiguration Configuration { get; }
        public HomeController(ApplicationDBContext contexto)
        {
            _contexto = contexto;
        }


        //INDEX
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Usuario.ToListAsync());
        }

        //CREAR
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Usuario.Add(usuario);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //EDITAR
        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _contexto.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(usuario);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        //Borrar
        [HttpGet]
        public IActionResult Borrar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _contexto.Usuario.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }


        [HttpPost, ActionName("Borrar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> BorrarUsuario(int? id)
        {
            var usuario = await _contexto.Usuario.FindAsync(id);
            if (usuario == null)
            {
                return View();
            }

            _contexto.Usuario.Remove(usuario);
            await _contexto.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}