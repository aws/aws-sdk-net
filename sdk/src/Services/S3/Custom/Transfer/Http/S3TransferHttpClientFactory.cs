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

#if !NETFRAMEWORK
using System;
using System.Globalization;
using System.Net.Http;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.S3.Transfer.Http
{
    /// <summary>
    /// An <see cref="HttpClientFactory"/> tuned for high throughput S3 transfers.
    /// <para>
    /// The SDK's default HttpClient settings are general purpose. For bulk transfer they leave the
    /// connection pool unshaped and provide no way to recover from a connection that stalls mid-body.
    /// This factory derives the connection pool size from a throughput target and can abort and retry
    /// stalled parts, following the approach used by the CRT S3 client.
    /// </para>
    /// <example>
    /// <code>
    /// var s3 = new AmazonS3Client(new AmazonS3Config
    /// {
    ///     HttpClientFactory = new S3TransferHttpClientFactory { TargetThroughputGbps = 10 },
    ///     BufferSize = 1024 * 1024
    /// });
    /// </code>
    /// </example>
    /// <para>
    /// On .NET Framework this type is not available, because the SDK uses HttpWebRequest there rather
    /// than HttpClient.
    /// </para>
    /// </summary>
    public class S3TransferHttpClientFactory : HttpClientFactory
    {
        /// <summary>
        /// Useful throughput a single connection to S3 sustains, in gigabits per second. Taken from the
        /// CRT S3 client, which derives it as 100 Gbps across 250 connections.
        /// </summary>
        internal const double ThroughputPerConnectionGbps = 0.4;

        /// <summary>Lower bound on the connection pool, matching the CRT client's minimum.</summary>
        internal const int MinimumConnections = 10;

        /// <summary>Upper bound on the connection pool, matching the CRT client's maximum.</summary>
        internal const int MaximumConnections = 10000;

        /// <summary>
        /// Multiplier the CRT client uses to cap requests in flight relative to active connections. The
        /// headroom covers requests being prepared (read from disk, signed) but not yet on the wire.
        /// </summary>
        internal const int InFlightRequestMultiplier = 4;

        /// <summary>The SDK-wide default buffer size, below which a warning is logged at high throughput targets.</summary>
        private const int SmallBufferSizeThreshold = 8192;

        // Not static: logger configuration can change during SDK use and a static reference would not see it.
        private readonly Logger _logger = Logger.GetLogger(typeof(S3TransferHttpClientFactory));

        private double _targetThroughputGbps = 10.0;

        /// <summary>
        /// Throughput this client should be provisioned for, in gigabits per second. The connection pool
        /// is sized from this value. Defaults to 10, matching the CRT S3 client's default.
        /// <para>
        /// Set this to the throughput actually available to the host. Provisioning far above the real
        /// network capacity opens connections that cannot be kept busy.
        /// </para>
        /// </summary>
        public double TargetThroughputGbps
        {
            get { return _targetThroughputGbps; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(TargetThroughputGbps), "Must be greater than 0.");

                _targetThroughputGbps = value;
            }
        }

        /// <summary>
        /// Overrides the connection count that would otherwise be derived from
        /// <see cref="TargetThroughputGbps"/>. Null (the default) uses the derived value.
        /// </summary>
        public int? MaxConnectionsPerServer { get; set; }

        /// <summary>
        /// Enables aborting connections that stall mid-transfer so the affected part is retried.
        /// Disabled by default; enable it only after measuring, since an over-eager threshold converts
        /// working requests into retries.
        /// </summary>
        public bool EnableStallDetection { get; set; }

        /// <summary>
        /// Throughput floor, in bytes per second, below which a connection is considered stalled. Only
        /// applies when <see cref="EnableStallDetection"/> is true. Defaults to 1, matching the CRT client.
        /// </summary>
        public long MinimumThroughputBytesPerSecond { get; set; } = 1;

        /// <summary>
        /// How long throughput may stay below <see cref="MinimumThroughputBytesPerSecond"/> before the
        /// connection is aborted. Only applies when <see cref="EnableStallDetection"/> is true.
        /// Defaults to 30 seconds, matching the CRT client.
        /// </summary>
        public TimeSpan AllowableThroughputFailureInterval { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>
        /// Enables the adaptive first-byte timeout for upload parts, which cancels and retries a part
        /// that is statistically slow. Disabled by default; this is the most aggressive option here and
        /// should be enabled only after measuring, since a mis-tuned timeout increases both latency and
        /// request cost. Requires <see cref="EnableStallDetection"/>.
        /// </summary>
        public bool EnableAdaptiveUploadTimeout { get; set; }

        /// <summary>
        /// The connection count derived from <see cref="TargetThroughputGbps"/>, or the explicit
        /// <see cref="MaxConnectionsPerServer"/> override when one is set.
        /// </summary>
        public int IdealConnectionCount
        {
            get { return MaxConnectionsPerServer ?? CalculateIdealConnectionCount(TargetThroughputGbps); }
        }

        /// <summary>
        /// A value suitable for <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/>, so the
        /// transfer's part concurrency matches the size of the connection pool rather than working
        /// against it. The SDK default of 10 under-drives a pool sized for a high throughput target.
        /// </summary>
        public int RecommendedConcurrentServiceRequests
        {
            get { return IdealConnectionCount; }
        }

        /// <summary>
        /// The point beyond which additional in-flight requests cannot be serviced by the pool, using the
        /// CRT client's connections-times-four rule.
        /// </summary>
        public int MaximumInFlightRequests
        {
            get { return IdealConnectionCount * InFlightRequestMultiplier; }
        }

        /// <summary>
        /// Derives a connection count from a throughput target, clamped to the supported range.
        /// </summary>
        internal static int CalculateIdealConnectionCount(double targetThroughputGbps)
        {
            var ideal = (int)Math.Ceiling(targetThroughputGbps / ThroughputPerConnectionGbps);

            if (ideal < MinimumConnections)
                return MinimumConnections;
            if (ideal > MaximumConnections)
                return MaximumConnections;

            return ideal;
        }

        /// <inheritdoc/>
        public override HttpClient CreateHttpClient(IClientConfig clientConfig)
        {
#if NET8_0_OR_GREATER
            WarnIfBufferSizeTooSmall(clientConfig);

            // No HTTP/2 configuration here on purpose. S3's data plane speaks HTTP/1.1, so throughput
            // comes from many parallel TCP connections rather than multiplexed streams over one -- which
            // is why MaxConnectionsPerServer below is the setting that actually matters. The CRT S3
            // client makes the same choice and configures no HTTP/2 anywhere.
            var handler = new SocketsHttpHandler
            {
                MaxConnectionsPerServer = IdealConnectionCount,
                AllowAutoRedirect = clientConfig.AllowAutoRedirect,
                AutomaticDecompression = System.Net.DecompressionMethods.None
            };

            if (clientConfig.ConnectTimeout.HasValue)
                handler.ConnectTimeout = clientConfig.ConnectTimeout.Value;

            // Read from the client config rather than duplicating the knob, so there is a single source
            // of truth and non-transfer clients can use it too.
            if (clientConfig.PooledConnectionLifetime.HasValue)
                handler.PooledConnectionLifetime = clientConfig.PooledConnectionLifetime.Value;

            var proxy = clientConfig.GetWebProxy();
            if (proxy != null)
            {
                handler.Proxy = proxy;
                handler.UseProxy = true;
            }

            if (clientConfig.ProxyCredentials != null)
                handler.Credentials = clientConfig.ProxyCredentials;

            HttpMessageHandler pipeline = handler;

            if (EnableStallDetection)
            {
                var tracker = EnableAdaptiveUploadTimeout
                    ? new UploadPartTimeoutTracker(IdealConnectionCount)
                    : null;

                pipeline = new ThroughputMonitorHandler(
                    handler, MinimumThroughputBytesPerSecond, AllowableThroughputFailureInterval, tracker);
            }

            var httpClient = new HttpClient(pipeline);
#else
            // netstandard2.0 / netcoreapp3.1: the tuned SocketsHttpHandler settings this factory exists
            // for are gated on net8.0 in the SDK, so behave as a pass-through rather than pretending to
            // apply them.
            var httpClient = new HttpClient();
#endif

            if (clientConfig.Timeout.HasValue)
                httpClient.Timeout = clientConfig.Timeout.Value;

            return httpClient;
        }

        /// <summary>
        /// The copy granularity between the file and the socket is <c>ClientConfig.BufferSize</c>, which
        /// defaults to 8 KB. That is far too small to sustain a high throughput target, but this factory
        /// cannot change the client config, so warn instead of failing.
        /// </summary>
        private void WarnIfBufferSizeTooSmall(IClientConfig clientConfig)
        {
            if (clientConfig.BufferSize > SmallBufferSizeThreshold || TargetThroughputGbps < 1)
                return;

            _logger.InfoFormat(
                "S3TransferHttpClientFactory is configured for {0} Gbps but AmazonS3Config.BufferSize is {1} bytes. " +
                "This buffer sets the copy granularity between the file and the socket and will likely limit throughput. " +
                "Consider raising it to 1 MB.",
                TargetThroughputGbps.ToString(CultureInfo.InvariantCulture),
                clientConfig.BufferSize);
        }

        /// <summary>
        /// Includes this factory's settings in the cache key. Without them, two clients configured with
        /// different factories would share a single cached HttpClient and the second configuration would
        /// be silently discarded.
        /// </summary>
        public override string GetConfigUniqueString(IClientConfig clientConfig)
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "S3Transfer:Gbps:{0};Connections:{1};Stall:{2};MinBps:{3};Interval:{4};AdaptiveUpload:{5};Timeout:{6};Redirect:{7}",
                TargetThroughputGbps,
                IdealConnectionCount,
                EnableStallDetection,
                MinimumThroughputBytesPerSecond,
                AllowableThroughputFailureInterval,
                EnableAdaptiveUploadTimeout,
                clientConfig.Timeout,
                clientConfig.AllowAutoRedirect);
        }
    }
}
#endif
