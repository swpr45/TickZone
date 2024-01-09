using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TickZone.Data;

namespace TickZone.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // by .include  method also including Cinema information
            var allMovies = await _context.Movies.Include(n=>n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
