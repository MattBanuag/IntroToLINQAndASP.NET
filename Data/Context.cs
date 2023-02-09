using LAB_01.Models;

namespace LAB_01.Data
{
    public static class Context
    {
        public static HashSet<Movie> Movies = new HashSet<Movie>();
        private static int _movieIdCounter = 0;

        private static void _seedMethod()
        {
            Movie movie1 = new Movie(_movieIdCounter++, "Braveheart", new DateTime(2000, 5, 24), 65_000_000);
            Movie movie2 = new Movie(_movieIdCounter++, "Forrest Gump", new DateTime(1994, 7, 6), 55_000_000);
            Movie movie3 = new Movie(_movieIdCounter++, "Taken", new DateTime(2009, 1, 30), 25_000_000);
            Movie movie4 = new Movie(_movieIdCounter++, "The Goonies", new DateTime(1985, 6, 9), 19_000_000);

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            Movies.Add(movie4);
        }

        static Context()
        {
            _seedMethod();
        }
    }
}
