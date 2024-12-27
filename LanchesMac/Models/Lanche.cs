using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Você deve usar um nome para o lanche")] // Isso é Data Annotation
        [Display(Name ="Nome do Lanche")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(100)]
        public string DescricaoCurta { get; set; }

        public string DescricaoDetalhada { get; set; }
        public float Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public int EmEstoque { get; set; }

        // CategoriaId é uma chave estrangeira
        public int CategoriaId { get; set; }

        // Propriedade de navegação
        public virtual Categoria Categorias { get; set; }
    }
}
