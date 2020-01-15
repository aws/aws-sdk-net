namespace CustomTasks.Endpoint
{
    /// <summary>
    /// Abstraction layer to a file system.
    /// </summary>
    public interface IFileSystem
    {
        string ReadAllText(string path);

        void WriteAllText(string path, string contents);

        void Copy(string sourceFileName, string destFileName, bool overwrite);
    }
}
