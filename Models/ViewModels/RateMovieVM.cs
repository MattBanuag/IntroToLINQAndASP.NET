using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB_01.Models.ViewModels
{
    public class RateMovieVM
    {
        public List<SelectListItem> Movies { get; } = new List<SelectListItem>();
        public List<SelectListItem> Users { get; } = new List<SelectListItem>();
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public int Score { get; set; }
        public string Comment { get; set; }

        public RateMovieVM(HashSet<Movie> movies, HashSet<User> users)
        {
            foreach (Movie m in movies)
            {
                Movies.Add(new SelectListItem(m.Title, m.Id.ToString()));
            }

            foreach (User u in users)
            {
                Users.Add(new SelectListItem(u.Name, u.Id.ToString()));
            }
        }

        public RateMovieVM()
        {

        }
    }
}
