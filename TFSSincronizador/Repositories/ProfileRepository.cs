using TFSSincronizador.Context;
using TFSSincronizador.Models;
using TFSSincronizador.Repositories.Interfaces;

namespace TFSSincronizador.Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _context;

        public ProfileRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Profile> Profiles => _context.Profiles;
    }
}
