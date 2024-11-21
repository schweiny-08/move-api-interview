using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using movie_api_be.Application.Ports;
using movie_api_be.Domain.Models;
using movie_api_be.Infrastructure.Adapters.DTOs;

namespace movie_api_be.Infrastructure.Adapters
{
  public class MovieRepository : IMovieRepository
  {
    private readonly string _filePath;
    public MovieRepository(string filePath)
    {
      _filePath = filePath;
    }
    public async Task<IEnumerable<Movie>> GetAllMoviesAsync()
    {

      var jsonMovieData = await File.ReadAllTextAsync(_filePath);

      var movieList = JsonSerializer.Deserialize<MoviesDto>(jsonMovieData);

      var test = movieList.Movies;

      return test.Select(
          m => new Movie(
                  m.Title,
                  m.Year,
                  m.Genres.Select(g => new Genre(g)).ToList(),
                  new Director(m.Director),
                  m.Actors.Select(a => new Actor(a)).ToList(),
                  m.Rating
              )
      );
    }
  }
}