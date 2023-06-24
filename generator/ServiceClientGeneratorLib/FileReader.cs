using System.IO;

namespace ServiceClientGenerator
{
    public interface IFileReader
    {
        /// <inheritdoc cref="File.ReadAllText(string)"/>
        string ReadAllText(string path);
    }

    public class FileReader : IFileReader
    {
        /// <inheritdoc cref="File.ReadAllText(string)"/>
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}