namespace NSW.StarCitizen.API.FileSystem.Psysical.Abstractions
{
    public abstract class JsonFile<TData>(string path) : PhysicalFileSystemEntry(path)
    {
        public abstract TData? Load();
    }
}
