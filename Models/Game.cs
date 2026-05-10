namespace csci340lab8.Models;

public class Game
{
    public int Id { get; set; }

    public String Title { get; set; } = string.Empty;

    public String Platform { get; set; } = string.Empty;

    public string? Genre { get; set; }

    public int? HoursPlayed { get; set; }

    public DateTime? ReleaseDate { get; set; }
}