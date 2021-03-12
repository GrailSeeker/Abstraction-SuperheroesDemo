using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using SuperheroesLibrary.Dc;
using SuperheroesLibrary.Marvel;

namespace SuperheroesLibrary.Factory
{
    public static class SuperheroFactory
    {
        static MarvelHero marvelHero;
        static DcHero dcHero;

        public static ISuperhero GetSuperhero(SuperheroUniverse universe)
        {
            ISuperhero superhero = null;

            if (universe.Universe.Equals(SuperheroUniverse.Marvel.Universe))
            {
                if (marvelHero == null)
                {
                    marvelHero = new MarvelHero();
                }

                superhero = marvelHero;
            }

            if (universe.Universe.Equals(SuperheroUniverse.Dc.Universe))
            {
                if (dcHero == null)
                {
                    dcHero = new DcHero();
                }

                superhero = dcHero;
            }

            return superhero;
        }
    }
}
