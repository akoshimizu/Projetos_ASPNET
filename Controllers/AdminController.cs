using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJETO.Data;
using PROJETO.DTO;

namespace PROJETO.Controllers
{
    [Authorize(Policy="admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext database;
        public AdminController(ApplicationDbContext database)
        {
            this.database = database;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaEventos()
        {
            var evento = database.Eventos.Where(e => e.Status == true).Include(c => c.Categoria).Include(loc => loc.Local).ToList();
            return View(evento);
        }

        public IActionResult ListarEventosDesativados()
        {
            var evento = database.Eventos.Where(e => e.Status == false).Include(c => c.Categoria).Include(loc => loc.Local).ToList();
            return View(evento);
        }

        public IActionResult EditarEvento(int id)
        {
            var evento = database.Eventos.Include(c => c.Categoria).Include(l => l.Local).First(e => e.Id == id);
            EventoDTO eventoView = new EventoDTO();
            eventoView.Nome = evento.Nome;
            eventoView.CategoriaId = evento.Categoria.Id;
            eventoView.LocalId = evento.Local.Id;
            eventoView.Data = evento.Data;
            eventoView.Preco = evento.Preco;
            eventoView.QuantidadeIngresso = evento.QuantidadeIngresso;
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Locais = database.Locais.ToList();
            return View(eventoView);
        }

        public IActionResult NovoEvento()
        {
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Locais = database.Locais.ToList();
            return View();
        }
        public IActionResult NovaCategoria()
        {
            return View();
        }

        public IActionResult ListaCategorias()
        {
            var categoria = database.Categorias.ToList();
            return View(categoria);
        }


        public IActionResult EditarCategoria(int id)
        {
            var categoria = database.Categorias.First(cat => cat.Id == id);
            CategoriaDTO categoriaView = new CategoriaDTO();
            categoriaView.Id = categoria.Id;
            categoriaView.NomeCategoria = categoria.NomeCategoria;
            return View(categoriaView);
        }
        public IActionResult NovoLocal()
        {
            return View();
        }
        
        public IActionResult ListaLocais()
        {
            var local = database.Locais.ToList();
            return View(local);
        }

        public IActionResult EditarLocal(int id)
        {
            var local = database.Locais.First(l => l.Id == id);
            LocalDTO localView = new LocalDTO();
            localView.NomeDoLocal = local.NomeDoLocal;
            return View(localView);
        }

        public IActionResult EstoqueIngressos()
        {
            ViewBag.Eventos = database.Eventos.ToList();
            return View();
        }
    }
}