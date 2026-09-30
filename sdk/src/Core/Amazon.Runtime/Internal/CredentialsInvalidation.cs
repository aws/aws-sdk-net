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
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Connects <see cref="RefreshingAWSCredentials.Invalidate(ImmutableCredentials)"/> to the request pipeline.
    /// When a service rejects a request with an invalid credential error code, the credentials that signed the
    /// request are marked expired, so the next attempt refreshes them instead of sending the rejected credentials
    /// again.
    /// <para />
    /// Called from <see cref="RetryHandler"/> rather than from <c>RetryPolicy.NotifyError</c>: the latter is public
    /// and virtual, so a customer override that does not call <c>base</c> would silently disable this behavior.
    /// <see cref="RetryHandler"/> observes every error.
    /// </summary>
    internal static class CredentialsInvalidation
    {
        /// <summary>
        /// Error codes that mean the service rejected the credentials themselves, so they must be refreshed before a
        /// retry: exactly <c>ExpiredToken</c> and <c>ExpiredTokenException</c> (the code JSON-protocol services such as
        /// DynamoDB and Lambda return), the invalid credential errors of the credential refresh specification, compared
        /// exactly (<see cref="StringComparer.Ordinal"/>) and whatever the HTTP status code. <c>InvalidToken</c> is not
        /// included: services return it for other tokens, such as Step Functions task tokens, not for expired
        /// credentials. Neither is <c>UnrecognizedClientException</c>, which means the credentials are not valid at all. <c>SignatureDoesNotMatch</c> is deliberately excluded: it
        /// almost always means clock skew or a malformed canonical request, and treating it as a bad access key would
        /// turn a signing bug into a credential-refresh loop.
        /// </summary>
        internal static readonly HashSet<string> InvalidatingErrorCodes =
            new HashSet<string>(StringComparer.Ordinal)
            {
                "ExpiredToken",
                "ExpiredTokenException",
            };

        /// <summary>
        /// If <paramref name="exception"/> is an invalid credential error (see <see cref="IsInvalidCredentialError"/>),
        /// marks the credentials that signed the request expired so the next <c>GetCredentials()</c> call, including
        /// the one made when a retry of this request is re-signed, goes through the mandatory refresh path. Never
        /// throws: invalidation is best effort and must not replace the service exception.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Invalidation is best effort; a failure is logged so the service exception reaches the retry logic and the caller unchanged.")]
        internal static void NotifyIfAuthFailure(IExecutionContext executionContext, Exception exception)
        {
            if (!TryGetRejectedCredentials(executionContext, exception, out var refreshingCredentials, out var used))
                return;

            try
            {
                // Invalidate() is conditional on the access key still matching; a concurrent refresh may have
                // already replaced the rejected credentials.
                refreshingCredentials.Invalidate(used);
            }
            catch (Exception e)
            {
                // Invalidate() is virtual, and the credentials may have been disposed while still in use.
                Logger.GetLogger(typeof(CredentialsInvalidation)).Error(e,
                    "Failed to invalidate credentials after the service returned {0}.",
                    ((AmazonServiceException)exception).ErrorCode);
            }
        }

        /// <summary>
        /// Returns <c>true</c> when <paramref name="exception"/> is a service exception with an invalid credential
        /// error code (<c>ExpiredToken</c>/<c>ExpiredTokenException</c>) and the request was signed with refreshing
        /// credentials that support invalidation (see <see cref="RefreshingAWSCredentials.SupportsInvalidationOnAuthFailure"/>).
        /// Such an error is retryable: the pipeline invalidates the rejected credentials and the retry is re-signed
        /// with credentials resolved again. For any other identity the error is left to the retry policy.
        /// </summary>
        internal static bool IsInvalidCredentialError(IExecutionContext executionContext, Exception exception)
        {
            return TryGetRejectedCredentials(executionContext, exception, out _, out _);
        }

        private static bool TryGetRejectedCredentials(IExecutionContext executionContext, Exception exception,
            out RefreshingAWSCredentials refreshingCredentials, out ImmutableCredentials used)
        {
            refreshingCredentials = null;
            used = null;

            if (executionContext == null)
                return false;
            if (!(exception is AmazonServiceException ase))
                return false;
            if (string.IsNullOrEmpty(ase.ErrorCode) || !InvalidatingErrorCodes.Contains(ase.ErrorCode))
                return false;

            var requestContext = executionContext.RequestContext;
            if (requestContext == null)
                return false;
            if (!(requestContext.Identity is RefreshingAWSCredentials credentials) || !credentials.SupportsInvalidationOnAuthFailure)
                return false;

            used = requestContext.ResolvedCredentials;
            if (used == null)
                return false;

            refreshingCredentials = credentials;
            return true;
        }
    }
}
