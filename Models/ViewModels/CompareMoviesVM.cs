using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB_01.Models.ViewModels
{
    public class CompareMoviesVM
    {
        public List<SelectListItem> FirstListOfMovies { get; } = new List<SelectListItem>();
        public List<SelectListItem> SecondListOfMovies { get; } = new List<SelectListItem>();
        public int FirstMovieId { get; set; }
        public int SecondMovieId { get; set; }

        public CompareMoviesVM(HashSet<Movie> firstListOfMovies, HashSet<Movie> secondListOfMovies)
        {
            foreach (Movie m in firstListOfMovies)
            {
                FirstListOfMovies.Add(new SelectListItem(m.Title, m.Id.ToString()));
            }

            foreach (Movie m in secondListOfMovies)
            {
                SecondListOfMovies.Add(new SelectListItem(m.Title, m.Id.ToString()));
            }
        }

        public CompareMoviesVM()
        {

        }
    }
}
