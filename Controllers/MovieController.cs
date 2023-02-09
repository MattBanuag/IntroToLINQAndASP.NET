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
                return m.Title.Equals(title);
            }); 

            ViewBag.PageTitle = movie.Title;    
            return View("Details", movie);
        }
    }
}
