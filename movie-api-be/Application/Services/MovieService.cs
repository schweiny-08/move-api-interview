using movie_api_be.Application.DTOS;
using movie_api_be.Application.Ports;
using movie_api_be.Domain.Models;

namespace movie_api_be.Application.Services
{
  public class MovieService
  {
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
      _movieRepository = movieRepository;
    }

    private IEnumerable<Genre> stringToGenres(string? genre)
    {
      var stringGenres = genre?.Split(',');

      return stringGenres.Select(sg => new Genre(sg));
    }

    public async Task<IEnumerable<GetMovieResponseDto>> GetAllMoviesAsync(string? genres, string? title)
    {
      List<string>? genreList = genres?.Split(',').ToList();

      var movies = await _movieRepository.GetAllMoviesAsync(genreList, title);

      var movieDtos = movies.Select(
          m => new GetMovieResponseDto(
              m.Title,
              m.Year,
              m.Genres.Select(g => g.Name),
              m.Director.FirstName + " " + m.Director.LastName,
              m.Actors.Select(a => a.FirstName + " " + a.LastName),
              m.Rating
          )
      );

      return movieDtos;
    }
  }
}