using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Models;

namespace TicketMovie.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "",
                            Discription="This is the discription of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "",
                            Discription="This is the discription of the cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "",
                            Discription="This is the discription of the cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            Name = "Actor 1",
                            Bio = "Bio of Actor",
                            ProfilePictureUrl=""
                        },
                        new Actor()
                        {
                            Name = "Actor 2",
                            Bio = "Bio of Actor",
                            ProfilePictureUrl=""
                        },
                        new Actor()
                        {
                            Name = "Actor 3",
                            Bio = "Bio of Actor",
                            ProfilePictureUrl=""
                        },
                    });
                    context.SaveChanges();
                }
                //producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            Name = "Producer 1",
                            Bio = "Bio of Producer",
                            ProfilePictureUrl=""
                        },
                        new Producer()
                        {
                            Name = "Producer 2",
                            Bio = "Bio of Producer",
                            ProfilePictureUrl=""
                        },
                        new Producer()
                        {
                            Name = "Producer 3",
                            Bio = "Bio of Producer",
                            ProfilePictureUrl=""
                        },
                    });
                    context.SaveChanges();
                }
                //movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Mat biec",
                            Discription="Discription",
                            Price = 70000,
                            ImageUrl="",
                            StartDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Drama,
                        },
                        new Movie()
                        {
                            Name = "Doraemon",
                            Discription="Discription",
                            Price = 50000,
                            ImageUrl="",
                            StartDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Cartoon,
                        },
                        new Movie()
                        {
                            Name = "Marvel Infinity",
                            Discription="Discription",
                            Price = 120000,
                            ImageUrl="",
                            StartDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action,
                        },
                        new Movie()
                        {
                            Name = "Spiderman",
                            Discription="Discription",
                            Price = 100000,
                            ImageUrl="",
                            StartDate= DateTime.Now.AddDays(-10),
                            EndDate= DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Action,
                        },
                    });
                    context.SaveChanges();

                }
                //actors and movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId=1,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId=2,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId=3,
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId=3,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
