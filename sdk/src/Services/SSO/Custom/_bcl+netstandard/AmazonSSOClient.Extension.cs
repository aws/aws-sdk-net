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
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSO.Internal;

namespace Amazon.SSO
{
    /// <summary>
    /// Utilities methods for working with SSO
    /// </summary>	
    public partial class AmazonSSOClient : AmazonServiceClient, IAmazonSSO
    {
#if BCL
        /// <summary>
        /// Create credentials from SSO access token
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="roleName"></param>
        /// <param name="accessToken"></param>
        /// <param name="additionalProperties"></param>
        /// <returns></returns>
        ImmutableCredentials ICoreAmazonSSO.CredentialsFromSsoAccessToken(
            string accountId, string roleName, string accessToken,
            IDictionary<string, object> additionalProperties)
        {
            return CoreAmazonSSO.CredentialsFromSsoAccessToken(this, accountId, roleName, accessToken, additionalProperties);
        }
		
        /// <summary>
        /// Logout access token
        /// </summary>
        /// <param name="accessToken"></param>		
        void ICoreAmazonSSO_Logout.Logout(string accessToken)
        {
            CoreAmazonSSO.Logout(this, accessToken);
        }
#endif

        /// <summary>
        /// Create credentials from SSO access token
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="roleName"></param>
        /// <param name="accessToken"></param>
        /// <param name="additionalProperties"></param>
        /// <returns></returns>
        Task<ImmutableCredentials> ICoreAmazonSSO.CredentialsFromSsoAccessTokenAsync(
            string accountId, string roleName, string accessToken,
            IDictionary<string, object> additionalProperties)
        {
            return CoreAmazonSSO.CredentialsFromSsoAccessTokenAsync(this, accountId, roleName, accessToken, additionalProperties);
        }
		
        /// <summary>
        /// Logout access token
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>		
        Task ICoreAmazonSSO_Logout.LogoutAsync(string accessToken, CancellationToken cancellationToken)
        {
            return CoreAmazonSSO.LogoutAsync(this, accessToken, cancellationToken);
        }
    }
}
