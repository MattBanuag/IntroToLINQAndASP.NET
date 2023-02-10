using LAB_01.Data;
using LAB_01.Models;
using LAB_01.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LAB_01.Controllers
{
    public class RatingController : Controller
    {
        public IActionResult Create()
        {
            RateMovieVM vm = new RateMovieVM(Context.Movies, Context.Users);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create([Bind("MovieId", "UserId", "Score", "Comment")] RateMovieVM vm)
        {
            try
            {
                Movie movie = Context.Movies.First(m => m.Id == Int32.Parse(vm.MovieId));
                User user = Context.Users.First(u => u.Id == Int32.Parse(vm.UserId));
                int score = vm.Score;
                string comment = vm.Comment;

                // Create new rating and add to Context/Actor relationships
                Rating newRating = new Rating(Context.RatingIdCounter++, score, user, movie, comment);

                movie.AddRating(newRating);
                user.AddRating(newRating);
                Context.Ratings.Add(newRating);

                return RedirectToAction("Info", "Movie", new { id = movie.Id });
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
