using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
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
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        ShowDate = DateTime.Parse("2020-10-3 20:20")
                    },

                    new Movie
                    {
                        Genre = "Comedy",
                        Price = 8.99M,
                        ShowDate = DateTime.Parse("2020-10-3 20:20")
                    },

                    new Movie
                    {
                        Genre = "Comedy",
                        Price = 9.99M,
                        ShowDate = DateTime.Parse("2020-10-3 20:20")
                    },

                    new Movie
                    {
                        Genre = "Western",
                        Price = 3.99M,
                        ShowDate = DateTime.Parse("2020-10-3 20:20")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}