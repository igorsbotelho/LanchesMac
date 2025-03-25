using LanchesMac.Context;
using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _appDbContext;

        public LancheRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Lanche> Lanches => _appDbContext.Lanches.Include(c => c.Categorias);

        public IEnumerable<Lanche> LanchesPreferidos => _appDbContext.Lanches.
            Where(p => p.IsLanchePreferido).
            Include(c => c.Categorias);

        public Lanche GetLancheById(int lancheId)
        {
            return _appDbContext.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
