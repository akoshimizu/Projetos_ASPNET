using System;

namespace PROJETO.Models
{
    public class SaidaIngresso
    {
        public int Id { get; set; }
        public Evento Evento { get; set; }
        public float ValorDaVenda { get; set; }
        public DateTime DataSaida { get; set; }
        public VendaIngresso VendaId { get; set; }
        
    }
}