using System.ComponentModel.DataAnnotations;

namespace PROJETO.DTO
{
    public class LocalDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Insira o nome do local")]
        [StringLength(20, ErrorMessage ="Max de Caracteres: 20")]
        [MinLength(3, ErrorMessage ="Min de Caracteres: 3")]
        public string NomeDoLocal { get; set; }
    }
}