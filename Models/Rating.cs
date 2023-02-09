using LAB_01.Data;

namespace LAB_01.Models
{
    public class Rating
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private int _score;
        public int Score 
        { 
            get { return _score; } 
            set
            {
                if(value > 0 && value <= 10)
                {
                    _score = value;
                } else
                {
                    throw new Exception("Rating score must be between 1 and 10");
                }
            }
        }

        private HashSet<User> _users = new HashSet<User>();
        private HashSet<Movie> _movies = new HashSet<Movie>();

        // === CONSTRUCTORS
        public Rating(int id, int score, User user, Movie movie)
        {
            _id = id;
            Score = score;
            _users.Add(user);
            _movies.Add(movie);
        }
    }
}
