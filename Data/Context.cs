﻿using LAB_01.Models;

namespace LAB_01.Data
{
    public static class Context
    {
        public static HashSet<Movie> Movies = new HashSet<Movie>();
        public static HashSet<Actor> Actors = new HashSet<Actor>();
        private static int _movieIdCounter = 0;
        private static int _actorIdCounter = 0;
        private static void _seedMethod()
        {
            // === SEED MOVIES
            Movie movie1 = new Movie(_movieIdCounter++, "Braveheart", new DateTime(2000, 5, 24), 65_000_000);
            Movie movie2 = new Movie(_movieIdCounter++, "Forrest Gump", new DateTime(1994, 7, 6), 55_000_000);
            Movie movie3 = new Movie(_movieIdCounter++, "Taken", new DateTime(2009, 1, 30), 25_000_000);
            Movie movie4 = new Movie(_movieIdCounter++, "The Goonies", new DateTime(1985, 6, 9), 19_000_000);

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            Movies.Add(movie4);

            // === SEED ACTORS
            Actor actor1 = new Actor(_actorIdCounter++, "Mel Gibson", movie1.Budget / 2);
            Actor actor2 = new Actor(_actorIdCounter++, "Tom Hanks", movie2.Budget / 2);
            Actor actor3 = new Actor(_actorIdCounter++, "Liam Neeson", movie3.Budget / 2);
            Actor actor4 = new Actor(_actorIdCounter++, "Josh Brolin", movie4.Budget / 2);

            Actors.Add(actor1);
            Actors.Add(actor2);
            Actors.Add(actor3);
            Actors.Add(actor4);

            actor1.AddMovieForActor(movie1);
            actor2.AddMovieForActor(movie2);
            actor3.AddMovieForActor(movie3);
            actor4.AddMovieForActor(movie4);

            movie1.AddActor(actor1);
            movie2.AddActor(actor2);
            movie3.AddActor(actor3);
            movie4.AddActor(actor4);


        }

        static Context()
        {
            _seedMethod();
        }
    }
}
