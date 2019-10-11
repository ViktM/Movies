using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesApp.Data;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesAppContext _context;

        public MoviesController(MoviesAppContext context)
        {
            _context = context;
        }
        
        public IActionResult GetMovies()
        {
            return Ok(_context.Movies);
        }
        
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Movies.ToListAsync());
        }

    }
}