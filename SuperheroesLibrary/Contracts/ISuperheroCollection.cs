using System.Collections.Generic;

namespace SuperheroesLibrary.Contracts
{
    public interface ISuperheroCollection
    {
        public ICollection<ISuperhero> Superheroes { get; set; }
    }
}
