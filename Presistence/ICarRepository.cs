using System.Collections.Generic;
using System.Threading.Tasks;
using CarDealership.Controllers.Resources;
using CarDealership.Models;

namespace CarDealership.Presistence
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetCars(CarQueryOptions options);
    }
}