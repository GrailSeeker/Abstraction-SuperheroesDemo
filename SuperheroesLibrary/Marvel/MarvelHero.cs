using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperheroesLibrary.Marvel
{
    public sealed class MarvelHero : ISuperhero
        {
            public string Name { get; private set; }

            public string Superpower { get; private set; }

            public SuperheroUniverse SuperheroUniverse { get; private set; }

            public ICollection<ISuperhero> Superheroes { get; set; }

            public MarvelHero()
            {
                Superheroes = new List<ISuperhero>();
            }

            public async Task AddAsync(string name, string superpower, SuperheroUniverse superheroUniverse)
            {
                var marvelHero = new MarvelHero
                {
                    Name = name,
                    Superpower = superpower,
                    SuperheroUniverse = superheroUniverse
                };

                await Task.Run(() => Superheroes.Add(marvelHero));
            }
    }
}
