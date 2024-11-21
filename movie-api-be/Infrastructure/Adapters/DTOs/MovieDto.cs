using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace movie_api_be.Infrastructure.Adapters.DTOs
{
  public class MovieDto
  {
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("year")]
    public int Year { get; set; }

    [JsonPropertyName("genre")]
    public List<string> Genres { get; set; }

    [JsonPropertyName("director")]
    public string Director { get; set; }

    [JsonPropertyName("actors")]
    public List<string> Actors { get; set; }

    [JsonPropertyName("rating")]
    public decimal Rating { get; set; }
  }

  public class MoviesDto
  {
    [JsonPropertyName("movies")]
    public List<MovieDto> Movies { get; set; }
  }
}