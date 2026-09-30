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
using System.Collections.Generic;
using System.Threading;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Policy helpers for the credential refresh lifecycle in <see cref="RefreshingAWSCredentials"/>: the
    /// advisory-window lifetime table, non-recoverable error classification, and jittered durations. They use no
    /// clock and no shared state other than per-thread random number generators, so every member here is directly
    /// unit-testable without constructing a credentials object.
    /// </summary>
    internal static class CredentialRefreshPolicy
    {
        #region Advisory window lifetime table

        internal static readonly TimeSpan ShortLifetimeThreshold = TimeSpan.FromMinutes(20);
        internal static readonly TimeSpan LongLifetimeThreshold = TimeSpan.FromMinutes(90);
        internal static readonly TimeSpan ShortAdvisoryWindow = TimeSpan.FromMinutes(5);
        internal static readonly TimeSpan MediumAdvisoryWindow = TimeSpan.FromMinutes(15);
        internal static readonly TimeSpan LongAdvisoryWindow = TimeSpan.FromMinutes(60);

        /// <summary>
        /// Advisory-window lifetime table: lifetime &lt;= 20 min -&gt; 5 min advisory window;
        /// 20 min &lt; lifetime &lt; 90 min -&gt; 15 min; lifetime &gt;= 90 min -&gt; 60 min.
        /// An unknown (zero or negative) lifetime is treated as short, which is the conservative
        /// choice: it schedules the advisory refresh later, never past expiry. Boundaries are
        /// pinned so they cannot drift: exactly 20 min -&gt; 5 min, exactly 90 min -&gt; 60 min.
        /// </summary>
        internal static TimeSpan AdvisoryWindowForLifetime(TimeSpan lifetime)
        {
            if (lifetime <= TimeSpan.Zero) return ShortAdvisoryWindow;
            if (lifetime <= ShortLifetimeThreshold) return ShortAdvisoryWindow;
            if (lifetime < LongLifetimeThreshold) return MediumAdvisoryWindow;
            return LongAdvisoryWindow;
        }

        #endregion

        #region Non-recoverable error classification

        /// <summary>
        /// Service error codes for which retrying the credential fetch cannot succeed without external action (the
        /// identity source rejected the request outright): the STS codes, keyed by wire error code; the SSO
        /// <c>UnauthorizedException</c>; and the Sign-In OAuth2 errors <c>TOKEN_EXPIRED</c>,
        /// <c>USER_CREDENTIALS_CHANGED</c> and <c>INSUFFICIENT_PERMISSIONS</c>. A Sign-In
        /// <c>AccessDeniedException</c> with any other error, including <c>AUTHCODE_EXPIRED</c>, is recoverable.
        /// Codes are compared exactly (<see cref="StringComparer.Ordinal"/>), because service error codes are
        /// case-sensitive identifiers.
        /// </summary>
        internal static readonly HashSet<string> NonRecoverableErrorCodes =
            new HashSet<string>(StringComparer.Ordinal)
            {
                // STS, keyed by wire error code.
                "AccessDenied",
                "IDPRejectedClaim",
                "InvalidIdentityToken",
                "MalformedPolicyDocument",
                "PackedPolicyTooLarge",
                "RegionDisabled",
                // The modeled exception name, in case a response reports the code that way.
                "RegionDisabledException",
                // SSO.
                "UnauthorizedException",
                // Sign-In: only these three AccessDeniedException OAuth2 errors. AUTHCODE_EXPIRED is recoverable.
                "TOKEN_EXPIRED",
                "USER_CREDENTIALS_CHANGED",
                "INSUFFICIENT_PERMISSIONS",
            };

        /// <summary>
        /// The maximum number of exceptions in an <see cref="Exception.InnerException"/> chain that
        /// <see cref="IsNonRecoverableError"/> inspects. Credential providers wrap the source error only a few levels
        /// deep (the STS client wraps the service error in an <see cref="AmazonClientException"/>, and each
        /// assume-role hop over a source profile adds one more wrapper), so the bound only guards against a
        /// pathological chain.
        /// </summary>
        internal const int MaxInnerExceptionDepth = 8;

        /// <summary>
        /// Returns true when <paramref name="exception"/>, or an exception in its inner-exception chain, means the
        /// credential refresh cannot succeed without external action: an
        /// <see cref="AmazonNonRecoverableCredentialsException"/>, or an <see cref="AmazonServiceException"/> whose
        /// error code is in <see cref="NonRecoverableErrorCodes"/>. For a service exception that carries a
        /// credential-refresh discriminator (<see cref="ICredentialRefreshErrorCode"/>) the discriminator is used
        /// in place of <see cref="AmazonServiceException.ErrorCode"/>.
        /// <para />
        /// The chain is walked because the STS client wraps the service error in an
        /// <see cref="AmazonClientException"/>, and wraps an error raised by the source credentials of an
        /// assume-role provider the same way. The walk stops at the first service exception that carries an error code:
        /// that exception is the credential source's own answer, and its inner exceptions only describe the
        /// transport. Transport failures (for example <see cref="System.IO.IOException"/>, HttpRequestException or
        /// WebException) and service errors with other codes (throttling, 5xx) are recoverable.
        /// </summary>
        internal static bool IsNonRecoverableError(Exception exception)
        {
            var current = exception;
            for (var depth = 0; current != null && depth < MaxInnerExceptionDepth; depth++, current = current.InnerException)
            {
                if (current is AmazonNonRecoverableCredentialsException)
                    return true;

                if (current is AmazonServiceException serviceException)
                {
                    var code = (current as ICredentialRefreshErrorCode)?.EffectiveRefreshErrorCode;
                    if (string.IsNullOrEmpty(code))
                        code = serviceException.ErrorCode;
                    if (!string.IsNullOrEmpty(code))
                        return NonRecoverableErrorCodes.Contains(code);
                }
            }

            return false;
        }

        /// <summary>
        /// Error code of the Sign-In <c>ValidationException</c>, which <c>CreateOAuth2Token</c> returns when it rejects
        /// the refresh token ("The provided authorization grant is invalid, expired, revoked, or malformed"). It is not
        /// in <see cref="NonRecoverableErrorCodes"/>, because other services use the same code for errors that are not
        /// about credentials; <see cref="IsNonRecoverableSigninRefreshError"/> applies it to the Sign-In refresh only.
        /// </summary>
        internal const string SigninValidationExceptionCode = "ValidationException";

        /// <summary>
        /// Returns true when the Sign-In refresh of a Login token failed with an error that retrying cannot resolve: an
        /// error that <see cref="IsNonRecoverableError"/> classifies as non-recoverable, or a Sign-In
        /// <c>ValidationException</c>. As in <see cref="IsNonRecoverableError"/>, the first service exception in the
        /// inner-exception chain that has an error code decides.
        /// </summary>
        internal static bool IsNonRecoverableSigninRefreshError(Exception exception)
        {
            if (IsNonRecoverableError(exception))
                return true;

            var current = exception;
            for (var depth = 0; current != null && depth < MaxInnerExceptionDepth; depth++, current = current.InnerException)
            {
                if (current is AmazonServiceException serviceException && !string.IsNullOrEmpty(serviceException.ErrorCode))
                    return string.Equals(serviceException.ErrorCode, SigninValidationExceptionCode, StringComparison.Ordinal);
            }

            return false;
        }

        #endregion

        #region Jitter

        // A shared System.Random is not safe for concurrent Next() on .NET Framework -- it can
        // return zeros, collapsing the jitter to a constant and reintroducing the thundering herd
        // the jitter exists to prevent. Use a per-thread instance instead.
        private static int _seedCounter = Environment.TickCount;
        private static readonly ThreadLocal<Random> _random =
            new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref _seedCounter)));

        /// <summary>
        /// Refresh backoff for cached credentials with <paramref name="remainingLifetime"/> left: uniform random in
        /// [60s, upper], where upper is half the remaining lifetime, kept between 90s and 600s. Credentials close to
        /// expiring are therefore retried sooner, and a failed refresh does not outlast short-lived credentials.
        /// </summary>
        internal static TimeSpan NextRefreshBackoff(TimeSpan remainingLifetime)
        {
            var remainingSeconds = Math.Max(0.0, remainingLifetime.TotalSeconds);
            var upperSeconds = Math.Max(90.0, Math.Min(remainingSeconds / 2.0, 600.0));
            return TimeSpan.FromSeconds(60.0 + _random.Value.NextDouble() * (upperSeconds - 60.0));
        }

        /// <summary>Uniform random cache duration in [1s, 5s] for a non-recoverable error.</summary>
        internal static TimeSpan NextNonRecoverableErrorCacheDuration()
            => TimeSpan.FromSeconds(1.0 + _random.Value.NextDouble() * 4.0);

        #endregion
    }
}
