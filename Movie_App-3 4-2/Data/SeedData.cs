using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieApp.Data;
using System;
using System.Linq;

namespace MovieApp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "The Shawshank Redemption",
                        Director = "Frank Darabont",
                        Genre = "Drama",
                        Year = 1994,
                        Poster = "/images/shawshank.jpg",
                        Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."
                    },
                    new Movie
                    {
                        Title = "The Godfather",
                        Director = "Francis Ford Coppola",
                        Genre = "Crime",
                        Year = 1972,
                        Poster = "/images/godfather.jpg",
                        Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        Director = "Christopher Nolan",
                        Genre = "Action",
                        Year = 2008,
                        Poster = "/images/dark_knight.jpg",
                        Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham."
                    },
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        Director = "Quentin Tarantino",
                        Genre = "Crime",
                        Year = 1994,
                        Poster = "/images/pulp_fiction.jpg",
                        Description = "The lives of two mob hitmen, a boxer, a gangster, and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption."
                    },
                    new Movie
                    {
                        Title = "Schindler's List",
                        Director = "Steven Spielberg",
                        Genre = "Biography",
                        Year = 1993,
                        Poster = "/images/schindlers_list.jpg",
                        Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis."
                    },
                    new Movie
                    {
                        Title = "The Lord of the Rings: The Return of the King",
                        Director = "Peter Jackson",
                        Genre = "Adventure",
                        Year = 2003,
                        Poster = "/images/lotr_return_of_the_king.jpg",
                        Description = "Gandalf and Aragorn lead the World of Men against Sauron's army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring."
                    },
                    new Movie
                    {
                        Title = "Fight Club",
                        Director = "David Fincher",
                        Genre = "Drama",
                        Year = 1999,
                        Poster = "/images/fight_club.jpg",
                        Description = "An insomniac office worker and a devil-may-care soap maker form an underground fight club that evolves into something much, much more."
                    },
                    new Movie
                    {
                        Title = "Forrest Gump",
                        Director = "Robert Zemeckis",
                        Genre = "Drama",
                        Year = 1994,
                        Poster = "/images/forrest_gump.jpg",
                        Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal, and other historical events unfold from the perspective of an Alabama man with an IQ of 75."
                    },
                    new Movie
                    {
                        Title = "Inception",
                        Director = "Christopher Nolan",
                        Genre = "Sci-Fi",
                        Year = 2010,
                        Poster = "/images/inception.jpg",
                        Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O."
                    },
                    new Movie
                    {
                        Title = "The Matrix",
                        Director = "Lana Wachowski, Lilly Wachowski",
                        Genre = "Sci-Fi",
                        Year = 1999,
                        Poster = "/images/matrix.jpg",
                        Description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}