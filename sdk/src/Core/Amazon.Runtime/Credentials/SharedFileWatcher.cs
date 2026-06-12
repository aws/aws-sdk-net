/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.IO;
using System.Threading;

namespace Amazon.Runtime.Credentials
{
    /// <summary>
    /// A shared file system watcher for a single file path. Multiple consumers may depend on the
    /// same file (e.g., <c>~/.aws/config</c>), but only one OS-level watcher is created per unique
    /// file path.
    /// <para />
    /// When a change is detected, a monotonic <see cref="ChangeToken"/> is incremented. Each
    /// consumer stores the token value it last observed; staleness is determined by comparing the
    /// stored token to the current token rather than resetting shared state. This avoids cross-entry
    /// interference when multiple consumers depend on the same file.
    /// <para />
    /// This is used both by <see cref="CachedProfileCredentialResolver"/> (for credentials resolved
    /// from a profile set on the client config) and by <see cref="DefaultAWSCredentialsIdentityResolver"/>
    /// (for static credentials resolved from a file via the default credential chain).
    /// </summary>
    internal sealed class SharedFileWatcher : IDisposable
    {
        private long _changeToken;
        private readonly FileSystemWatcher _watcher;

        /// <summary>
        /// Gets the current monotonic change token. Each file system event increments this value.
        /// Consumers compare their last-seen token against this to determine staleness.
        /// </summary>
        public long ChangeToken => Interlocked.Read(ref _changeToken);

        public SharedFileWatcher(string filePath)
        {
            _watcher = TryCreateWatcher(filePath);
        }

        private FileSystemWatcher TryCreateWatcher(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            var fileName = Path.GetFileName(filePath);

            if (string.IsNullOrEmpty(directory) || !Directory.Exists(directory))
                return null;

            try
            {
                var watcher = new FileSystemWatcher(directory, fileName)
                {
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.FileName,
                    EnableRaisingEvents = true
                };
                watcher.Changed += OnFileEvent;
                watcher.Created += OnFileEvent;
                watcher.Deleted += OnFileEvent;
                watcher.Renamed += OnFileRenamed;
                // Treat buffer overflow as a change — fail safe rather than returning stale credentials.
                watcher.Error += OnWatcherError;
                return watcher;
            }
            catch (Exception ex) when (!(ex is OutOfMemoryException))
            {
                // If we can't create a watcher (e.g., unsupported filesystem, invalid path,
                // or I/O error), return null. The cache will never auto-invalidate for this
                // file, but credentials will still be re-resolved on application restart.
                return null;
            }
        }

        private void OnFileEvent(object sender, FileSystemEventArgs e) => Interlocked.Increment(ref _changeToken);
        private void OnFileRenamed(object sender, RenamedEventArgs e) => Interlocked.Increment(ref _changeToken);
        private void OnWatcherError(object sender, ErrorEventArgs e) => Interlocked.Increment(ref _changeToken);

        public void Dispose()
        {
            _watcher?.Dispose();
        }
    }
}
