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
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Unit tests for <see cref="ClockSkewCalculator"/>, the pure computation
    /// portion of the Clock Skew Correction specification
    /// (candidate = serverTime - timeResponseReceived, plus discard guards).
    /// Scenario values mirror the official clock-skew-test-cases.json.
    /// </summary>
    [TestClass]
    public class ClockSkewCalculatorTests
    {
        private static DateTime Utc(string iso) =>
            DateTime.Parse(iso, System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.AssumeUniversal | System.Globalization.DateTimeStyles.AdjustToUniversal);

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ClocksAgree_CandidateIsZero()
        {
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:00:02Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:02Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void FiveMinuteSkew_Yields300Seconds()
        {
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:05:02Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:02Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            Assert.AreEqual(300, candidate.TotalSeconds, 0.001);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void BelowDetectionThreshold_CandidateStillComputed()
        {
            // ~2 minutes of skew: still recorded (unconditional), but below the
            // 4-minute detection threshold so it would not trigger a skew retry.
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:02:02Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:02Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            Assert.AreEqual(120, candidate.TotalSeconds, 0.001);
            Assert.IsTrue(candidate < ClockSkewCalculator.SkewDetectionThreshold);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void StaleSkew_HealsToZeroOnAlignedResponse()
        {
            // Server clock now aligned with client; a successful response should
            // produce a zero candidate that overwrites a stale offset.
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:00:02Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:02Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void DelayedResponse_ExceedsMaxTrustedDuration_Discarded()
        {
            // Round trip of 16 minutes exceeds the 15-minute trust threshold.
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:10:00Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:16:00Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsFalse(ok);
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void CachedResponse_WithAgeHeader_Discarded()
        {
            // Date header ~4.8h in the past but Age header signals a cached response.
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T12:03:01Z"),
                timeRequestSentUtc: Utc("2026-01-01T16:51:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T16:51:02Z"),
                hasAgeHeader: true,
                out var candidate);

            Assert.IsFalse(ok);
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void NoDateHeader_Discarded()
        {
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: null,
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:02Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsFalse(ok);
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void ExactlyMaxTrustedDuration_NotDiscarded()
        {
            // elapsed == 15 min exactly is still trusted (only > 15 min is discarded).
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:15:00Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:15:00Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            // received = 00:15:00, serverTime = 00:15:00 => candidate 0
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Candidate_IsServerTimeMinusResponseReceived()
        {
            // sent=00:00:00, recv=00:00:10, serverTime 00:05:10 => candidate 300s.
            // The send time only feeds the 15-minute trust guard.
            var ok = ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: Utc("2026-01-01T00:05:10Z"),
                timeRequestSentUtc: Utc("2026-01-01T00:00:00Z"),
                timeResponseReceivedUtc: Utc("2026-01-01T00:00:10Z"),
                hasAgeHeader: false,
                out var candidate);

            Assert.IsTrue(ok);
            Assert.AreEqual(TimeSpan.FromSeconds(300), candidate);
        }

        // ---- Specification vectors: sent = T, candidate = serverTime - received ----

        private static readonly DateTime T = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static bool Compute(int receivedOffsetSeconds, int? serverOffsetSeconds, bool hasAgeHeader, out TimeSpan candidate)
        {
            return ClockSkewCalculator.TryComputeCandidateSkew(
                serverTimeUtc: serverOffsetSeconds.HasValue ? T.AddSeconds(serverOffsetSeconds.Value) : (DateTime?)null,
                timeRequestSentUtc: T,
                timeResponseReceivedUtc: T.AddSeconds(receivedOffsetSeconds),
                hasAgeHeader: hasAgeHeader,
                out candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_InSync_OneSecondRoundTrip_Zero()
        {
            Assert.IsTrue(Compute(1, 1, false, out var candidate));
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_ServerAheadOneHour()
        {
            Assert.IsTrue(Compute(2, 3602, false, out var candidate));
            Assert.AreEqual(TimeSpan.FromSeconds(3600), candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_ServerBehindOneHour()
        {
            Assert.IsTrue(Compute(2, -3598, false, out var candidate));
            Assert.AreEqual(TimeSpan.FromSeconds(-3600), candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_LongRequest620s_InSync_Zero()
        {
            // The old midpoint formula gave +310s here.
            Assert.IsTrue(Compute(620, 620, false, out var candidate));
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_LongRequest620s_Skew600()
        {
            Assert.IsTrue(Compute(620, 1220, false, out var candidate));
            Assert.AreEqual(TimeSpan.FromSeconds(600), candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_RoundTrip901s_Discarded()
        {
            Assert.IsFalse(Compute(901, 901, false, out var candidate));
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_AgeHeader_Discarded()
        {
            Assert.IsFalse(Compute(2, 3602, true, out var candidate));
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Vector_MissingDate_Discarded()
        {
            Assert.IsFalse(Compute(2, null, false, out var candidate));
            Assert.AreEqual(TimeSpan.Zero, candidate);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TryParseDateHeader_ValidGmt()
        {
            var ok = ClockSkewCalculator.TryParseDateHeader("Thu, 01 Jan 2026 00:05:01 GMT", out var serverTime);
            Assert.IsTrue(ok);
            Assert.AreEqual(Utc("2026-01-01T00:05:01Z"), serverTime);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TryParseDateHeader_MissingOrInvalid()
        {
            Assert.IsFalse(ClockSkewCalculator.TryParseDateHeader(null, out _));
            Assert.IsFalse(ClockSkewCalculator.TryParseDateHeader("", out _));
            Assert.IsFalse(ClockSkewCalculator.TryParseDateHeader("not-a-date", out _));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void Thresholds_MatchSpecification()
        {
            Assert.AreEqual(TimeSpan.FromMinutes(4), ClockSkewCalculator.SkewDetectionThreshold);
            Assert.AreEqual(TimeSpan.FromMinutes(15), ClockSkewCalculator.MaxTrustedRequestDuration);
        }
    }
}
