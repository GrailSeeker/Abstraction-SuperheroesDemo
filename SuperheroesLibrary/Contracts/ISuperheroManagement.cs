using SuperheroesLibrary.Common;
using System.Threading.Tasks;

namespace SuperheroesLibrary.Contracts
{
    public interface ISuperheroManagement
    {
        Task AddAsync(string name, string superpower, SuperheroUniverse superheroUniverse);
    }
}
