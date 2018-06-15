using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership.Controllers.Resources;
using CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Presistence {
    public class CarRepository : ICarRepository {
        private readonly CarDealershipDbContext _context;

        public CarRepository (CarDealershipDbContext context) {
            this._context = context;
        }

        public async Task<IEnumerable<Car>> GetCars (CarQueryOptions options) {

            IQueryable<Car> cars = _context.Cars;
            cars = ApplyFiltering (cars, options);

            return await cars.ToListAsync ();
        }

        private IQueryable<Car> ApplyFiltering (IQueryable<Car> cars, CarQueryOptions options) {
            if (!String.IsNullOrEmpty (options.Color))
                cars = cars.Where (car => car.Color.Equals (options.Color));

            if (options.HasSunroof)
                cars = cars.Where (c => c.HasSunroof);

            if (options.IsFourWheelDrive)
                cars = cars.Where (c => c.IsFourWheelDrive);

            if (options.HasLowMiles)
                cars = cars.Where (c => c.HasLowMiles);

            if (options.HasPowerWindows)
                cars = cars.Where (c => c.HasPowerWindows);

            if (options.HasNavigation)
                cars = cars.Where (c => c.HasNavigation);

            if (options.HasHeatedSeats)
                cars = cars.Where (c => c.HasHeatedSeats);

            return cars;
        }
    }

}