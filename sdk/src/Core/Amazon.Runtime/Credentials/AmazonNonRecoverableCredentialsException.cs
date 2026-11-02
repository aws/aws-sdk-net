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

namespace Amazon.Runtime
{
    /// <summary>
    /// Thrown when credentials cannot be obtained and retrying will not help until someone takes action, for example
    /// signing in again. Where the SDK knows the action to take, the message states it.
    /// <para />
    /// The SDK raises it in these cases:
    /// <list type="bullet">
    /// <item><description>SSO credentials, and SSO bearer tokens: the cached SSO token is missing or malformed, or it
    /// has expired and cannot be refreshed ("Please reauthenticate.", for example with <c>aws sso login</c> in the AWS
    /// CLI, <c>Invoke-AWSSSOLogin</c> in AWS Tools for PowerShell, or a sign-in the application starts through
    /// <see cref="SSOAWSCredentialsOptions.SupportsGettingNewToken"/>).</description></item>
    /// <item><description>Login credentials: the cached Login token is missing or malformed (including a missing DPoP
    /// key), it has expired and cannot be refreshed, or the Sign-In service rejects its refresh with
    /// <c>TOKEN_EXPIRED</c>, <c>USER_CREDENTIALS_CHANGED</c>, <c>INSUFFICIENT_PERMISSIONS</c> or a
    /// <c>ValidationException</c> ("Please reauthenticate."). Other refresh failures, such as network errors, throttling or service errors, are
    /// recoverable and raise <see cref="AmazonClientException"/>.</description></item>
    /// <item><description><see cref="AssumeRoleAWSCredentials"/> and <see cref="AssumeRoleWithWebIdentityCredentials"/>:
    /// STS rejects the request with <c>AccessDenied</c>, <c>IDPRejectedClaim</c>, <c>InvalidIdentityToken</c>,
    /// <c>MalformedPolicyDocument</c>, <c>PackedPolicyTooLarge</c> or <c>RegionDisabledException</c>. The exception has the
    /// STS client's message ("Error calling AssumeRole for role ...") and the STS service exception as its
    /// <see cref="Exception.InnerException"/>, as the <see cref="AmazonClientException"/> raised by earlier versions
    /// of the SDK did.</description></item>
    /// <item><description><see cref="AssumeRoleAWSCredentials"/> whose source credentials raise a non-recoverable error,
    /// for example a profile that assumes a role with SSO credentials whose session has expired. The source's
    /// exception, with its remediation message, is the <see cref="Exception.InnerException"/>.</description></item>
    /// </list>
    /// Other providers can treat errors from their own service as non-recoverable and raise them unchanged: Cognito
    /// credentials raise the Cognito Identity service's <c>NotAuthorizedException</c>,
    /// <c>ResourceNotFoundException</c> and <c>InvalidIdentityPoolConfigurationException</c>, and SSO credentials raise
    /// the SSO service's <c>UnauthorizedException</c>.
    /// <para />
    /// A provider that uses the credential refresh lifecycle (see <see cref="RefreshingAWSCredentials"/>) raises a
    /// non-recoverable error immediately: it does not apply the refresh backoff or fall back to cached credentials. Callers of
    /// <see cref="RefreshingAWSCredentials.GetCredentials()"/> within the next 1 to 5 seconds receive the same
    /// exception without the credential source being contacted again;
    /// <see cref="RefreshingAWSCredentials.GetCredentials(System.TimeSpan)"/> does not cache it.
    /// <para />
    /// It derives from <see cref="AmazonClientException"/>, the type these errors had in earlier versions of the SDK,
    /// so it continues to be caught by existing <c>catch (AmazonClientException)</c> handlers. Only code that checks
    /// for the exact type, for example <c>ex.GetType() == typeof(AmazonClientException)</c>, sees a difference.
    /// </summary>
#if !NETSTANDARD
    [Serializable]
#endif
    public class AmazonNonRecoverableCredentialsException : AmazonClientException
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AmazonNonRecoverableCredentialsException"/> with
        /// the specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AmazonNonRecoverableCredentialsException(string message)
            : base(message) { }

        /// <summary>
        /// Initializes a new instance of <see cref="AmazonNonRecoverableCredentialsException"/> with
        /// the specified error message and a reference to the inner exception that caused this exception.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of this exception.</param>
        public AmazonNonRecoverableCredentialsException(string message, Exception innerException)
            : base(message, innerException) { }

#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the <see cref="AmazonNonRecoverableCredentialsException"/> class
        /// with serialized data.
        /// </summary>
        protected AmazonNonRecoverableCredentialsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
#endif
    }
}
