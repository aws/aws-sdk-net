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
using System.Diagnostics.CodeAnalysis;

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Thrown by a credential source during a background refresh (see
    /// <see cref="RefreshingAWSCredentials.IsBackgroundRefresh"/>) when obtaining credentials would need the caller, for
    /// example because a new SSO token requires an interactive sign-in. <see cref="RefreshingAWSCredentials"/> ends the
    /// background refresh without recording a failure: it caches no error, applies no refresh backoff and logs no
    /// warning, and it starts no further background refresh for the same credentials. The refresh then happens when a
    /// call finds the credentials at their expiration, on that caller's thread.
    /// <para />
    /// A background refresh can reach the credential source through other providers, for example SSO credentials that
    /// are the source credentials of an <see cref="AssumeRoleAWSCredentials"/>. Each <see cref="RefreshingAWSCredentials"/>
    /// on the way passes it on unchanged (possibly wrapped, as the STS client wraps the errors of its source credentials)
    /// without recording a failure, and the provider whose background refresh it is ends that refresh as described
    /// above.
    /// <para />
    /// It is only thrown while a background refresh runs, and <see cref="RefreshingAWSCredentials"/> handles it there,
    /// so it is not thrown to the callers of the credential providers. Only code that runs inside the background
    /// refresh, such as a custom provider that calls another provider from its own refresh, can receive it.
    /// </summary>
    [SuppressMessage("Design", "CA1064:Exceptions should be public", Justification = "Internal signal from a credential source to RefreshingAWSCredentials during a background refresh; it is handled there and does not reach application code.")]
#if !NETSTANDARD
    [Serializable]
#endif
    internal sealed class CredentialRefreshDeferredException : AmazonClientException
    {
        /// <summary>
        /// Initializes a new instance with a message that says why the refresh needs the caller.
        /// </summary>
        /// <param name="message">Why the refresh cannot run in the background.</param>
        public CredentialRefreshDeferredException(string message)
            : base(message) { }

#if !NETSTANDARD
        private CredentialRefreshDeferredException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
#endif
    }
}
