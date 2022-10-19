using LanchesDaVovo.Models;
using System.Collections.Generic;

namespace LanchesDaVovo.ViewModel
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
