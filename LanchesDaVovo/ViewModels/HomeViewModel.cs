using LanchesDaVovo.Models;
using System.Collections.Generic;

namespace LanchesDaVovo.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
