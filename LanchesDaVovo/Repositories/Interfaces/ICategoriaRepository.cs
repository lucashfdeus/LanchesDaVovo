using LanchesDaVovo.Models;
using System.Collections.Generic;

namespace LanchesDaVovo.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
