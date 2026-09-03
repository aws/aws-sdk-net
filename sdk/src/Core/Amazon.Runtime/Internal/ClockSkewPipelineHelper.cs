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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Pipeline-side glue for the Clock Skew Correction specification. Bridges the pure
    /// <see cref="ClockSkewCalculator"/> to the request pipeline:
    ///
    /// <list type="bullet">
    /// <item>captures the send time for an attempt,</item>
    /// <item>records <c>ClientSkew</c> unconditionally from every response (success
    ///   or error) into the process-global per-endpoint store
    ///   (<see cref="CorrectClockSkew"/>) — specification "unconditional recording",</item>
    /// <item>exposes whether the latest attempt's computed skew exceeds the 4-minute
    ///   detection threshold, used by the retry policy to decide skew retries.</item>
    /// </list>
    ///
    /// <c>ClientSkew</c> is stored per endpoint in the process-global
    /// <see cref="CorrectClockSkew"/> dictionary. The specification's separate per-attempt
    /// <c>AttemptSkew</c> value is not persisted on its own: signing already re-reads the
    /// per-endpoint correction at send time (it applies <c>now() + correction</c> via
    /// <c>AWS4Signer.InitializeHeaders</c>), so a value recorded from one response is applied
    /// to the next attempt automatically and no signer change is required.
    ///
    /// Recording is gated only by clock skew correction configuration
    /// (<see cref="IsCorrectionEnabled"/>): the programmatic <c>CorrectForClockSkew</c>
    /// switch, the manual-correction override, and the disable configuration. When
    /// correction is disabled every entry point is a no-op.
    /// </summary>
    internal static class ClockSkewPipelineHelper
    {
        /// <summary>
        /// ContextAttributes key holding the latest attempt's computed candidate skew
        /// (<see cref="TimeSpan"/>) when one survived the specification guards; absent otherwise.
        /// </summary>
        internal const string AttemptSkewCandidateKey = "ClockSkewAttemptCandidate";

        /// <summary>
        /// Diagnostic emitted (at Info) when a recorded skew exceeds the detection threshold.
        /// This detailed line (local time, corrected time, server time, endpoint) has historically
        /// been decisive when debugging customer clock-skew incidents.
        /// </summary>
        private const string clockSkewIdentifiedFormat =
            "Identified clock skew: local time = {0}, local time with correction = {1}, current clock skew correction = {2}, server time = {3}, service endpoint = {4}.";

        /// <summary>
        /// Whether clock skew correction is effectively enabled, honoring the
        /// programmatic switch, the manual-correction override, and the specification disable
        /// configuration (AWS_DISABLE_CLOCK_SKEW_CORRECTION environment variable, then
        /// the disable_clock_skew_correction shared-config profile setting), resolved
        /// with env-over-profile precedence by <see cref="FallbackInternalConfigurationFactory"/>.
        /// </summary>
        internal static bool IsCorrectionEnabled(IClientConfig config)
        {
            return AWSConfigs.CorrectForClockSkew
                && !AWSConfigs.ManualClockCorrection.HasValue
                && !config.DisableClockSkewCorrection;
        }

        /// <summary>
        /// Captures the UTC send time for an attempt via <see cref="AWSSDKUtils.CorrectedUtcNow"/>,
        /// or null when correction is disabled (so callers pay nothing). Correction being enabled
        /// implies no manual clock correction is set, so this is the uncorrected machine clock.
        /// </summary>
        internal static DateTime? CaptureSendTime(IClientConfig config)
        {
            return IsCorrectionEnabled(config) ? AWSSDKUtils.CorrectedUtcNow : (DateTime?)null;
        }

        /// <summary>
        /// Unconditionally records <c>ClientSkew</c> from a response (success or error),
        /// applying the specification midpoint formula and discard guards. No-op when
        /// correction is disabled, or when there is no send time / response.
        /// </summary>
        internal static void RecordFromResponse(IExecutionContext executionContext, DateTime? sentAtUtc, IWebResponseData response)
        {
            if (sentAtUtc == null || response == null)
                return;
            if (!IsCorrectionEnabled(executionContext.RequestContext.ClientConfig))
                return;

            var receivedUtc = AWSSDKUtils.CorrectedUtcNow;

            DateTime? serverTime = ClockSkewCalculator.TryParseDateHeader(
                response.GetHeaderValue(HeaderKeys.DateHeader), out var parsed)
                ? parsed
                : (DateTime?)null;
            bool hasAgeHeader = response.IsHeaderPresent(HeaderKeys.AgeHeader);

            var contextAttributes = executionContext.RequestContext.ContextAttributes;
            if (ClockSkewCalculator.TryComputeCandidateSkew(serverTime, sentAtUtc.Value, receivedUtc, hasAgeHeader, out var candidate))
            {
                var endpoint = executionContext.RequestContext.Request.Endpoint.ToString();
                CorrectClockSkew.SetClockCorrectionForEndpoint(endpoint, candidate);
                contextAttributes[AttemptSkewCandidateKey] = candidate;

                // Emit a detailed diagnostic only when the measured skew is large enough to
                // plausibly be the cause of auth/retry failures. Gated on the detection
                // threshold so normal (near-zero) skew does not spam the logs on every response.
                var absoluteSkew = candidate.Ticks < 0 ? candidate.Negate() : candidate;
                if (absoluteSkew > ClockSkewCalculator.SkewDetectionThreshold)
                {
                    Logger.GetLogger(typeof(ClockSkewPipelineHelper)).InfoFormat(clockSkewIdentifiedFormat,
                        receivedUtc, receivedUtc + candidate, candidate, serverTime.Value, endpoint);
                }
            }
            else
            {
                contextAttributes.Remove(AttemptSkewCandidateKey);
            }
        }

        /// <summary>
        /// Records <c>ClientSkew</c> from the HTTP response carried by a thrown
        /// exception (error path). No-op when correction is disabled or the exception
        /// carries no HTTP response.
        /// </summary>
        internal static void RecordFromException(IExecutionContext executionContext, DateTime? sentAtUtc, Exception exception)
        {
            if (sentAtUtc == null || !IsCorrectionEnabled(executionContext.RequestContext.ClientConfig))
                return;

            var webData = GetWebData(exception);
            if (webData != null)
                RecordFromResponse(executionContext, sentAtUtc, webData);
            else
                executionContext.RequestContext.ContextAttributes.Remove(AttemptSkewCandidateKey);
        }

        /// <summary>
        /// Returns true if the latest attempt's recorded candidate skew exceeds the
        /// specification skew detection threshold (4 minutes). Used by the retry policy to gate
        /// clock skew retries.
        /// </summary>
        internal static bool AttemptSkewExceedsThreshold(IExecutionContext executionContext)
        {
            if (executionContext.RequestContext.ContextAttributes.TryGetValue(AttemptSkewCandidateKey, out var value)
                && value is TimeSpan candidate)
            {
                var absolute = candidate.Ticks < 0 ? candidate.Negate() : candidate;
                return absolute > ClockSkewCalculator.SkewDetectionThreshold;
            }

            return false;
        }

        private static IWebResponseData GetWebData(Exception exception)
        {
            var current = exception;
            while (current != null)
            {
                if (current is HttpErrorResponseException httpErrorResponse)
                    return httpErrorResponse.Response;
                current = current.InnerException;
            }

            return null;
        }
    }
}
