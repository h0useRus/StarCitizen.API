namespace NSW.StarCitizen.API.FileSystem.Psysical.Abstractions;
/// <summary>
/// Represents a file system entry on a physical file system, such as a file or directory, identified by its path.
/// </summary>
/// <param name="path">The full path to the file system entry. Cannot be null, empty, or consist only of white-space characters.</param>
public abstract class PhysicalFileSystemEntry(string path) : IFileSystemEntry
{
    /// <summary>
    /// Gets a value indicating whether the entry path is valid and exists on the file system.
    /// </summary>
    public bool IsPathValid => !string.IsNullOrWhiteSpace(EntryPath) && Path.Exists(EntryPath);
    /// <summary>
    /// Gets the relative path of the entry within the file system.
    /// </summary>
    public string EntryPath { get; init; } = path;
}
