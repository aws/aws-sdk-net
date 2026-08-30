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
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Transfer.Http
{
    /// <summary>
    /// Wraps a response stream and aborts it when throughput stays below a floor for longer than a
    /// configured interval.
    /// <para>
    /// This fills the gap left by <c>ClientConfig.ReadWriteTimeout</c> existing only on .NET Framework:
    /// on .NET Core a connection that stalls mid-body has no timeout short of the whole-request timeout,
    /// so a single stuck part can hold up an entire multipart transfer. It mirrors the connection health
    /// monitor in the CRT S3 client, which kills any connection producing less than 1 B/s for 30 seconds.
    /// </para>
    /// <para>
    /// Failures surface as <see cref="IOException"/>, which the SDK retry pipeline already treats as
    /// retryable, so a stalled part is retried rather than failing the transfer.
    /// </para>
    /// </summary>
    internal sealed class ThroughputMonitoringStream : WrapperStream
    {
        private readonly long _minimumBytesPerSecond;
        private readonly TimeSpan _allowableFailureInterval;

        // Sliding sample window.
        private readonly Stopwatch _sampleTimer = Stopwatch.StartNew();
        private long _bytesInSample;

        // How long throughput has been continuously under the floor. Null means we are healthy.
        private TimeSpan? _belowFloorSince;
        private readonly Stopwatch _belowFloorTimer = new Stopwatch();

        private bool _completed;

        internal ThroughputMonitoringStream(
            Stream baseStream,
            long minimumBytesPerSecond,
            TimeSpan allowableFailureInterval)
            : base(baseStream)
        {
            _minimumBytesPerSecond = minimumBytesPerSecond;
            _allowableFailureInterval = allowableFailureInterval;
        }

        /// <summary>
        /// How long a single read may block without returning data before the stream is considered
        /// stalled. A read that hangs indefinitely would otherwise never reach a rate check.
        /// </summary>
        private TimeSpan ReadTimeoutBudget => _allowableFailureInterval;

        public override int Read(byte[] buffer, int offset, int count)
        {
            // The synchronous path cannot impose a read timeout, so it gets rate tracking only.
            var read = base.Read(buffer, offset, count);
            RecordBytes(read);
            return read;
        }

        public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            var read = await ReadWithStallTimeoutAsync(
                ct => base.ReadAsync(buffer, offset, count, ct), cancellationToken).ConfigureAwait(false);
            RecordBytes(read);
            return read;
        }

#if NET8_0_OR_GREATER
        public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
        {
            var read = await ReadWithStallTimeoutAsync(
                async ct => await BaseStream.ReadAsync(buffer, ct).ConfigureAwait(false), cancellationToken)
                .ConfigureAwait(false);
            RecordBytes(read);
            return read;
        }
#endif

        /// <summary>
        /// Runs a read under a timeout so a connection that hangs without delivering bytes is caught.
        /// The caller's own cancellation is preserved and reported as cancellation, not as a stall.
        /// </summary>
        private async Task<int> ReadWithStallTimeoutAsync(
            Func<CancellationToken, Task<int>> read,
            CancellationToken cancellationToken)
        {
            if (_completed)
                return await read(cancellationToken).ConfigureAwait(false);

            using (var timeoutSource = new CancellationTokenSource(ReadTimeoutBudget))
            using (var linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutSource.Token))
            {
                try
                {
                    return await read(linked.Token).ConfigureAwait(false);
                }
                catch (OperationCanceledException) when (timeoutSource.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
                {
                    throw new IOException(
                        $"The connection stalled: no data was received for {ReadTimeoutBudget.TotalSeconds:N0} seconds.");
                }
            }
        }

        private void RecordBytes(int read)
        {
            if (read <= 0)
            {
                // End of stream. Stop evaluating so a legitimately finished body is never faulted.
                _completed = true;
                return;
            }

            _bytesInSample += read;

            // Evaluate on a one second cadence so the rate estimate is meaningful.
            var elapsed = _sampleTimer.Elapsed;
            if (elapsed < TimeSpan.FromSeconds(1))
                return;

            var bytesPerSecond = _bytesInSample / elapsed.TotalSeconds;
            _bytesInSample = 0;
            _sampleTimer.Restart();

            if (bytesPerSecond >= _minimumBytesPerSecond)
            {
                // Healthy: reset the below-floor clock.
                _belowFloorSince = null;
                _belowFloorTimer.Reset();
                return;
            }

            if (_belowFloorSince == null)
            {
                _belowFloorSince = TimeSpan.Zero;
                _belowFloorTimer.Restart();
                return;
            }

            if (_belowFloorTimer.Elapsed >= _allowableFailureInterval)
            {
                throw new IOException(
                    $"The connection sustained less than {_minimumBytesPerSecond} bytes/second for " +
                    $"{_allowableFailureInterval.TotalSeconds:N0} seconds and was aborted.");
            }
        }
    }
}
#endif
