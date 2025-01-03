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
        [StringLength(100)]
        [Display(Name ="Nome do Lanche")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(100)]
        public string DescricaoCurta { get; set; }

        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200)]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="Preço é obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage ="O preço deve estar entre 1 e 999.99")]
        public float Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Miniatura")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public int EmEstoque { get; set; }

        // CategoriaId é uma chave estrangeira
        public int CategoriaId { get; set; }

        // Propriedade de navegação
        public virtual Categoria Categorias { get; set; }
    }
}
