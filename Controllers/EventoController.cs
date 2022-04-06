using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PROJETO.Data;
using PROJETO.DTO;
using PROJETO.Models;


namespace PROJETO.Controllers
{
    
    
    public class EventoController : Controller
    {
        private readonly ApplicationDbContext database;
        public EventoController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult NovoEvento()
        {
            ViewBag.Categorias = database.Categorias.ToList();
            return View();   
        }

        [HttpPost]
        public IActionResult Salvar(EventoDTO eventoTemporario)
        {
            ViewBag.Categorias = database.Categorias.ToList();
            ViewBag.Locais = database.Locais.ToList();
            if(eventoTemporario.CategoriaId <=0 || eventoTemporario.LocalId <=0)
            {
                return Content("Categoria e/ou Local Inválido");
            }
            else
            {

                if(ModelState.IsValid)
                {
                    
                    Evento evento = new Evento();
                    evento.Nome = eventoTemporario.Nome;
                    evento.Categoria = database.Categorias.First(e => e.Id == eventoTemporario.CategoriaId);
                    evento.Local = database.Locais.First(local => local.Id == eventoTemporario.LocalId);
                    evento.Data = eventoTemporario.Data;
                    evento.Preco = eventoTemporario.Preco;
                    evento.QuantidadeIngresso = eventoTemporario.QuantidadeIngresso;
                    evento.Status = true;
                    database.Eventos.Add(evento);
                    database.SaveChanges();
                    return RedirectToAction("ListaEventos", "Admin");      
                }
                else
                {
                    return View("../Admin/ListaEventos"); 
                }
            }
        }

        [HttpPost]
        public IActionResult Atualizar(EventoDTO eventoTemporario)
        {
            if(ModelState.IsValid)
            {
                var evento = database.Eventos.First(e => e.Id == eventoTemporario.Id);
                evento.Nome = eventoTemporario.Nome;
                evento.Categoria = database.Categorias.First(cat => cat.Id == eventoTemporario.CategoriaId);
                evento.Local = database.Locais.First(loc => loc.Id == eventoTemporario.LocalId);
                evento.Data = eventoTemporario.Data;
                evento.Preco = eventoTemporario.Preco;
                evento.QuantidadeIngresso = eventoTemporario.QuantidadeIngresso;
                database.SaveChanges();
                return RedirectToAction("ListaEventos", "Admin");
            }
            else
            {
                return Content("erro");
            }
        }

        public IActionResult FinalizarEvento(int id)
        {
            var evento = database.Eventos.Where(ev => ev.Id == id).First();
            evento.Status=false;
            database.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult AtivarEvento(int id)
        {
            var evento = database.Eventos.Where(ev => ev.Id == id).First();
            evento.Status=true;
            database.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

       [HttpPost]
        public IActionResult DeletarEvento(int id)
        {
            if(id>0)
            {
                var evento = database.Eventos.Where(evento => evento.Id == id).First();
                database.Eventos.Remove(evento);
                database.SaveChanges();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return Content("Erro");
            }
            
        }
    }
}