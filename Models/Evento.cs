using System;

namespace PROJETO.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public Local Local { get; set; }
        public DateTime Data { get; set; }
        public float Preco { get; set; }
        public int QuantidadeIngresso { get; set; }
        public bool Status { get; set; }
    }
}