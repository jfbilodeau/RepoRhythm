namespace RepoRhythm.Lib.Models;

public class Rhythm
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Name { get; set; }
    public int Beat { get; set; }
    public string? Key { get; set; }
    public int Duration { get; set; } // in milliseconds or seconds
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
