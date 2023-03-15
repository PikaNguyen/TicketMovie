using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Models;

namespace TicketMovie.Data.Services
{
    public class MovieService : IMovieService
    {
        public readonly ApplicationDbContext _context;
        public MovieService(ApplicationDbContext context)
        {
            _context = context;

        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
           var result = _context.Movies.FirstOrDefault(x => x.Id == id);
            _context.Remove(result);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
           var result = _context.Movies.ToList();
            return result;
        }

        public Movie Update(int id, Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
            return movie;
        }
    }
}
