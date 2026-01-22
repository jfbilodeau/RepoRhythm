using RepoRhythm.Lib.Models;

namespace RepoRhythm.Tests;

public class RhythmDefaultsTests
{
    [Fact]
    public void Constructor_SetsIdAndCreatedAt()
    {
        var rhythm = new Rhythm();

        Assert.False(string.IsNullOrWhiteSpace(rhythm.Id));
        Assert.True(Guid.TryParse(rhythm.Id, out _));

        var now = DateTime.UtcNow;
        Assert.InRange(rhythm.CreatedAt, now.AddSeconds(-2), now.AddSeconds(2));
    }
}
