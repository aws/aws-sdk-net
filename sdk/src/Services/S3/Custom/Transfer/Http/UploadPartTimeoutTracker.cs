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
using System.Collections.Generic;

namespace Amazon.S3.Transfer.Http
{
    /// <summary>
    /// Tracks upload part response times and derives an adaptive first-byte timeout, so a part that is
    /// statistically slow is cancelled and retried rather than stalling the whole transfer.
    /// <para>
    /// This is a port of the technique in the CRT S3 client. The motivation there: S3 typically responds
    /// to an upload in about 0.2s, but roughly 0.1% of the time takes 5s. On a large multipart upload a
    /// handful of parts hit that, and one landing near the end delays completion for everyone.
    /// </para>
    /// <para>
    /// All members are safe for concurrent use; part uploads run in parallel.
    /// </para>
    /// </summary>
    internal sealed class UploadPartTimeoutTracker
    {
        // Below this the optimization is pointless: if requests genuinely take this long, retrying is
        // slower than waiting.
        private static readonly TimeSpan UpperBound = TimeSpan.FromSeconds(5);
        private static readonly TimeSpan MinimumTimeout = TimeSpan.FromSeconds(1);

        // Measured on c5n.18xlarge for a 30 GiB upload as the offset giving the best performance.
        private static readonly TimeSpan ExpectedTimeoutOffset = TimeSpan.FromMilliseconds(700);

        private const double EwmaWeightCurrent = 0.99;
        private const double EwmaWeightNew = 0.01;

        private readonly object _lock = new object();
        private readonly int _requiredSamples;
        private readonly List<TimeSpan> _initialSamples = new List<TimeSpan>();

        private bool _disabled;
        private TimeSpan? _currentTimeout;

        private long _requestCount;
        private long _timeoutCount;
        private double _responseTimeSumMs;
        private long _responseTimeCount;

        internal UploadPartTimeoutTracker(int idealConnectionCount)
        {
            // CRT collects max(ideal_connection_count, 10) samples before it will act.
            _requiredSamples = Math.Max(idealConnectionCount, 10);
        }

        /// <summary>
        /// The timeout to apply to the next upload, or null while still sampling or once disabled.
        /// </summary>
        internal TimeSpan? CurrentTimeout
        {
            get
            {
                lock (_lock)
                {
                    return _disabled ? null : _currentTimeout;
                }
            }
        }

        internal void RecordSuccess(TimeSpan responseTime)
        {
            lock (_lock)
            {
                if (_disabled)
                    return;

                _requestCount++;
                _responseTimeSumMs += responseTime.TotalMilliseconds;
                _responseTimeCount++;

                if (_currentTimeout == null)
                {
                    _initialSamples.Add(responseTime);
                    if (_initialSamples.Count >= _requiredSamples)
                        EstablishInitialTimeout();

                    return;
                }

                // Steady state: drift the timeout toward the observed average plus the offset.
                var expectedMs = (_responseTimeSumMs / _responseTimeCount) + ExpectedTimeoutOffset.TotalMilliseconds;
                var updatedMs = (EwmaWeightCurrent * _currentTimeout.Value.TotalMilliseconds)
                              + (EwmaWeightNew * expectedMs);

                _currentTimeout = TimeSpan.FromMilliseconds(updatedMs);
                DisableIfAboveUpperBound();
            }
        }

        internal void RecordTimeout()
        {
            lock (_lock)
            {
                if (_disabled || _currentTimeout == null)
                    return;

                _requestCount++;
                _timeoutCount++;

                var timeoutRate = (double)_timeoutCount / _requestCount;

                if (timeoutRate > 0.01)
                {
                    // Timing out this often means the estimate is badly wrong. Back off hard and start
                    // the rate measurement over so the next decision is not biased by this burst.
                    _currentTimeout = _currentTimeout.Value + TimeSpan.FromSeconds(1);
                    _requestCount = 0;
                    _timeoutCount = 0;
                }
                else if (timeoutRate > 0.001)
                {
                    _currentTimeout = _currentTimeout.Value + TimeSpan.FromMilliseconds(100);
                }

                DisableIfAboveUpperBound();
            }
        }

        /// <summary>
        /// Seeds the timeout from the P90 of the sampling window, or disables the optimization outright
        /// if requests are simply slow.
        /// </summary>
        private void EstablishInitialTimeout()
        {
            var mean = TimeSpan.FromMilliseconds(_responseTimeSumMs / _responseTimeCount);
            if (mean >= UpperBound)
            {
                _disabled = true;
                return;
            }

            _initialSamples.Sort();
            var p90Index = (int)Math.Ceiling(_initialSamples.Count * 0.9) - 1;
            if (p90Index < 0)
                p90Index = 0;
            if (p90Index >= _initialSamples.Count)
                p90Index = _initialSamples.Count - 1;

            var p90 = _initialSamples[p90Index];
            _currentTimeout = p90 > MinimumTimeout ? p90 : MinimumTimeout;
            _initialSamples.Clear();

            DisableIfAboveUpperBound();
        }

        private void DisableIfAboveUpperBound()
        {
            if (_currentTimeout != null && _currentTimeout.Value > UpperBound)
                _disabled = true;
        }
    }
}
#endif
