using movie_api_be.Application.DTOS;
using movie_api_be.Application.Ports;

namespace movie_api_be.Application.Services
{
    public class MovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<IEnumerable<GetMovieResponseDto>> GetAllMoviesAsync()
        {
            var movies = await _movieRepository.GetAllMoviesAsync();

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