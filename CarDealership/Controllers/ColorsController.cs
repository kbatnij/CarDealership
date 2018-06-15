using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarDealership.Presistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarDealership.Controllers {
    [Route ("/api/colors")]
    public class ColorsController : Controller {
        private readonly CarDealershipDbContext _context;

        public ColorsController (CarDealershipDbContext context) {
            this._context = context;
        }

        [HttpGet ("/api/colors")]
        public async Task<IEnumerable<string>> GetMakes () {
            var colors = await _context.Cars.Select(x => x.Color).Distinct().ToListAsync ();
            return colors;
        }
    }
}