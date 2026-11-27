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

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// Implemented by a modeled service exception that carries the credential-refresh error discriminator on
    /// a member other than the base wire <see cref="AmazonServiceException.ErrorCode"/>. This interface is for use by
    /// the AWS SDK service packages and is not intended to be implemented by applications.
    /// <para>
    /// The Sign-In service returns its non-recoverable OAuth2 error (<c>TOKEN_EXPIRED</c> /
    /// <c>USER_CREDENTIALS_CHANGED</c> / <c>INSUFFICIENT_PERMISSIONS</c>) on <c>AccessDeniedException.Error</c>, while
    /// the base wire <see cref="AmazonServiceException.ErrorCode"/> is the generic modeled type name
    /// "AccessDeniedException". Classifying on <c>ErrorCode</c> alone would never see those values.
    /// </para>
    /// <para>
    /// Core's classifier reads the discriminator with a plain type check, so there is no cross-package reflection
    /// and nothing for the trimmer to remove. A service package whose exception carries such a discriminator
    /// implements this interface explicitly on that exception.
    /// </para>
    /// <para>
    /// Service packages built against this version of AWSSDK.Core implement it, so it is a binary contract: do not
    /// rename it, move it to another namespace, or change its member.
    /// </para>
    /// </summary>
    public interface ICredentialRefreshErrorCode
    {
        /// <summary>
        /// The effective credential-refresh error discriminator for this exception, or <c>null</c> when the
        /// exception carries none (in which case the caller falls back to
        /// <see cref="AmazonServiceException.ErrorCode"/>).
        /// </summary>
        string EffectiveRefreshErrorCode { get; }
    }
}
