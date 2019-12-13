namespace CustomTasks.Endpoint
{
    /// <summary>
    /// Implementation of a file system layer using System.IO
    /// </summary>
    public class FileSystem : IFileSystem
    {
        public string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public void WriteAllText(string path, string contents)
        {
            System.IO.File.WriteAllText(path, contents);
        }

        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            System.IO.File.Copy(sourceFileName, destFileName, overwrite);
        }
    }
}
