using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using movie_api_be.Application.Ports;
using movie_api_be.Domain.Models;
using movie_api_be.Infrastructure.Adapters.DTOs;
using static System.Net.Mime.MediaTypeNames;

namespace movie_api_be.Infrastructure.Adapters
{
  public class MovieRepository : IMovieRepository
  {
    private readonly string _filePath;
    public MovieRepository(string filePath)
    {
      _filePath = filePath;
    }
    public async Task<IEnumerable<Movie>> GetAllMoviesAsync(List<string>? genres, string? title)
    {

      var jsonMovieData = await File.ReadAllTextAsync(_filePath);

      var movieData = JsonSerializer.Deserialize<MoviesDto>(jsonMovieData)?.Movies;

      var moveList = movieData?.Select(
          m => new Movie(
                  m.Title,
                  m.Year,
                  m.Genres.Select(g => new Genre(g)).ToList(),
                  new Director(m.Director),
                  m.Actors.Select(a => new Actor(a)).ToList(),
                  m.Rating
              )
      );

      if (!string.IsNullOrWhiteSpace(title)) { 
        moveList = moveList?.Where(m => m.MatchesTitle(title));
      }

      if (genres != null && genres.Count > 0) { 
        moveList = moveList?.Where(m => m.MatchesGenre(genres));
      }

      return moveList;
    }
  }
}