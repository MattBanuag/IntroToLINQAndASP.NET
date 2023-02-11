using Microsoft.AspNetCore.Mvc;
using LAB_01.Data;
using LAB_01.Models;
using LAB_01.Models.ViewModels;

namespace LAB_01.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.PageTitle = "Highest paid actors(greatest to least)";
            HashSet<Actor> actors = Context.Actors.OrderByDescending(a =>
            {
                return a.Salary;
            }).ToHashSet();
            return View(actors);
        }

        public IActionResult Details(int id)
        {
            Actor actor = Context.Actors.First(a =>
            {
                return a.Id == id;
            });

            ViewBag.PageTitle = $"{actor.Name}";
            return View(actor);
        }

        public IActionResult CreateRating()
        {
            RateActorVM vm = new RateActorVM(Context.Actors, Context.Users);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Create([Bind("ActorId", "UserId", "Score", "Comment")] RateActorVM vm)
        {
            try
            {
                Actor actor = Context.Actors.First(m => m.Id == Int32.Parse(vm.ActorId));
                User user = Context.Users.First(u => u.Id == Int32.Parse(vm.UserId));
                int score = vm.Score;
                string comment = vm.Comment;

                Rating newRating = new Rating(Context.RatingIdCounter++, score, user, actor, comment);

                actor.AddRating(newRating);
                user.AddRating(newRating);
                Context.Ratings.Add(newRating);

                return RedirectToAction("Details", "Actor", new { id = actor.Id });
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
