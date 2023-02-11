using LAB_01.Models;

namespace LAB_01.Data
{
    public static class Context
    {
        public static HashSet<Movie> Movies = new HashSet<Movie>();
        public static HashSet<Actor> Actors = new HashSet<Actor>();
        public static HashSet<User> Users = new HashSet<User>();
        public static HashSet<Rating> Ratings = new HashSet<Rating>();
        public static HashSet<Role> Roles = new HashSet<Role>();

        public static int MovieIdCounter = 0;
        public static int ActorIdCounter = 0;
        public static int UserIdCounter = 0;
        public static int RatingIdCounter = 0;
        public static int RoleIdCounter = 0;

        private static void _seedMethod()
        {
            // === SEED MOVIES
            Movie movie1 = new Movie(MovieIdCounter++, "Braveheart", new DateTime(2000, 5, 24), 65_000_000, Genres.Action);
            Movie movie2 = new Movie(MovieIdCounter++, "Forrest Gump", new DateTime(1994, 7, 6), 55_000_000, Genres.Drama);
            Movie movie3 = new Movie(MovieIdCounter++, "Taken", new DateTime(2009, 1, 30), 25_000_000, Genres.Action);
            Movie movie4 = new Movie(MovieIdCounter++, "The Goonies", new DateTime(1985, 6, 9), 19_000_000, Genres.Comedy);

            Movies.Add(movie1);
            Movies.Add(movie2);
            Movies.Add(movie3);
            Movies.Add(movie4);

            // === SEED ACTORS
            Actor actor1 = new Actor(ActorIdCounter++, "Mel Gibson", movie1.Budget / 2);
            Actor actor2 = new Actor(ActorIdCounter++, "Tom Hanks", movie2.Budget / 2);
            Actor actor3 = new Actor(ActorIdCounter++, "Liam Neeson", movie3.Budget / 2);
            Actor actor4 = new Actor(ActorIdCounter++, "Josh Brolin", movie4.Budget / 2);

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

            // === SEED USERS
            User user1 = new User(UserIdCounter++, "UnicornMan23");
            User user2 = new User(UserIdCounter++, "CoolJake");
            User user3 = new User(UserIdCounter++, "ShadowLord007");
            User user4 = new User(UserIdCounter++, "CoolPapa28");

            Users.Add(user1);
            Users.Add(user2);
            Users.Add(user3);
            Users.Add(user4);

            // === SEED RATINGS
            Rating rating1 = new Rating(RatingIdCounter++, 8, user1, movie3, "Great movie!");
            Rating rating2 = new Rating(RatingIdCounter++, 7, user2, movie3, "Makes my heart melt!");
            Rating rating3 = new Rating(RatingIdCounter++, 6, user3, movie4, "Action packed and thrilling!");
            Rating rating4 = new Rating(RatingIdCounter++, 8, user2, movie4, "Awesome family movie.");

            Ratings.Add(rating1);
            Ratings.Add(rating2);
            Ratings.Add(rating3);
            Ratings.Add(rating4);

            user1.AddRating(rating1);
            user2.AddRating(rating2);
            user3.AddRating(rating3);
            user2.AddRating(rating4);

            movie3.AddRating(rating1);
            movie3.AddRating(rating2);
            movie4.AddRating(rating3);
            movie4.AddRating(rating4);

            // === SEED ROLES
            Role WilliamWallace = new Role(RoleIdCounter, "William Wallace", actor1, movie1);
            Role ForrestGump = new Role(RoleIdCounter, "Forrest Gump", actor2, movie2);
            Role BryanMills = new Role(RoleIdCounter, "Bryan Mills", actor3, movie3);
            Role BrandWalsh = new Role(RoleIdCounter, "Brand Walsh", actor4, movie4);

            Roles.Add(WilliamWallace);
            Roles.Add(ForrestGump);
            Roles.Add(BryanMills);
            Roles.Add(BrandWalsh);

            movie1.AddRole(WilliamWallace);
            movie2.AddRole(ForrestGump);
            movie3.AddRole(BryanMills);
            movie4.AddRole(BrandWalsh);

            actor1.AddRole(WilliamWallace);
            actor2.AddRole(ForrestGump);
            actor3.AddRole(BryanMills);
            actor4.AddRole(BrandWalsh);

        }

        static Context()
        {
            _seedMethod();
        }
    }

    public enum Genres
    {
        Action,
        Horror,
        Comedy,
        Drama,
        Documentary,
        Romance,
        Fantasy
    }
}
