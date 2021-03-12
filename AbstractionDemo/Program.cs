using AbstractionDemo.Contracts;
using AbstractionDemo.Services;
using SuperheroesLibrary.Common;
using SuperheroesLibrary.Contracts;
using SuperheroesLibrary.Factory;
using System;
using System.Collections.Generic;

namespace AbstractionDemo
{
    class Program
    {
        static ISuperheroService _superheroService;

        static void Main(string[] args)
        {
            _superheroService = new SuperheroService();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nAdding superheroes from seed data...\n");

            _superheroService.AddSuperheroesAysncFromSeedData().Wait();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nListing Marvel superheroes and their superpowers:\n");
            ISuperhero superhero = SuperheroFactory.GetSuperhero(SuperheroUniverse.Marvel);
            ListSuperheroes(superhero.Superheroes);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nListing Dc superheroes and their superpowers:\n");
            superhero = SuperheroFactory.GetSuperhero(SuperheroUniverse.Dc);
            ListSuperheroes(superhero.Superheroes);

            Console.Read();
        }

        private static void ListSuperheroes(ICollection<ISuperhero> superheroes)
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var hero in superheroes)
            {
                Console.WriteLine($"{hero.Name} -> {hero.Superpower}");
            }
        }
    }
}
