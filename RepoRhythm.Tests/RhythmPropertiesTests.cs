using RepoRhythm.Lib.Models;

namespace RepoRhythm.Tests;

public class RhythmPropertiesTests
{
    [Fact]
    public void Properties_CanBeSet()
    {
        var rhythm = new Rhythm
        {
            Name = "Bossa Nova",
            Beat = 4,
            Key = "Dm",
            Duration = 240
        };

        Assert.Equal("Bossa Nova", rhythm.Name);
        Assert.Equal(4, rhythm.Beat);
        Assert.Equal("Dm", rhythm.Key);
        Assert.Equal(240, rhythm.Duration);
    }
}
