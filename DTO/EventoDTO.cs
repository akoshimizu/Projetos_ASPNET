using System;
using System.ComponentModel.DataAnnotations;
using PROJETO.Models;
using System.Web;

namespace PROJETO.DTO
{
    public class EventoDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatório inserir o nome do novo Evento")]
        [StringLength(50, ErrorMessage ="Máximo de Caracteres: 50")]
        [MinLength(5, ErrorMessage ="Mínimo de Caracteres: 5")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório inserir a caregoria")]
        public int CategoriaId { get; set; }
        
        [Required(ErrorMessage = "Obrigatório inserir o local")]
        public int LocalId { get; set; }
        
        [Required(ErrorMessage = "Insira a data do Show")]
        public DateTime Data { get; set; }
        
        [Required(ErrorMessage = "Inserir o vaor do ingresso.")]
        public float Preco { get; set; }

        [Required(ErrorMessage = "Insira quantidade de Ingressos")]
        public int QuantidadeIngresso { get; set; }
    }
}