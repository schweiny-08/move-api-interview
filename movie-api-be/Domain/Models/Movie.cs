namespace movie_api_be.Domain.Models
{
  public class Movie
  {
    public string Title { get; private set; }
    public int Year { get; private set; }
    public List<Genre> Genres { get; private set; }
    public Director Director { get; private set; }
    public List<Actor> Actors { get; private set; }
    public decimal Rating { get; private set; }

    public Movie(string title, int year, List<Genre> genres, Director director, List<Actor> actors, decimal rating)
    {
      Title = title;
      Year = year;
      Genres = genres;
      Director = director;
      Actors = actors;
      Rating = rating;
    }

    public bool MatchesTitle(string title) { 
      return Title.Contains(title, StringComparison.OrdinalIgnoreCase);
    }

    public bool MatchesGenre(List<string> genres) {
      return genres.All(genre => Genres.Any(domainGenre => string.Equals(domainGenre.Name, genre, StringComparison.OrdinalIgnoreCase)));
    }
  }
}

