using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PROJETO.Data;
using PROJETO.DTO;
using PROJETO.Models;

namespace PROJETO.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext database;
        public CategoriaController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(CategoriaDTO categoriaTemporaria)
        {
            if(ModelState.IsValid)
            {
                Categoria categoria = new Categoria();
                categoria.NomeCategoria = categoriaTemporaria.NomeCategoria;
                database.Categorias.Add(categoria);
                database.SaveChanges();
                return RedirectToAction("ListaCategorias", "Admin");
            }
            else
            {
                return View("../Admin/ListaCategorias");
            }
        }

        [HttpPost]
        public IActionResult Editar(CategoriaDTO categoriaTemporaria)
        {
            var categoria = database.Categorias.First(cat => cat.Id == categoriaTemporaria.Id);
            categoria.NomeCategoria = categoriaTemporaria.NomeCategoria;
            database.SaveChanges();
            return RedirectToAction("ListaCategorias", "Admin");
        }
    }
}