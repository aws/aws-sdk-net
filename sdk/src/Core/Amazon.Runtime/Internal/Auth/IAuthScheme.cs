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

using Amazon.Runtime.Identity;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// <para>
    /// Authentication schemes represent a way that the service will authenticate the customer's
    /// identity. An authentication scheme consists of an ID (e.g. "aws.auth#sigv4"), logic to 
    /// determine the identity resolver, and a signer matching the authentication type.
    /// </para>
    /// 
    /// <para>
    /// For example, the "aws.auth#sigv4" authentication scheme selects the identity resolver for 
    /// AWS credentials and the AWS SigV4 signer.
    /// </para>
    /// </summary>
    public interface IAuthScheme<out T> where T : BaseIdentity
    {
        /// <summary>
        /// Unique identifier for the authentication scheme (e.g. "smithy.api#noAuth" or "aws.auth#sigv4").
        /// </summary>
        string SchemeId { get; }

        /// <summary>
        /// Retrieves the identity resolver associated with this authentication scheme.
        /// </summary>
        IIdentityResolver GetIdentityResolver(IIdentityResolverConfiguration configuration);

        /// <summary>
        /// Retrieves the signer associated with this authentication scheme.
        /// </summary>
        ISigner Signer();
    }
}
