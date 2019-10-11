using System.Collections.Generic;
using MoviesApp.Data;
using System.Linq;

namespace MoviesApp.Models
{
    public static class MoviesSeedData
    {
        public static void CreateSeedData(this MoviesAppContext context)
        {
            //checks if there is any movie and returns as list if there is
            if (context.Movies.Any()) 
                return;
            
            //new list of movie objects/entities that will be added to the context and will be transferred to the Movies table
            var movies = new List<Movie>()
            {
                new Movie()
                {
                    Name = "Avengers",
                    Year = 2019
                },
                new Movie()
                {
                    Name = "Thor",
                    Year = 2017
                },
                new Movie()
                {
                    Name = "Black Phanter",
                    Year = 2019
                },
                new Movie()
                {
                Name = "X-man",
                Year = 2012
                },
                new Movie()
                {
                    Name = "Supermanr",
                    Year = 2016
                }
            };
            context.AddRange(movies);
            context.SaveChanges();
        }

    }
}