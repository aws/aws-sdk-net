using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Util.Internal;

namespace AWSSDK.UnitTests
{
    public class MockFileSystem : IFile, IDirectory
    {
        /// <summary>
        /// Collection of files that exist in the mock file system.
        /// Key: Path,
        /// Value: File contents
        /// </summary>
        public Dictionary<string, string> Files { get; set; } =
            new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        /// <summary>
        /// Tracks paths that had SetFileOwnerReadWrite called on them.
        /// </summary>
        public List<string> FileOwnerReadWritePaths { get; } = new List<string>();

        /// <summary>
        /// Tracks paths that had SetDirectoryOwnerOnly called on them.
        /// </summary>
        public List<string> DirectoryOwnerOnlyPaths { get; } = new List<string>();

        /// <summary>
        /// Tracks directories that have been created.
        /// </summary>
        public HashSet<string> Directories { get; } = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);

        bool IFile.Exists(string path)
        {
            return Files.Keys.Contains(path);
        }

        bool IDirectory.Exists(string path)
        {
            return Directories.Contains(path);
        }

        public string ReadAllText(string path)
        {
            return Files[path];
        }

        public void WriteAllText(string path, string contents)
        {
            Files[path] = contents;
        }

        public Task<string> ReadAllTextAsync(string path, CancellationToken token = default)
        {
            return Task.FromResult(ReadAllText(path));
        }

        public Task WriteAllTextAsync(string path, string contents, CancellationToken token = default)
        {
            WriteAllText(path, contents);

            return Task.FromResult(0);
        }

        public DirectoryInfo CreateDirectory(string path)
        {
            Directories.Add(path);
            return null;
        }

        void IFile.Delete(string path)
        {
            Files.Remove(path);
        }

        public void SetFileOwnerReadWrite(string path)
        {
            FileOwnerReadWritePaths.Add(path);
        }

        void IDirectory.Delete(string path)
        {
            Directories.Remove(path);
        }

        public void SetDirectoryOwnerOnly(string path)
        {
            DirectoryOwnerOnlyPaths.Add(path);
        }

        public string[] GetFiles(string path, string searchPattern)
        {
            // build regex from glob pattern.
            string regexGlob = $"^{Regex.Escape(searchPattern).Replace(@"\*", ".*").Replace(@"\?", ".")}$";
            return Files.Keys.Where(p => p.StartsWith(path, StringComparison.InvariantCultureIgnoreCase)
                                        && Regex.IsMatch(p, regexGlob)).ToArray();
        }
    }
}