using Microsoft.AspNetCore.Mvc;
using LAB_01.Data;
using LAB_01.Models;

namespace LAB_01.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "All movies";
            return View(Context.Movies);
        }

        public IActionResult GetMovieInfo(string title)
        {
            Movie movie = Context.Movies.First(m =>
            {
                // Using 'Equals' to ignore case
                return m.Title.Equals(title, StringComparison.OrdinalIgnoreCase);
            }); 

            ViewBag.PageTitle = movie.Title;    
            return View("Details", movie);
        }

        public IActionResult GetAllInGenre(string genre)
        {
            List<string> genres = Enum.GetNames(typeof(Genres)).ToList();

            if (genres.Contains(genre, StringComparer.OrdinalIgnoreCase))
            {
                HashSet<Movie> moviesInGenre = Context.Movies.Where(m =>
                {
                    return m.Genre.ToString().Equals(genre, StringComparison.OrdinalIgnoreCase);
                }).ToHashSet();

                ViewBag.PageTitle = $"Movies in {genre}";

                return View("Index", moviesInGenre);
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult GetMoviesInBudget(int lower, int upper)
        {
            ViewBag.PageTitle = $"Movies with ${lower} to ${upper} in budget.";
            HashSet<Movie> movies = Context.Movies.Where(m =>
            {
                return m.Budget >= lower && m.Budget <= upper;
            }).ToHashSet();

            return View("Index", movies);
        }

        public IActionResult GetMoviesInNineties(int year)
        {
            ViewBag.PageTitle = "Movies in the 90s";
            HashSet<Movie> movies = Context.Movies.Where(m =>
            {
                return m.ProductionDate.Year == year;
            }).ToHashSet();

            return View("Index", movies);
        }
    }
}
