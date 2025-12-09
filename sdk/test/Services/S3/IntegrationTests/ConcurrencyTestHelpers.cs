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
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3;
using Amazon.S3.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Thread-safe tracker for concurrent S3 GetObject requests.
    /// Used to verify ConcurrentServiceRequests and MaxInMemoryParts settings.
    /// </summary>
    public class ConcurrentRequestTracker
    {
        private int _activeRequests = 0;
        private int _peakConcurrency = 0;
        private int _totalRequests = 0;
        private readonly object _lock = new object();

        /// <summary>
        /// Increments active request count and tracks peak concurrency.
        /// </summary>
        public void IncrementActive()
        {
            var current = Interlocked.Increment(ref _activeRequests);
            Interlocked.Increment(ref _totalRequests);

            // Track peak using thread-safe compare-exchange
            int currentPeak;
            do
            {
                currentPeak = _peakConcurrency;
                if (current <= currentPeak) break;
            } while (Interlocked.CompareExchange(ref _peakConcurrency, current, currentPeak) != currentPeak);
        }

        /// <summary>
        /// Decrements active request count.
        /// </summary>
        public void DecrementActive()
        {
            Interlocked.Decrement(ref _activeRequests);
        }

        /// <summary>
        /// Gets the peak number of concurrent requests observed.
        /// </summary>
        public int PeakConcurrency => _peakConcurrency;

        /// <summary>
        /// Gets the total number of requests made.
        /// </summary>
        public int TotalRequests => _totalRequests;

        /// <summary>
        /// Gets the current number of active requests.
        /// </summary>
        public int ActiveRequests => _activeRequests;

        /// <summary>
        /// Resets all counters. Used between test runs.
        /// </summary>
        public void Reset()
        {
            lock (_lock)
            {
                _activeRequests = 0;
                _peakConcurrency = 0;
                _totalRequests = 0;
            }
        }
    }

    /// <summary>
    /// Pipeline handler that tracks concurrent GetObject requests.
    /// </summary>
    public class ConcurrencyTrackingHandler : PipelineHandler
    {
        private readonly ConcurrentRequestTracker _tracker;

        public ConcurrencyTrackingHandler(ConcurrentRequestTracker tracker)
        {
            _tracker = tracker ?? throw new ArgumentNullException(nameof(tracker));
        }

        public override async Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            // Only track GetObject requests (multipart download requests)
            if (IsGetObjectRequest(executionContext))
            {
                _tracker.IncrementActive();
                try
                {
                    return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
                }
                finally
                {
                    _tracker.DecrementActive();
                }
            }

            return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
        }

        public override void InvokeSync(IExecutionContext executionContext)
        {
            // Only track GetObject requests (multipart download requests)
            if (IsGetObjectRequest(executionContext))
            {
                _tracker.IncrementActive();
                try
                {
                    base.InvokeSync(executionContext);
                }
                finally
                {
                    _tracker.DecrementActive();
                }
            }
            else
            {
                base.InvokeSync(executionContext);
            }
        }

        private bool IsGetObjectRequest(IExecutionContext executionContext)
        {
            return executionContext.RequestContext.OriginalRequest is GetObjectRequest;
        }
    }

    /// <summary>
    /// Custom S3 client that tracks concurrent requests via pipeline handler.
    /// </summary>
    public class ConcurrencyTrackingS3Client : AmazonS3Client
    {
        // Initialize tracker as field to ensure it's available during base constructor
        public ConcurrentRequestTracker Tracker { get; } = new ConcurrentRequestTracker();

        public ConcurrencyTrackingS3Client(AmazonS3Config config) : base(config)
        {
        }

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            // Add tracking handler before HTTP handler to track all requests
            var handler = new ConcurrencyTrackingHandler(Tracker);
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.HttpHandler<Stream>>(handler);
            base.CustomizeRuntimePipeline(pipeline);
        }
    }

    /// <summary>
    /// Stream reader that throttles reading to simulate slow consumption.
    /// Used to test MaxInMemoryParts constraint behavior.
    /// </summary>
    public class ThrottledStreamReader
    {
        private readonly int _delayMilliseconds;
        private readonly int _bufferSize;

        public ThrottledStreamReader(int delayMilliseconds = 50, int bufferSize = 8192)
        {
            _delayMilliseconds = delayMilliseconds;
            _bufferSize = bufferSize;
        }

        /// <summary>
        /// Reads the entire stream with a delay between each read operation.
        /// </summary>
        public async Task<long> ReadStreamAsync(Stream stream)
        {
            var buffer = new byte[_bufferSize];
            long totalRead = 0;
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false)) > 0)
            {
                totalRead += bytesRead;
                if (_delayMilliseconds > 0)
                {
                    await Task.Delay(_delayMilliseconds).ConfigureAwait(false);
                }
            }

            return totalRead;
        }
    }

    /// <summary>
    /// Stream reader that reads as fast as possible without throttling.
    /// Used to test that fast consumption allows full concurrency.
    /// </summary>
    public class FastStreamReader
    {
        private readonly int _bufferSize;

        public FastStreamReader(int bufferSize = 1024 * 1024) // 1MB buffer for fast reading
        {
            _bufferSize = bufferSize;
        }

        /// <summary>
        /// Reads the entire stream as fast as possible.
        /// </summary>
        public async Task<long> ReadStreamAsync(Stream stream)
        {
            var buffer = new byte[_bufferSize];
            long totalRead = 0;
            int bytesRead;

            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false)) > 0)
            {
                totalRead += bytesRead;
            }

            return totalRead;
        }
    }
}
