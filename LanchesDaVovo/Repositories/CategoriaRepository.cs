using LanchesDaVovo.Context;
using LanchesDaVovo.Models;
using LanchesDaVovo.Repositories.Interfaces;
using System.Collections.Generic;

namespace LanchesDaVovo.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
