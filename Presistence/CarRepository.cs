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

            var cars = _context.Cars.AsQueryable ();
            cars = ApplyFiltering (cars, options);

            return await cars.ToListAsync ();
        }

        private IQueryable<Car> ApplyFiltering (IQueryable<Car> cars, CarQueryOptions options) {
            if (!String.IsNullOrEmpty (options.Color))
                cars = cars.Where (car => car.Color.Equals (options.Color));

            if (options.HasSunroof.HasValue)
                cars = cars.Where (c => c.HasSunroof == options.HasSunroof);

            if (options.IsFourWheelDrive.HasValue)
                cars = cars.Where (c => c.IsFourWheelDrive == options.IsFourWheelDrive);

            if (options.HasLowMiles.HasValue)
                cars = cars.Where (c => c.HasLowMiles == options.HasLowMiles);

            if (options.HasPowerWindows.HasValue)
                cars = cars.Where (c => c.HasPowerWindows == options.HasPowerWindows);

            if (options.HasNavigation.HasValue)
                cars = cars.Where (c => c.HasNavigation == options.HasNavigation);

            if (options.HasHeatedSeats.HasValue)
                cars = cars.Where (c => c.HasHeatedSeats == options.HasHeatedSeats);

            return cars;
        }
    }

}