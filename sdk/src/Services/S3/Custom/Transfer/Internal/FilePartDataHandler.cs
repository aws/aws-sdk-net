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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Writes downloaded parts directly to a file at specific offsets.
    /// Supports concurrent writes from multiple parts for true parallel download to disk.
    /// Uses temporary files with atomic commit for SEP compliance.
    /// See <see cref="IPartDataHandler"/> for the contract this class implements.
    /// </summary>
    internal class FilePartDataHandler : IPartDataHandler
    {
        private readonly FileDownloadConfiguration _config;
        private readonly AtomicFileHandler _fileHandler;
        private string _tempFilePath;
        private bool _disposed = false;

        private readonly Logger _logger = Logger.GetLogger(typeof(FilePartDataHandler));

        /// <summary>
        /// Initializes a new instance for file downloads.
        /// Writes parts directly to disk without memory buffering.
        /// </summary>
        public FilePartDataHandler(FileDownloadConfiguration config)
        {
            _config = config ?? throw new ArgumentNullException(nameof(config));
            _fileHandler = new AtomicFileHandler();
        }

        /// <inheritdoc/>
        public Task PrepareAsync(DownloadDiscoveryResult discoveryResult, CancellationToken cancellationToken)
        {
            // Create temporary file once during preparation phase
            _tempFilePath = _fileHandler.CreateTemporaryFile(_config.DestinationFilePath);
            
            _logger.DebugFormat("FilePartDataHandler: Created temporary file for download");
            
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        /// <remarks>
        /// <para><strong>Response Ownership:</strong></para>
        /// <para>
        /// This method takes ownership of the response and is responsible for disposing it in ALL cases,
        /// including error scenarios. Callers must NOT dispose the response after calling this method.
        /// </para>
        /// </remarks>
        public async Task ProcessPartAsync(
            int partNumber,
            GetObjectResponse response,
            CancellationToken cancellationToken)
        {
            try
            {
                _logger.DebugFormat("FilePartDataHandler: [Part {0}] Starting to process part - ContentLength={1}",
                    partNumber, response.ContentLength);

                // Calculate offset for this part based on ContentRange or part number
                long offset = GetPartOffset(response, partNumber);

                _logger.DebugFormat("FilePartDataHandler: [Part {0}] Calculated file offset={1}",
                    partNumber, offset);

                // Write part data to file at the calculated offset
                await WritePartToFileAsync(offset, response, cancellationToken)
                    .ConfigureAwait(false);

                _logger.DebugFormat("FilePartDataHandler: [Part {0}] File write completed successfully",
                    partNumber);
            }
            finally
            {
                // Always dispose response after writing to disk (success or failure)
                // This releases the HTTP connection back to the pool
                response?.Dispose();
            }
        }

        /// <inheritdoc/>
        public Task WaitForCapacityAsync(CancellationToken cancellationToken)
        {
            // No-op: FilePartDataHandler writes directly to disk without buffering parts in memory.
            // Memory throttling is only needed for BufferedPartDataHandler which keeps parts in memory.
            return Task.CompletedTask;
        }

        /// <inheritdoc/>
        public void ReleaseCapacity()
        {
            // No-op: FilePartDataHandler writes directly to disk without buffering parts in memory.
            // Memory throttling is only needed for BufferedPartDataHandler which keeps parts in memory.
        }

        /// <inheritdoc/>
        public void OnDownloadComplete(Exception exception)
        {
            if (exception == null)
            {
                // Success - commit temp file to final destination
                _logger.DebugFormat("FilePartDataHandler: Download complete, committing temporary file to destination");
                
                try
                {
                    _fileHandler.CommitFile(_tempFilePath, _config.DestinationFilePath);
                    
                    _logger.DebugFormat("FilePartDataHandler: Successfully committed file to destination");
                }
                catch (Exception commitException)
                {
                    _logger.Error(commitException, "FilePartDataHandler: Failed to commit file to destination");
                    
                    // Cleanup on commit failure
                    _fileHandler.CleanupOnFailure();
                    throw new InvalidOperationException(
                        "Failed to commit downloaded file to final destination", commitException);
                }
            }
            else
            {
                // Failure - cleanup temp file
                _logger.Error(exception, "FilePartDataHandler: Download failed, cleaning up temporary file");
                
                _fileHandler.CleanupOnFailure();
            }
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (!_disposed)
            {
                _fileHandler?.Dispose();
                _disposed = true;
            }
        }

        /// <summary>
        /// Gets the file offset for writing a part based on the <see cref="GetObjectResponse.ContentRange"/> header.
        /// </summary>
        private long GetPartOffset(GetObjectResponse response, int partNumber)
        {
            // Parse offset from ContentRange header (works for both PART and RANGE strategies)
            if (!string.IsNullOrEmpty(response.ContentRange))
            {
                // Use centralized ContentRange parsing utility
                return ContentRangeParser.GetStartByte(response.ContentRange);
            }
            
            // For single-part downloads (especially empty objects), ContentRange may not be present
            // S3 doesn't include ContentRange for simple GET requests without range headers
            // In this case, the offset is always 0 since we're writing the entire response
            if (partNumber == 1)
            {
                return 0;
            }
            
            // ContentRange should be present for actual multipart downloads (part > 1)
            throw new InvalidOperationException(
                $"ContentRange header missing from part {partNumber} response. " +
                $"Unable to determine file write offset.");
        }

        /// <summary>
        /// Writes part data from GetObjectResponse ResponseStream to the file at the specified offset.
        /// </summary>
        private async Task WritePartToFileAsync(
            long offset,
            GetObjectResponse response,
            CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(_tempFilePath))
                throw new InvalidOperationException("Temporary file has not been created");

            _logger.DebugFormat("FilePartDataHandler: Opening file for writing at offset {0} with BufferSize={1}",
                offset, _config.BufferSize);

            // Open file with FileShare.Write to allow concurrent writes from other threads
            using (var fileStream = new FileStream(
                _tempFilePath,
                FileMode.Open,          // Open existing file
                FileAccess.Write,
                FileShare.Write,        // Allow concurrent writes to different offsets
                _config.BufferSize))
            {
                // Seek to the correct offset for this part
                fileStream.Seek(offset, SeekOrigin.Begin);

                _logger.DebugFormat("FilePartDataHandler: Writing {0} bytes to file at offset {1}",
                    response.ContentLength, offset);

                // Use GetObjectResponse's stream copy logic which includes:
                // - Progress tracking with events
                // - Size validation
                // - Buffered reading
                await response.WriteResponseStreamAsync(
                    fileStream,
                    null,
                    _config.BufferSize,
                    cancellationToken,
                    validateSize: true)
                    .ConfigureAwait(false);

                // Ensure data is written to disk
                await fileStream.FlushAsync(cancellationToken)
                    .ConfigureAwait(false);

                _logger.DebugFormat("FilePartDataHandler: Successfully wrote {0} bytes at offset {1}",
                    response.ContentLength, offset);
            }
        }
    }
}
