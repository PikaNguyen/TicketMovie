using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketMovie.Models;

namespace TicketMovie.Data.Services
{
    public interface IMovieService
    {
        IEnumerable<Movie> GetAll();
        void Add(Movie movie);
        Movie Update(int id, Movie movie);
        void Delete(int id);
    }
}
