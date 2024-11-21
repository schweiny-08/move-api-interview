namespace movie_api_be.Domain.Models
{
  public class Person
  {
    public Person(string fullName)
    {
      string[] splitName = fullName.Trim().Split(' ');

      FirstName = splitName[0];
      LastName = splitName.Length > 1
            ? string.Join(" ", splitName[1..])
            : string.Empty;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
  }
}
