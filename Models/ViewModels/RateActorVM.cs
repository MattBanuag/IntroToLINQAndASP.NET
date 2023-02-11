using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB_01.Models.ViewModels
{
    public class RateActorVM
    {
        public List<SelectListItem> Actors { get; } = new List<SelectListItem>();
        public List<SelectListItem> Users { get; } = new List<SelectListItem>();
        public string ActorId { get; set; }
        public string UserId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }

        public RateActorVM(HashSet<Actor> actors, HashSet<User> users)
        {
            foreach (Actor a in actors)
            {
                Actors.Add(new SelectListItem(a.Name, a.Id.ToString()));
            }

            foreach (User u in users)
            {
                Users.Add(new SelectListItem(u.Name, u.Id.ToString()));
            }
        }

        public RateActorVM()
        {

        }
    }
}
