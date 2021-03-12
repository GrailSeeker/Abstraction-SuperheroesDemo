using SuperheroesLibrary.Common;

namespace SuperheroesLibrary.Contracts
{
    public interface ISuperhero : ISuperheroManagement, ISuperheroCollection
    {
        public string Name { get;}
        public string Superpower { get;}
        public SuperheroUniverse SuperheroUniverse { get; }
    }
}
