using RepoRhythm.Lib.Models;

Console.WriteLine("Starting RepoRhythm...\n");

var manager = new RhythmManager();

// Create 10 rhythms with fun names
manager.Create("Funky Groove", 4, "F", 120);
manager.Create("Jazz Waltz", 3, "Bb", 180);
manager.Create("Bossa Beat", 4, "Em", 100);
manager.Create("Rock On", 4, "D", 150);
manager.Create("Latin Fire", 4, "G", 140);
manager.Create("Smooth Soul", 4, "C", 90);
manager.Create("Reggae Vibes", 4, "A", 110);
manager.Create("Disco Fever", 4, "E", 130);
manager.Create("Pop Pulse", 4, "B", 125);
manager.Create("Electronic Dream", 4, "Am", 160);

// Sort by name and display
var sorted = manager.SortByName();

Console.WriteLine("Rhythms (sorted by name):\n");
foreach (var rhythm in sorted)
{
    Console.WriteLine($"  • {rhythm.Name,-20} | Beat: {rhythm.Beat} | Key: {rhythm.Key,2} | Duration: {rhythm.Duration}ms");
}

Console.WriteLine($"\nTotal rhythms: {manager.GetAll().Count}\n");
Console.WriteLine("Done!");