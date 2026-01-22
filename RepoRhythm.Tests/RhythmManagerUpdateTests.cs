using RepoRhythm.Lib.Models;

namespace RepoRhythm.Tests;

public class RhythmManagerUpdateTests
{
    [Fact]
    public void Update_WithValidId_UpdatesKeyAndReturnsTrue()
    {
        var manager = new RhythmManager();
        var rhythm = manager.Create("Jazz", 4, "C", 180);
        
        var result = manager.Update(rhythm.Id, "Dm");
        
        Assert.True(result);
        Assert.Equal("Dm", rhythm.Key);
    }

    [Fact]
    public void Update_WithInvalidId_ReturnsFalse()
    {
        var manager = new RhythmManager();
        manager.Create("Blues", 4, "G", 200);
        
        var result = manager.Update("invalid-id", "Am");
        
        Assert.False(result);
    }

    [Fact]
    public void Update_WithNullKey_UpdatesKeyToNull()
    {
        var manager = new RhythmManager();
        var rhythm = manager.Create("Rock", 4, "E", 240);
        
        var result = manager.Update(rhythm.Id, null!);
        
        Assert.True(result);
        Assert.Null(rhythm.Key);
    }

    [Fact]
    public void Update_DoesNotAffectOtherProperties()
    {
        var manager = new RhythmManager();
        var rhythm = manager.Create("Funk", 4, "F", 160);
        var originalName = rhythm.Name;
        var originalBeat = rhythm.Beat;
        var originalDuration = rhythm.Duration;
        var originalCreatedAt = rhythm.CreatedAt;
        
        manager.Update(rhythm.Id, "G#");
        
        Assert.Equal(originalName, rhythm.Name);
        Assert.Equal(originalBeat, rhythm.Beat);
        Assert.Equal(originalDuration, rhythm.Duration);
        Assert.Equal(originalCreatedAt, rhythm.CreatedAt);
        Assert.Equal("G#", rhythm.Key);
    }

    [Fact]
    public void Update_WithMultipleRhythms_UpdatesOnlyTheSpecifiedOne()
    {
        var manager = new RhythmManager();
        var rhythm1 = manager.Create("Salsa", 4, "C", 120);
        var rhythm2 = manager.Create("Tango", 4, "D", 130);
        var rhythm3 = manager.Create("Waltz", 3, "E", 140);
        
        var result = manager.Update(rhythm2.Id, "F#");
        
        Assert.True(result);
        Assert.Equal("C", rhythm1.Key);
        Assert.Equal("F#", rhythm2.Key);
        Assert.Equal("E", rhythm3.Key);
    }
}
