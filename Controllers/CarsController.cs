using System.Collections.Generic;
using System.Threading.Tasks;
using CarDealership.Controllers.Resources;
using CarDealership.Models;
using CarDealership.Presistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Controllers
{
    [Route("/api/cars")]
    public class CarsController : Controller
    {
        private readonly ICarRepository _repository;

        public CarsController (ICarRepository repository) {
            this._repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Car>> GetCars (CarQueryOptions options) {
            var cars = await _repository.GetCars(options);
            return cars;
        }
    }
}