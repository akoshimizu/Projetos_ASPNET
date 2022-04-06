using System;

namespace PROJETO.Models
{
    public class VendaIngresso
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public float ValorTotal { get; set; }
        public float ValorPago { get; set; }
    }
}