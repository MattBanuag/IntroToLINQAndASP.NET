using LAB_01.Data;

namespace LAB_01.Models
{
    public class Role
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private string _part;
        public string Part
        {
            get
            {
                return _part;
            }
            set
            {
                if (value.Length > 0)
                {
                    _part = value;
                }
                else
                {
                    throw new Exception("Actor's Part must have a value.");
                }
            }
        }

        public Actor Actor { get; set; }
        public Movie Movie { get; set; }

        public Role(int id, string part, Actor actor, Movie movie)
        {
            _id = id;
            Part = part;
            Movie = movie;
            Actor = actor;
        }
    }
}
