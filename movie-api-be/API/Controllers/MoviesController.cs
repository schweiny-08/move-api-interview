using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using movie_api_be.Application.Services;

namespace movie_api_be.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MoviesController : ControllerBase
  {
    private readonly MovieService _movieService;

    public MoviesController(MovieService movieService)
    {
      _movieService = movieService;
    }

    [HttpGet]
    public async Task<IActionResult> GetMovies([FromQuery] string? genres, [FromQuery] string? title)
    {
      var movies = await _movieService.GetAllMoviesAsync(genres, title);
      return Ok(movies);
    }
  }
}