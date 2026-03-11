using System;
using System.IO;

namespace Amazon.S3.Util
{
    internal static class FileSystemHelper
    {
        /// <summary>
        /// Determines if the specified directory path is case-sensitive.
        /// </summary>
        /// <param name="directoryPath">The full path to the directory to check.</param>
        /// <remarks>
        /// Case-sensitivity can vary by directory or volume depending on the platform and configuration:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// On Windows, NTFS is case-preserving but usually case-insensitive; however, case-sensitivity
        /// can be enabled per-directory (for example via WSL tooling), so two directories on the same
        /// volume may behave differently.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// On Unix-like systems and macOS, different mount points or volumes can have different
        /// case-sensitivity semantics.
        /// </description>
        /// </item>
        /// </list>
        /// Because of this, the check is performed against the actual target directory instead of a
        /// global temporary location. This ensures we detect collisions (such as S3 keys that differ
        /// only by case) according to the behavior of the specific filesystem where we will create files.
        /// </remarks>
        /// <returns>
        /// True if the file system at the path is case-sensitive; False if case-insensitive.
        /// </returns>
        /// <exception cref="ArgumentNullException">If the directoryPath is null or empty.</exception>
        /// <exception cref="DirectoryNotFoundException">If the directory does not exist.</exception>
        public static bool IsDirectoryCaseSensitive(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
            {
                throw new ArgumentNullException(nameof(directoryPath));
            }

            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"The directory '{directoryPath}' does not exist.");
            }

#pragma warning disable CA1308 // Normalize strings to uppercase
            string tempFileLower = Path.Combine(directoryPath, Guid.NewGuid().ToString().ToLowerInvariant() + ".tmp");
#pragma warning restore CA1308 // Normalize strings to uppercase
            string tempFileUpper = Path.Combine(directoryPath, Path.GetFileName(tempFileLower).ToUpperInvariant());
            bool isCaseSensitive = true; // Assume sensitive by default

#pragma warning disable CA1031 // Do not catch general exception types
            try
            {
                // Create the file with a lowercase name
                using (File.Create(tempFileLower)) { }

                // Check if the uppercase version of the file exists.
                // If it does, the file system is case-insensitive.
                if (File.Exists(tempFileUpper))
                {
                    isCaseSensitive = false;
                }
            }
            catch (Exception)
            {
                // Fallback assumption is that the file system is case-sensitive
                isCaseSensitive = true;
            }
            finally
            {
                try
                {
                    // Ensure temporary files are cleaned up in all cases
                    if (File.Exists(tempFileLower)) File.Delete(tempFileLower);
                    if (File.Exists(tempFileUpper)) File.Delete(tempFileUpper);
                }
                catch (Exception) { }
            }
#pragma warning restore CA1031 // Do not catch general exception types

            return isCaseSensitive;
        }
    }
}
