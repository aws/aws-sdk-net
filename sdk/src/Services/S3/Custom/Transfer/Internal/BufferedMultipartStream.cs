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
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Stream implementation for SEP-compliant multipart downloads to streams.
    /// Uses modular architecture with dependency injection for improved maintainability and testability.
    /// Supports both single-part and multipart downloads with optimal performance for each scenario.
    /// </summary>
    internal class BufferedMultipartStream : Stream
    {
        private readonly IDownloadCoordinator _downloadCoordinator;
        private readonly IPartBufferManager _partBufferManager;
        private readonly BufferedDownloadConfiguration _config;
        
        private bool _initialized = false;
        private bool _disposed = false;
        private DownloadDiscoveryResult _discoveryResult;
        private long _totalBytesRead = 0;

        /// <summary>
        /// Gets the discovery result containing metadata from the initial GetObject response.
        /// Available after InitializeAsync completes successfully.
        /// </summary>
        public DownloadDiscoveryResult DiscoveryResult => _discoveryResult;

        /// <summary>
        /// Creates a new BufferedMultipartStream with dependency injection.
        /// </summary>
        /// <param name="downloadCoordinator">Coordinates download discovery and orchestration.</param>
        /// <param name="partBufferManager">Manages part buffer lifecycle and synchronization.</param>
        /// <param name="config">Configuration settings for the stream.</param>
        public BufferedMultipartStream(IDownloadCoordinator downloadCoordinator, IPartBufferManager partBufferManager, BufferedDownloadConfiguration config)
        {
            _downloadCoordinator = downloadCoordinator ?? throw new ArgumentNullException(nameof(downloadCoordinator));
            _partBufferManager = partBufferManager ?? throw new ArgumentNullException(nameof(partBufferManager));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Factory method to create BufferedMultipartStream with default dependencies.
        /// </summary>
        /// <param name="s3Client">S3 client for making requests.</param>
        /// <param name="request">Stream request parameters.</param>
        /// <param name="transferConfig">Transfer utility configuration.</param>
        /// <param name="requestEventHandler">Optional request event handler for user agent tracking.</param>
        /// <returns>A new BufferedMultipartStream instance.</returns>
        public static BufferedMultipartStream Create(IAmazonS3 s3Client, TransferUtilityOpenStreamRequest request, TransferUtilityConfig transferConfig, RequestEventHandler requestEventHandler = null)
        {
            if (s3Client == null) throw new ArgumentNullException(nameof(s3Client));
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (transferConfig == null) throw new ArgumentNullException(nameof(transferConfig));
            
            // Determine target part size from request or use 8MB default
            long targetPartSize = request.IsSetPartSize() 
                ? request.PartSize 
                : 8 * 1024 * 1024; // 8MB default
            
            var config = new BufferedDownloadConfiguration(
                transferConfig.ConcurrentServiceRequests,
                transferConfig.MaxInMemoryParts,
                s3Client.Config.BufferSize,
                targetPartSize);
            
            var partBufferManager = new PartBufferManager(config);
            var dataHandler = new BufferedPartDataHandler(partBufferManager, config);
            var downloadCoordinator = new MultipartDownloadCoordinator(s3Client, request, config, dataHandler, requestEventHandler);
            
            return new BufferedMultipartStream(downloadCoordinator, partBufferManager, config);
        }

        /// <summary>
        /// Initialize the stream by discovering download strategy and setting up appropriate handlers.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token for the initialization operation.</param>
        public async Task InitializeAsync(CancellationToken cancellationToken)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(BufferedMultipartStream));
            
            if (_initialized)
                throw new InvalidOperationException("Stream has already been initialized");

            try
            {
                _discoveryResult = await _downloadCoordinator.DiscoverDownloadStrategyAsync(cancellationToken)
                    .ConfigureAwait(false);
                
                await _downloadCoordinator.StartDownloadsAsync(_discoveryResult, cancellationToken)
                    .ConfigureAwait(false);
                
                _initialized = true;
            }
            catch (Exception)
            {
                // Clean up on initialization failure
                throw;
            }
        }

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(BufferedMultipartStream));
            
            if (!_initialized)
                throw new InvalidOperationException("Stream must be initialized before reading. Call InitializeAsync first.");
            
            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));
            if (offset < 0)
                throw new ArgumentOutOfRangeException(nameof(offset), "Offset must be non-negative");
            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            if (offset + count > buffer.Length)
                throw new ArgumentException("Offset and count exceed buffer bounds");

            var bytesRead = await _partBufferManager.ReadAsync(buffer, offset, count, cancellationToken)
                .ConfigureAwait(false);
            
            // Track total bytes read for Position property
            if (bytesRead > 0)
            {
                Interlocked.Add(ref _totalBytesRead, bytesRead);
            }
            
            return bytesRead;
        }


        #region Stream Implementation

        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;

        public override long Length 
        { 
            get 
            {
                if (!_initialized)
                    throw new InvalidOperationException("Stream must be initialized before accessing Length");
                return _discoveryResult.ObjectSize;
            }
        }

        public override long Position 
        { 
            get 
            {
                if (!_initialized)
                    throw new InvalidOperationException("Stream must be initialized before accessing Position");
                return Interlocked.Read(ref _totalBytesRead);
            }
            set => throw new NotSupportedException("Position setter not supported for read-only streams"); 
        }

        public override void Flush() { }
        public override Task FlushAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        public override int Read(byte[] buffer, int offset, int count)
        {
            return ReadAsync(buffer, offset, count).GetAwaiter().GetResult();
        }

        public override long Seek(long offset, SeekOrigin origin) 
        {
            throw new NotSupportedException("Seek not supported for multipart download streams");
        }

        public override void SetLength(long value) 
        {
            throw new NotSupportedException("SetLength not supported for read-only streams");
        }

        public override void Write(byte[] buffer, int offset, int count) 
        {
            throw new NotSupportedException("Write not supported for read-only streams");
        }

        #endregion

        #region Dispose Pattern

        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Dispose methods should not throw exceptions")]
        protected override void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                try
                {
                    // Dispose modular dependencies
                    _downloadCoordinator?.Dispose();
                    _partBufferManager?.Dispose();
                }
                catch (Exception)
                {
                    // Suppressing CA1031: Dispose methods should not throw exceptions
                    // Continue disposal process silently on any errors
                }
                
                _disposed = true;
            }
            
            base.Dispose(disposing);
        }

        #endregion
    }
}
