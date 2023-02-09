﻿using LAB_01.Data;

namespace LAB_01.Models
{
    public class Movie
    {
        private readonly int _id;
        public int Id { get { return _id; } }

        private string _title;
        public string Title 
        { 
            get { return _title; } 
            set
            {
                if(value.Length != 0) 
                {
                    _title = value;
                } else
                {
                    throw new Exception("Movie title length cannot be zero.");
                }
            }
        }

        public DateTime ProductionDate { get; set; }

        private int _budgetInMillions;
        public int BudgetInMillions 
        { 
            get { return _budgetInMillions; } 
            set
            {
                if(value != 0 && value > 0)
                {
                    _budgetInMillions = value;
                } else
                {
                    throw new Exception("Movie budget cannot be zero or less.");
                }
            }
        }
        
        //public Genres Genre { get; set; }

        private HashSet<Rating> _ratings = new HashSet<Rating>();
        private HashSet<Actor> _actors = new HashSet<Actor>();

        // === METHODS
        public HashSet<Rating> GetRatings()
        {
            return _ratings.ToHashSet();
        }

        public HashSet<Actor> GetActors()
        {
            return _actors.ToHashSet(); 
        }

        public void AddRating(Rating rating)
        {
            _ratings.Add(rating);
        }

        public void AddActor(Actor actor)
        {
            _actors.Add(actor);
        }

        // === CONSTRUCTORS
        public Movie()
        {

        }

        public Movie(int id, string title, DateTime productionDate, int budgetInMillions)
        {
            _id = id;
            Title = title;
            ProductionDate = productionDate;    
            BudgetInMillions = budgetInMillions;
        }
    }
}
