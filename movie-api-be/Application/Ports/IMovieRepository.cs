using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using movie_api_be.Domain.Models;

namespace movie_api_be.Application.Ports
{
    public interface IMovieRepository
    {
        Task<IEnumerable<Movie>> GetAllMoviesAsync();
    }
}