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


    }
}
