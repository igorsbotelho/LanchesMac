using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage = "Nome muito longo")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Nome muito longo")]
        [Required(ErrorMessage = "Descrição é obrigatório")]
        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }  
    }
}
