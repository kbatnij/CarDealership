using System.Collections.Generic;
using System.Threading.Tasks;
using CarDealership.Models;
using CarDealership.Presistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Controllers
{
    public class CarsController : Controller
    {
        private readonly CarDealershipDbContext _context;

        public CarsController (CarDealershipDbContext context) {
            this._context = context;
        }

        [HttpGet ("/api/cars")]
        public async Task<IEnumerable<Car>> GetCars () {
            var cars = await _context.Cars.ToListAsync ();
            return cars;
        }
    }
}