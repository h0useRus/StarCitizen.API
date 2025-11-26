using NSW.StarCitizen.API.FileSystem.Psysical.Abstractions;
using NSW.StarCitizen.API.Helpers;

namespace NSW.StarCitizen.API.FileSystem.Psysical
{
    /// <summary>
    /// Represents the Star Citizen build manifest file containing metadata about a specific build, such as branch, build identifiers,
    /// configuration, and version information.
    /// </summary>
    /// <param name="rootPath">The root file system path to the build manifest file. Must not be null or empty.</param>
    public class BuildManifest(string rootPath) : JsonFile<BuildManifest>(Path.Combine(rootPath, FileName))
    {
        /// <summary>
        /// The build manifest file name
        /// </summary>
        public const string FileName = "build_manifest.id";
        /// <summary>
        /// The Branch (usually same as server version).
        /// </summary>
        public string Branch { get; set; } = string.Empty;
        /// <summary>
        /// The release date.
        /// </summary>
        public string BuildDateStamp { get; set; } = string.Empty;
        /// <summary>
        /// The build Id.
        /// </summary>
        public string BuildId { get; set; } = string.Empty;
        /// <summary>
        /// The release time
        /// </summary>
        public string BuildTimeStamp { get; set; } = string.Empty;
        /// <summary>
        /// The build config
        /// </summary>
        public string Config { get; set; } = string.Empty;
        /// <summary>
        /// The build platfrom (PC)
        /// </summary>
        public string Platform { get; set; } = string.Empty;
        /// <summary>
        /// The internal repository chnage number
        /// </summary>
        public string RequestedP4ChangeNum { get; set; } = string.Empty;
        /// <summary>
        /// The internal repository shelved chnage
        /// </summary>
        public string Shelved_Change { get; set; } = string.Empty;
        /// <summary>
        /// Build tag (public)
        /// </summary>
        public string Tag { get; set; } = string.Empty;
        /// <summary>
        /// The executable version
        /// </summary>
        public Version Version { get; set; } = new Version();
        /// <summary>
        /// Load from file.
        /// </summary>
        /// <param name="path">The directory path.</param>
        /// <returns>Return deserialized <see cref="BuildManifest"/> or <see cref="Default"/>.</returns>
        public override BuildManifest? Load()
           => IsPathValid
                ? JsonHelper.GetFromFile<BuildManifestRaw>(EntryPath)?.Data
                : null;

        internal record BuildManifestRaw(BuildManifest Data);
    }
}
