using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class LanchesViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }

        public string CategoriaAtual { get; set; }

    }
} 
