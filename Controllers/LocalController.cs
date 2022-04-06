using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PROJETO.Data;
using PROJETO.DTO;
using PROJETO.Models;

namespace PROJETO.Controllers
{ 
    public class LocalController : Controller
    {
        private readonly ApplicationDbContext database;
        public LocalController(ApplicationDbContext database)
        {
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar(LocalDTO localTemporario)
            {
                if(ModelState.IsValid)
                {
                    Local local = new Local();
                    local.NomeDoLocal = localTemporario.NomeDoLocal;
                    database.Locais.Add(local);
                    database.SaveChanges();                    
                    return RedirectToAction("ListaLocais", "Admin");
                }
                else
                {
                    return View("../Admin/NovoLocal");
                }
            }

        public IActionResult Editar(LocalDTO localTemp)
        {
            var local = database.Locais.First(l => l.Id == localTemp.Id);
            local.NomeDoLocal = localTemp.NomeDoLocal;
            database.SaveChanges();
            return RedirectToAction("ListaLocais","Admin");
        }
    }
}