using TFSSincronizador.Models;

namespace TFSSincronizador.Repositories.Interfaces
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> Profiles { get; }
    }
}
