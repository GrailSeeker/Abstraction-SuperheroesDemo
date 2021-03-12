using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using SuperheroesLibrary.Factory;
using System.Threading.Tasks;

namespace SuperheroesLibrary
{
    public sealed class SuperheroManagement : ISuperheroManagement
    {
        public async Task AddAsync(string name, string superpower, SuperheroUniverse superheroUniverse)
        {
            var superhero = SuperheroFactory.GetSuperhero(superheroUniverse);

            await superhero.AddAsync(name, superpower, superheroUniverse);
        }
    }
}
