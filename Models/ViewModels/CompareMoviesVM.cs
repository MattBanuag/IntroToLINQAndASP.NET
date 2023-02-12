using Microsoft.AspNetCore.Mvc.Rendering;

namespace LAB_01.Models.ViewModels
{
    public class CompareMoviesVM
    {
        public List<SelectListItem> FirstListOfMovies { get; } = new List<SelectListItem>();
        public List<SelectListItem> SecondListOfMovies { get; } = new List<SelectListItem>();
        public string FirstMovieId { get; set; }
        public string SecondMovieId { get; set; }
        public Movie FirstSelectedMovie { get; set; }
        public Movie SecondSelectedMovie { get; set; }

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

        public CompareMoviesVM(Movie firstSelectedMovie, Movie secondSelectedMovie)
        {
            FirstSelectedMovie = firstSelectedMovie;
            SecondSelectedMovie = secondSelectedMovie;
        }

        public CompareMoviesVM()
        {

        }
    }
}
