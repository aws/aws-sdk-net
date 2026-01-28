/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.IO;
using System.Security.Cryptography;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Handles atomic file operations for multipart downloads using SEP-compliant temporary file pattern.
    /// Creates .s3tmp.{uniqueId} files and ensures atomic commits to prevent partial file corruption.
    /// </summary>
    internal class AtomicFileHandler : IDisposable
    {
        private string _tempFilePath;
        private bool _disposed = false;
        private static readonly object _fileLock = new object();

        /// <summary>
        /// Creates a temporary file with unique identifier for atomic operations.
        /// Pattern: {destinationPath}.s3tmp.{8-char-unique-id}
        /// Uses FileMode.CreateNew for atomic file creation (no race condition).
        /// </summary>
        public string CreateTemporaryFile(string destinationPath)
        {
            if (string.IsNullOrEmpty(destinationPath))
                throw new ArgumentException("Destination path cannot be null or empty", nameof(destinationPath));

            // Create directory if it doesn't exist (Directory.CreateDirectory is idempotent)
            var directory = Path.GetDirectoryName(destinationPath);
            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Try up to 100 times to create unique file atomically
            for (int attempt = 0; attempt < 100; attempt++)
            {
                var uniqueId = GenerateRandomId(8);
                var tempPath = $"{destinationPath}.s3tmp.{uniqueId}";
                
                try
                {
                    // FileMode.CreateNew fails atomically if file exists - no race condition
                    using (var stream = new FileStream(tempPath, FileMode.CreateNew, FileAccess.Write))
                    {
                        // File created successfully - immediately close it
                    }
                    
                    _tempFilePath = tempPath;
                    return tempPath;
                }
                catch (IOException)
                {
                    lock (_fileLock)
                    {
                        // If the file now exists when we check immediately after the exception, 
                        // it means another process or thread beat us to the creation (race condition).
                        if (File.Exists(tempPath))
                        {
                            // File exists, try again with new ID
                            continue;
                        }
                        else
                        {
                            // The file does *not* exist, which means the IOException was caused by 
                            // something else entirely (e.g., permissions, disk full, network error).
                            throw; // Re-throw the original exception as it was an unexpected error.
                        }
                    }
                }
            }
            
            throw new InvalidOperationException("Unable to generate unique temporary file name after 100 attempts");
        }

        /// <summary>
        /// Atomically commits the temporary file to the final destination.
        /// Uses File.Replace for atomic replacement when destination exists, or File.Move for new files.
        /// This prevents data loss if the process crashes during commit.
        /// </summary>
        public void CommitFile(string tempPath, string destinationPath)
        {
            if (string.IsNullOrEmpty(tempPath))
                throw new ArgumentException("Temp path cannot be null or empty", nameof(tempPath));
            if (string.IsNullOrEmpty(destinationPath))
                throw new ArgumentException("Destination path cannot be null or empty", nameof(destinationPath));
            
            if (!File.Exists(tempPath))
                throw new FileNotFoundException($"Temporary file not found: {tempPath}");

            try
            {
                // Use File.Replace for atomic replacement when overwriting existing file
                // This prevents data loss if process crashes between delete and move operations
                // File.Replace is atomic on Windows (ReplaceFile API) and Unix (rename syscall)
                if (File.Exists(destinationPath))
                {
                    File.Replace(tempPath, destinationPath, null);
                }
                else
                {
                    // For new files, File.Move is sufficient and atomic on same volume
                    File.Move(tempPath, destinationPath);
                }

                if (_tempFilePath == tempPath)
                    _tempFilePath = null; // Successfully committed
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to commit temporary file {tempPath} to {destinationPath}", ex);
            }
        }

        /// <summary>
        /// Cleans up temporary file in case of failure or cancellation.
        /// Safe to call multiple times - File.Delete() is idempotent (no-op if file doesn't exist).
        /// </summary>
        public void CleanupOnFailure(string tempPath = null)
        {
            var pathToClean = string.IsNullOrEmpty(tempPath) ? _tempFilePath : tempPath;

            if (string.IsNullOrEmpty(pathToClean))
                return;

            try
            {
                // File.Delete() is idempotent - doesn't throw if file doesn't exist
                File.Delete(pathToClean);

                if (_tempFilePath == pathToClean)
                    _tempFilePath = null;
            }
            catch (IOException)
            {
                // Log warning but don't throw - cleanup is best effort
                // In production, this would use proper logging infrastructure
            }
            catch (UnauthorizedAccessException)
            {
                // Log warning but don't throw - cleanup is best effort
            }
        }

        /// <summary>
        /// Generates a cryptographically secure random  identifier of specified length.
        /// Uses base32 encoding to avoid filesystem-problematic characters.
        /// </summary>
        private string GenerateRandomId(int length)
        {
            const string base32Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567"; // RFC 4648 base32
            
            using (var rng = RandomNumberGenerator.Create())
            {
                var bytes = new byte[length];
                rng.GetBytes(bytes);
                
                var result = new char[length];
                for (int i = 0; i < length; i++)
                {
                    result[i] = base32Chars[bytes[i] % base32Chars.Length];
                }
                
                return new string(result);
            }
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                // Cleanup any remaining temp file
                CleanupOnFailure();
                _disposed = true;
            }
        }
    }
}
