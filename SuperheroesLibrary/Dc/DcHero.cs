using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperheroesLibrary.Dc
{
    public sealed class DcHero : ISuperhero
    {
        public string Name { get; private set; }

        public string Superpower { get; private set; }

        public SuperheroUniverse SuperheroUniverse { get; private set; }

        public ICollection<ISuperhero> Superheroes { get; set; }

        public DcHero()
        {
            Superheroes = new List<ISuperhero>();
        }

        public async Task AddAsync(string name, string superpower, SuperheroUniverse superheroUniverse)
        {
            var dcHero = new DcHero
            {
                Name = name,
                Superpower = superpower,
                SuperheroUniverse = superheroUniverse
            };

            await Task.Run(() => Superheroes.Add(dcHero));
        }
    }
}
