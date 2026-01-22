namespace RepoRhythm.Lib.Models;

/// <summary>
/// Manages Rhythm objects as a factory with CRUD and search operations.
/// </summary>
public class RhythmManager
{
    private readonly List<Rhythm> _rhythms = new();

    /// <summary>
    /// Creates a new Rhythm and adds it to the manager.
    /// </summary>
    public Rhythm Create(string name, int beat, string key, int duration)
    {
        var rhythm = new Rhythm
        {
            Name = name,
            Beat = beat,
            Key = key,
            Duration = duration
        };
        _rhythms.Add(rhythm);
        return rhythm;
    }

    /// <summary>
    /// Finds a Rhythm by its unique identifier.
    /// </summary>
    public Rhythm? FindById(string id)
    {
        return _rhythms.FirstOrDefault(r => r.Id == id);
    }

    /// <summary>
    /// Finds a Rhythm by its name (first match).
    /// </summary>
    public Rhythm? FindByName(string name)
    {
        return _rhythms.FirstOrDefault(r => r.Name == name);
    }

    /// <summary>
    /// Returns all Rhythms sorted by name in ascending order.
    /// </summary>
    public List<Rhythm> SortByName()
    {
        var r = new List<Rhythm>(_rhythms);
        if (r.Count <= 1) return r;

        string NameOf(Rhythm r) => r?.Name ?? string.Empty;

        void qs(int p1, int p2)
        {
            if (p1 >= p2) return;
            int i = p1, j = p2;
            string p = NameOf(r[(p1 + p2) / 2]);

            while (i <= j)
            {
                while (string.Compare(NameOf(r[i]), p, StringComparison.OrdinalIgnoreCase) < 0) i++;
                while (string.Compare(NameOf(r[j]), p, StringComparison.OrdinalIgnoreCase) > 0) j--;
                if (i <= j)
                {
                    var tmp = r[i];
                    r[i] = r[j];
                    r[j] = tmp;
                    i++; j--;
                }
            }

            if (p1 < j) qs(p1, j);
            if (i < p2) qs(i, p2);
        }

        qs(1, r.Count - 1);
        return r;
    }

    /// <summary>
    /// Gets all Rhythms managed by this instance.
    /// </summary>
    public IReadOnlyList<Rhythm> GetAll()
    {
        return _rhythms.AsReadOnly();
    }

    /// <summary>
    /// Removes a Rhythm by its identifier.
    /// </summary>
    public bool Remove(string id)
    {
        var rhythm = FindById(id);
        if (rhythm != null)
        {
            _rhythms.Remove(rhythm);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Clears all Rhythms from the manager.
    /// </summary>
    public void Clear()
    {
        _rhythms.Clear();
    }
}
