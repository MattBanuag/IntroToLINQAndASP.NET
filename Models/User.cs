using LAB_01.Data;

namespace LAB_01.Models
{
    public class User
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private string _name;
        public string Name 
        { 
            get { return _name; } 
            set
            {
                if(value.Length != 0 && value.Length > 0)
                {
                    _name = value;
                } else
                {
                    throw new Exception("User's name length cannot be zero or less");
                }
            }
        }

        private HashSet<Rating> _ratings = new HashSet<Rating>();

        // === METHODS
        public HashSet<Rating> GetRatings()
        {
            return _ratings.ToHashSet();
        }

        public void AddRating(Rating rating)
        {
            _ratings.Add(rating);
        }

        // === CONSTRUCTORS
        public User()
        {

        }

        public User(int id, string name)
        {
            _id = id;
            Name = name;
        }
    }
}
