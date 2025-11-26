namespace NSW.StarCitizen.API.FileSystem
{
    /// <summary>
    /// Represents an entry within a file system, such as a file or directory
    /// </summary>
    internal interface IFileSystemEntry
    {
        /// <summary>
        /// Gets or sets the relative path of the entry within the file system.
        /// </summary>
        string EntryPath { get; }
        /// <summary>
        /// Gets a value indicating whether the current entry is in a valid state.
        /// </summary>
        bool IsPathValid { get; }
    }
}
