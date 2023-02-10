using Microsoft.AspNetCore.Mvc;

namespace LAB_01.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
