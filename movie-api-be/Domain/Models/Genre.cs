namespace movie_api_be.Domain.Models
{
  public class Genre
  {
    public string Name { get; set; }

    public Genre(string name)
    {
      Name = name;
    }
  }
}
