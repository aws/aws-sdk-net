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

        public bool Exists(string path)
        {
            return Files.Keys.Contains(path);
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
            // no op
            return null;
        }

        public void Delete(string path)
        {
            Files.Remove(path);
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