using NSW.StarCitizen.API.FileSystem.Psysical.Abstractions;

namespace NSW.StarCitizen.API.FileSystem.Psysical;
/// <summary>
/// Represents the Star Citizen launcher directory containing the executable file and related resources.
/// </summary>
public class Launcher : PhysicalFileSystemEntry
{
    private readonly Lazy<ExeFile> _executable;
    internal Launcher(string path) : base(path)
    {
        _executable = new Lazy<ExeFile>(() => new ExeFile(Path.Combine(EntryPath, ExecutableFileName)));
    }
    /// <summary>
    /// The default launcher folder name.
    /// </summary>
    public const string DefaultFolderName = "RSI Launcher";
    /// <summary>
    /// The executive file name
    /// </summary>
    public const string ExecutableFileName = "RSI Launcher.exe";
    /// <summary>
    /// The launcher executable file.
    /// </summary>
    public ExeFile Executable => _executable.Value;
}
