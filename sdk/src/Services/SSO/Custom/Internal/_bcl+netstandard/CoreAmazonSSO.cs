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
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SSO.Model;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.SSO.Internal
{
    /// <summary>
    /// Utilities methods for working with SSO
    /// </summary>
    public static class CoreAmazonSSO
    {
#if BCL
        /// <summary>
        /// Create credentials from SSO access token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="roleName"></param>
        /// <param name="accessToken"></param>
        /// <param name="additionalProperties"></param>
        /// <returns></returns>
        public static ImmutableCredentials CredentialsFromSsoAccessToken(IAmazonSSO client, string accountId,
            string roleName, string accessToken,
            IDictionary<string, object> additionalProperties)
        {
            var request = new GetRoleCredentialsRequest()
            {
                AccessToken = accessToken,
                AccountId = accountId,
                RoleName = roleName,
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);

            var response = client.GetRoleCredentials(request);

            DateTime credentialsExpiration =
                AWSSDKUtils.ConvertFromUnixEpochMilliseconds(response.RoleCredentials.Expiration.GetValueOrDefault());

            return new SSOImmutableCredentials(
                response.RoleCredentials.AccessKeyId,
                response.RoleCredentials.SecretAccessKey,
                response.RoleCredentials.SessionToken,
                credentialsExpiration,
                accountId);
        }

        /// <summary>
        /// Logout access token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accessToken"></param>
        public static void Logout(IAmazonSSO client, string accessToken)
        {
            client.Logout(new LogoutRequest() { AccessToken = accessToken });
        }
#endif

        /// <summary>
        /// Create credentials from SSO access token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accountId"></param>
        /// <param name="roleName"></param>
        /// <param name="accessToken"></param>
        /// <param name="additionalProperties"></param>
        /// <returns></returns>
        public static async Task<ImmutableCredentials> CredentialsFromSsoAccessTokenAsync(IAmazonSSO client, string accountId,
            string roleName, string accessToken,
            IDictionary<string, object> additionalProperties)
        {
            var request = new GetRoleCredentialsRequest()
            {
                AccessToken = accessToken,
                AccountId = accountId,
                RoleName = roleName,
            };
            InternalSDKUtils.ApplyValuesV2(request, additionalProperties);

            var response = await client.GetRoleCredentialsAsync(request).ConfigureAwait(false);

            DateTime credentialsExpiration =
                AWSSDKUtils.ConvertFromUnixEpochMilliseconds(response.RoleCredentials.Expiration.GetValueOrDefault());

            return new SSOImmutableCredentials(
                response.RoleCredentials.AccessKeyId,
                response.RoleCredentials.SecretAccessKey,
                response.RoleCredentials.SessionToken,
                credentialsExpiration,
                accountId);
        }

        /// <summary>
        /// Logout access token
        /// </summary>
        /// <param name="client"></param>
        /// <param name="accessToken"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task LogoutAsync(IAmazonSSO client, string accessToken, CancellationToken cancellationToken = default)
        {
            await client.LogoutAsync(new LogoutRequest() { AccessToken = accessToken }, cancellationToken).ConfigureAwait(false);
        }
    }
}