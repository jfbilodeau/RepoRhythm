namespace RepoRhythm.Lib.Models;

/// <summary>
/// Represents a user in the RepoRhythm system.
/// </summary>
public class JfUser
{
    /// <summary>
    /// Gets or sets the unique identifier for the user.
    /// </summary>
    public string Identitas { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's first name (Praenomen).
    /// </summary>
    public string Praenomen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's last name (Cognomen).
    /// </summary>
    public string Cognomen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's username (Nomen).
    /// </summary>
    public string Nomen { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the collection of user roles (Officia).
    /// </summary>
    public List<string> Officia { get; set; } = new();

    /// <summary>
    /// Gets or sets the user's email address.
    /// </summary>
    public string EmailAddress { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets a value indicating whether the user is active.
    /// </summary>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Gets or sets the date the user was created.
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}
