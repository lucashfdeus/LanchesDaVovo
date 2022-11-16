using LanchesDaVovo.Models;
using System.Collections.Generic;

namespace LanchesDaVovo.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
