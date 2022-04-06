using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PROJETO.Data;
using PROJETO.Models;

namespace PROJETO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext database;

        public HomeController(ApplicationDbContext database)
        {
            this.database = database;
        }

        public IActionResult Index()
        {
            var evento = database.Eventos.Where(e => e.Status == true).Include(c => c.Categoria).Include(loc => loc.Local).ToList();
            return View(evento);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Eventos()
        {
            var evento = database.Eventos.Where(e => e.Status == true).Include(c => c.Categoria).Include(loc => loc.Local).ToList();
            return View(evento);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
