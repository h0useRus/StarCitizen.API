using System.Diagnostics;

namespace NSW.StarCitizen.API.FileSystem.Psysical.Abstractions
{
    public class ExeFile : PhysicalFileSystemEntry
    {
        /// <summary>
        /// An executable file version.
        /// </summary>
        public FileVersionInfo? Version { get; }
        /// <inheritdoc/>
        public ExeFile(string path) : base(path)
        {
            Version = IsPathValid ? FileVersionInfo.GetVersionInfo(path) : null;
        }
        /// <summary>
        /// Run Executable file
        /// </summary>
        /// <returns></returns>
        public int Run()
        {
            if (!IsPathValid)
                return -1;

            try
            {
                var startInfo = new ProcessStartInfo(EntryPath);
                using var process = Process.Start(startInfo);
                if (process != null)
                {
                    process.WaitForExit();

                    return process.ExitCode;
                }
                return -1;
            }
            catch
            {
                return -1;
            }
        }
    }
}
