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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Util;

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

        private Logger Logger
        {
            get { return Logger.GetLogger(typeof(TransferUtility)); }
        }

        /// <summary>
        /// Gets the <see cref="DownloadDiscoveryResult"/> containing metadata from the initial GetObject response.
        /// Available after <see cref="InitializeAsync"/> completes successfully.
        /// </summary>
        public DownloadDiscoveryResult DiscoveryResult => _discoveryResult;

        /// <summary>
        /// Creates a new <see cref="BufferedMultipartStream"/> with dependency injection.
        /// </summary>
        /// <param name="downloadCoordinator"><see cref="IDownloadCoordinator"/> that coordinates download discovery and orchestration.</param>
        /// <param name="partBufferManager"><see cref="IPartBufferManager"/> that manages part buffer lifecycle and synchronization.</param>
        /// <param name="config"><see cref="BufferedDownloadConfiguration"/> with settings for the stream.</param>
        public BufferedMultipartStream(IDownloadCoordinator downloadCoordinator, IPartBufferManager partBufferManager, BufferedDownloadConfiguration config)
        {
            _downloadCoordinator = downloadCoordinator ?? throw new ArgumentNullException(nameof(downloadCoordinator));
            _partBufferManager = partBufferManager ?? throw new ArgumentNullException(nameof(partBufferManager));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Factory method to create <see cref="BufferedMultipartStream"/> with default dependencies.
        /// </summary>
        /// <param name="s3Client"><see cref="IAmazonS3"/> client for making requests.</param>
        /// <param name="request"><see cref="TransferUtilityOpenStreamRequest"/> with stream request parameters.</param>
        /// <param name="transferConfig"><see cref="TransferUtilityConfig"/> with transfer utility configuration.</param>
        /// <param name="requestEventHandler">Optional <see cref="RequestEventHandler"/> for user agent tracking.</param>
        /// <returns>A new <see cref="BufferedMultipartStream"/> instance.</returns>
        public static BufferedMultipartStream Create(IAmazonS3 s3Client, TransferUtilityOpenStreamRequest request, TransferUtilityConfig transferConfig, RequestEventHandler requestEventHandler = null)
        {
            if (s3Client == null) throw new ArgumentNullException(nameof(s3Client));
            if (request == null) throw new ArgumentNullException(nameof(request));
            if (transferConfig == null) throw new ArgumentNullException(nameof(transferConfig));
            
            // Determine target part size from request or use 8MB default
            long targetPartSize = request.IsSetPartSize() 
                ? request.PartSize 
                : S3Constants.DefaultPartSize;
            
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
            ThrowIfDisposed();
            
            if (_initialized)
                throw new InvalidOperationException("Stream has already been initialized");

            Logger.DebugFormat("BufferedMultipartStream: Starting initialization");

            _discoveryResult = await _downloadCoordinator.DiscoverDownloadStrategyAsync(cancellationToken)
                    .ConfigureAwait(false);
                
            Logger.DebugFormat("BufferedMultipartStream: Discovery completed - ObjectSize={0}, TotalParts={1}, IsSinglePart={2}",
                _discoveryResult.ObjectSize,
                _discoveryResult.TotalParts,
                _discoveryResult.IsSinglePart);

            await _downloadCoordinator.StartDownloadsAsync(_discoveryResult, cancellationToken)
                .ConfigureAwait(false);
            
            _initialized = true;
            Logger.DebugFormat("BufferedMultipartStream: Initialization completed successfully");
        }

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            ThrowIfDisposed();
            
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

            var currentPosition = Interlocked.Read(ref _totalBytesRead);
            Logger.DebugFormat("BufferedMultipartStream: ReadAsync called - Position={0}, RequestedBytes={1}",
                currentPosition, count);

            var bytesRead = await _partBufferManager.ReadAsync(buffer, offset, count, cancellationToken)
                .ConfigureAwait(false);
            
            // Track total bytes read for Position property
            if (bytesRead > 0)
            {
                Interlocked.Add(ref _totalBytesRead, bytesRead);
                Logger.DebugFormat("BufferedMultipartStream: ReadAsync completed - BytesRead={0}, NewPosition={1}",
                    bytesRead, currentPosition + bytesRead);
            }
            else
            {
                Logger.DebugFormat("BufferedMultipartStream: ReadAsync returned EOF (0 bytes)");
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

        private void ThrowIfDisposed()
        {
            if (_disposed)
                throw new ObjectDisposedException(nameof(BufferedMultipartStream));
        }

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
