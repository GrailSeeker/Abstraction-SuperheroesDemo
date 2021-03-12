using AbstractionDemo.Contracts;
using SuperheroesLibrary;
using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AbstractionDemo.Services
{
    public class SuperheroService : ISuperheroService
    {
        ISuperheroManagement _superheroManagement;
        ICollection<Superhero> _superheroes;

        public SuperheroService()
        {
            _superheroManagement = new SuperheroManagement();

            SeedData();
        }

        public async Task AddSuperheroesAysncFromSeedData()
        {
            foreach (var superhero in _superheroes)
            {
                await _superheroManagement.AddAsync(superhero.Name, superhero.Superpower, superhero.SuperheroUniverse);

                Console.WriteLine($"Added: {superhero.Name} ({superhero.SuperheroUniverse.Universe})");
            }
        }

        /// <summary>
        /// Test purposes only.
        /// </summary>
        /// <returns></returns>
        private void SeedData()
        {
            _superheroes = new List<Superhero>()
            {
                 new Superhero{Name="Black Widow", Superpower="Kill",SuperheroUniverse=SuperheroUniverse.Marvel},
                 new Superhero{Name="Superman", Superpower="Fly",SuperheroUniverse=SuperheroUniverse.Dc},
                 new Superhero{Name="Thor", Superpower="Mjolnir",SuperheroUniverse=SuperheroUniverse.Marvel},
                 new Superhero{Name="Batman", Superpower="Justice",SuperheroUniverse=SuperheroUniverse.Dc},
                 new Superhero{Name="Hulk", Superpower="Smash!",SuperheroUniverse=SuperheroUniverse.Marvel},
                 new Superhero{Name="Joker", Superpower="Loves fun!!!",SuperheroUniverse=SuperheroUniverse.Dc},
                 new Superhero{Name="Loki", Superpower="Lies",SuperheroUniverse=SuperheroUniverse.Marvel},
                 new Superhero{Name="Wonder Woman", Superpower="Swordplay",SuperheroUniverse=SuperheroUniverse.Dc},
                 new Superhero{Name="Dr. Strange", Superpower="Magic circles",SuperheroUniverse=SuperheroUniverse.Marvel},
                 new Superhero{Name="Aquaman", Superpower="Water lord",SuperheroUniverse=SuperheroUniverse.Dc}
            };
        }
    }
}
