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

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonSSO is not meant to be used directly. It defines SSO 
    /// service with basic .NET types and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSSOClient 
    /// defined in the AWSSDK.SSO assembly.
    /// </summary>
    public interface ICoreAmazonSSO
    {
#if BCL
        ImmutableCredentials CredentialsFromSsoAccessToken(string accountId, string roleName, string accessToken, IDictionary<string, object> additionalProperties);

#endif

        Task<ImmutableCredentials> CredentialsFromSsoAccessTokenAsync(string accountId, string roleName, string accessToken, IDictionary<string, object> additionalProperties);
    }

    /// <summary>
    /// ICoreAmazonSSO_Logout is not meant to be used directly. It defines SSO 
    /// service with Logout functionality and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSSOClient 
    /// defined in the AWSSDK.SSO assembly.
    /// </summary>
    public interface ICoreAmazonSSO_Logout
    {
#if BCL
        void Logout(string accessToken);

#endif

        Task LogoutAsync(string accessToken, CancellationToken cancellationToken = default);
    }
}
