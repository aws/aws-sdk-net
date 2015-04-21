using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDKDocGenerator
{
    public abstract class FileUtilties
    {
        /// <summary>
        /// Copies one folder's content to another, optionally recursing the source hierarchy.
        /// </summary>
        /// <param name="sourceFolder">The source path to copy content from.</param>
        /// <param name="destinationFolder">The target folder to receive the content. It will be created if it does not exist.</param>
        /// <param name="recurse">True to recurse the source to copy the entire hierarchy.</param>
        public static void FolderCopy(string sourceFolder, string destinationFolder, bool recurse)
        {
            var dir = new DirectoryInfo(sourceFolder);
            var dirs = dir.GetDirectories();

            if (!dir.Exists)
                throw new DirectoryNotFoundException("Source directory does not exist or could not be found: " + sourceFolder);

            if (!Directory.Exists(destinationFolder))
                Directory.CreateDirectory(destinationFolder);

            // Get the files in the directory and copy them to the new location.
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                var temppath = Path.Combine(destinationFolder, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (recurse)
            {
                foreach (var subdir in dirs)
                {
                    var temppath = Path.Combine(destinationFolder, subdir.Name);
                    FolderCopy(subdir.FullName, temppath, true);
                }
            }
        }

        /// <summary>
        /// Removes all files in the specified folder. If the recurse option
        /// is set the entire folder tree is removed.
        /// </summary>
        /// <param name="folder">The folder to clean.</param>
        /// <param name="recurse">If true, </param>
        public static void CleanFolder(string folder, bool recurse)
        {
            if (!Directory.Exists(folder))
                return;

            if (recurse)
            {
                Directory.Delete(folder, true);
                return;
            }

            var files = Directory.GetFiles(folder);
            foreach (var f in files)
            {
                File.Delete(f);                
            }
        }
    }
}
