using System.ComponentModel.DataAnnotations;

namespace PROJETO.DTO
{
    public class CategoriaDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="Insira o nome da categoria")]
        [StringLength(20, ErrorMessage ="Max caracteres: 10")]
        [MinLength(2, ErrorMessage ="Min caracteres: 3")]
        public string NomeCategoria { get; set; }
    }
}