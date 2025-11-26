using System.Text.Json;

namespace NSW.StarCitizen.API.Helpers
{
    internal class JsonHelper
    {
        public static TData? GetFromFile<TData>(string filePath) where TData : class
        {
            if (!File.Exists(filePath))
                return default;
            try
            {
                using FileStream openStream = File.OpenRead(filePath);
                return JsonSerializer.Deserialize<TData>(openStream);
            }
            catch
            {
                return default;
            }
        }
    }
}
