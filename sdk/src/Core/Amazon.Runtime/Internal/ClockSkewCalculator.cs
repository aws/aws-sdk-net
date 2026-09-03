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
using System.Globalization;
using Amazon.Util;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Implements the skew computation defined by the Clock Skew Correction specification.
    ///
    /// This is the pure computation portion (no state): given the raw client
    /// send/receive timestamps and the server's <c>Date</c> response header, it
    /// produces a candidate skew using the NTP-style midpoint formula and applies
    /// the specification's discard guards (maximum trusted request duration and cache
    /// <c>Age</c> header).
    ///
    /// Persistence of the resulting skew (ClientSkew / AttemptSkew) and the
    /// retry classification live elsewhere; see <see cref="CorrectClockSkew"/> and
    /// the retry policy.
    /// </summary>
    internal static class ClockSkewCalculator
    {
        /// <summary>
        /// The minimum absolute skew value considered meaningful when deciding
        /// whether an error is clock-skew related (specification: 4 minutes).
        /// </summary>
        internal static readonly TimeSpan SkewDetectionThreshold = TimeSpan.FromMinutes(4);

        /// <summary>
        /// The longest a request may take before the skew measurement from its
        /// response is discarded as unreliable (specification: 15 minutes).
        /// </summary>
        internal static readonly TimeSpan MaxTrustedRequestDuration = TimeSpan.FromMinutes(15);

        /// <summary>
        /// Computes a candidate clock skew from a response per the Clock Skew
        /// Correction specification.
        ///
        /// <code>
        /// elapsed   = timeResponseReceived - timeRequestSent
        /// midpoint  = (timeRequestSent + timeResponseReceived) / 2
        /// candidate = serverTime - midpoint
        /// </code>
        ///
        /// The candidate is discarded (returns <c>false</c>) when:
        /// <list type="bullet">
        /// <item>the <c>Date</c> header is absent/unparseable (<paramref name="serverTimeUtc"/> is null),</item>
        /// <item><c>elapsed</c> exceeds <see cref="MaxTrustedRequestDuration"/> (15 min),</item>
        /// <item>the response carries an <c>Age</c> header (served from a cache).</item>
        /// </list>
        /// </summary>
        /// <param name="serverTimeUtc">Parsed value of the response <c>Date</c> header in UTC, or null if absent/unparseable.</param>
        /// <param name="timeRequestSentUtc">Raw (unskewed) client UTC time when the request was sent.</param>
        /// <param name="timeResponseReceivedUtc">Raw (unskewed) client UTC time when the response was received.</param>
        /// <param name="hasAgeHeader">True if the response contained an <c>Age</c> header.</param>
        /// <param name="candidateSkew">The computed candidate skew when the method returns true; otherwise <see cref="TimeSpan.Zero"/>.</param>
        /// <returns>True if a trustworthy candidate skew was produced; otherwise false.</returns>
        internal static bool TryComputeCandidateSkew(
            DateTime? serverTimeUtc,
            DateTime timeRequestSentUtc,
            DateTime timeResponseReceivedUtc,
            bool hasAgeHeader,
            out TimeSpan candidateSkew)
        {
            candidateSkew = TimeSpan.Zero;

            // No Date header (or unparseable) => no candidate.
            if (!serverTimeUtc.HasValue)
                return false;

            // Response served from a cache: the Date header does not reflect the
            // service's current time, so it MUST NOT be trusted.
            if (hasAgeHeader)
                return false;

            var elapsed = timeResponseReceivedUtc - timeRequestSentUtc;

            // A slow request makes the measurement unreliable (network delay is
            // indistinguishable from clock drift beyond this bound).
            if (elapsed > MaxTrustedRequestDuration)
                return false;

            // NTP-style midpoint: assume the server generated its Date value
            // halfway through the round trip. This bounds the worst-case
            // measurement error to elapsed / 2.
            var midpointTicks = timeRequestSentUtc.Ticks + (elapsed.Ticks / 2);
            var midpoint = new DateTime(midpointTicks, DateTimeKind.Utc);

            candidateSkew = serverTimeUtc.Value - midpoint;
            return true;
        }

        /// <summary>
        /// Attempts to parse the value of an HTTP <c>Date</c> header (RFC 1123 /
        /// GMT format) into a UTC <see cref="DateTime"/>.
        /// </summary>
        /// <param name="dateHeaderValue">The raw <c>Date</c> header value.</param>
        /// <param name="serverTimeUtc">The parsed UTC time when successful.</param>
        /// <returns>True if the header was present and parseable; otherwise false.</returns>
        internal static bool TryParseDateHeader(string dateHeaderValue, out DateTime serverTimeUtc)
        {
            if (!string.IsNullOrEmpty(dateHeaderValue) &&
                DateTime.TryParseExact(
                    dateHeaderValue,
                    AWSSDKUtils.GMTDateFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal,
                    out serverTimeUtc))
            {
                return true;
            }

            serverTimeUtc = DateTime.MinValue;
            return false;
        }
    }
}
