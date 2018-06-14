using CarDealership.Models;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Presistence
{
    public class CarDealershipDbContext : DbContext
    {
        public CarDealershipDbContext(DbContextOptions<CarDealershipDbContext> options)
        :base(options)
        {
            
        }
        public DbSet<Car> Cars { get; set; }
    }
}