using Microsoft.AspNetCore.Mvc;
using LAB_01.Data;
using LAB_01.Models;

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

            return View();
        }
    }
}
