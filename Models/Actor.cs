using LAB_01.Data;

namespace LAB_01.Models
{
    public class Actor
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private string _name;
        public string Name 
        { 
            get { return _actorName; } 
            set
            {
                if(value.Length > 0)
                {
                    _actorName = value;
                } else
                {
                    throw new Exception("Actor's name cannot have a length of zero.");
                }
            }
        
        }

        private int _salary;
        public int Salary
        {
            get { return _salary; } 
            set 
            {
                if(value > 0) 
                {
                    _salary = value;
                } else
                {
                    throw new Exception("Actor's salary cannot be zero.");
                }
            }
        }

        private HashSet<Movie> _movies = new HashSet<Movie>();

        // === METHODS
        public HashSet<Movie> GetMoviesOfActor()
        {
            return _movies.ToHashSet();
        }
        public void AddMovieForActor(Movie movie)
        {
            _movies.Add(movie);
        }

        // === CONSTRUCTORS
        public Actor()
        {

        }

        public Actor(int id, string name, int salary)
        {
            _id = id;
            Name = name;
            Salary = salary;
        }
    }
}
