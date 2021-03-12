using SuperheroesLibrary.Contracts;
using System.Threading.Tasks;

namespace AbstractionDemo.Contracts
{
    public interface ISuperheroService
    {
        Task AddSuperheroesAysncFromSeedData();
    }
}
