namespace SuperheroesLibrary.Common
{
    public class SuperheroUniverse
    {
        public readonly string Universe;

        public static readonly SuperheroUniverse Marvel = new SuperheroUniverse("Marvel");

        public static readonly SuperheroUniverse Dc = new SuperheroUniverse("Dc");

        private SuperheroUniverse(string universe)
        {
            Universe = universe;
        }
    }
}
