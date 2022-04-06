using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PROJETO.Models;

namespace PROJETO.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Categoria> Categorias {get; set;}
        public DbSet<Local> Locais{ get; set; }
        public DbSet<Evento> Eventos {get; set;}
        public DbSet<SaidaIngresso> SaidaIngressos {get; set;}
        public DbSet<VendaIngresso> vendaIngressos{get; set;}
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
