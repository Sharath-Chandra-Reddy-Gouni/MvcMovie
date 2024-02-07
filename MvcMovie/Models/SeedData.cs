using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Salaar",
                    ReleaseDate = DateTime.Parse("2023-12-22"),
                    Genre = "Action Thriller",
                    Rating = "R",
                    Price = 12.99M
                },
                new Movie
                {
                    Title = "Hanuman",
                    ReleaseDate = DateTime.Parse("2023-01-12"),
                    Genre = "Adventure",
                    Rating = "R",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Conjuring",
                    ReleaseDate = DateTime.Parse("2013-07-19"),
                    Genre = "Horror",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Infinity Pool",
                    ReleaseDate = DateTime.Parse("2023-01-27"),
                    Genre = "Sci-Fi",
                    Rating = "R",
                    Price = 5.99M
                },
                new Movie
                {
                    Title = "Wednesday",
                    ReleaseDate = DateTime.Parse("2023-02-24"),
                    Genre = "Thriller",
                    Rating = "R",
                    Price = 8.99M
                }
            );
            context.SaveChanges();
        }
    }
}
