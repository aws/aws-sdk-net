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
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SSO.Model;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon.SSO.Internal
{
    public static class CoreAmazonSSO
    {
#if BCL
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
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            var response = client.GetRoleCredentials(request);

            DateTime credentialsExpiration =
                AWSSDKUtils.ConvertFromUnixEpochMilliseconds(response.RoleCredentials.Expiration);

            return new SSOImmutableCredentials(
                response.RoleCredentials.AccessKeyId,
                response.RoleCredentials.SecretAccessKey,
                response.RoleCredentials.SessionToken,
                credentialsExpiration);
        }
#endif

#if AWS_ASYNC_API
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
            InternalSDKUtils.ApplyValues(request, additionalProperties);

            var response = await client.GetRoleCredentialsAsync(request).ConfigureAwait(false);

            DateTime credentialsExpiration =
                AWSSDKUtils.ConvertFromUnixEpochMilliseconds(response.RoleCredentials.Expiration);

            return new SSOImmutableCredentials(
                response.RoleCredentials.AccessKeyId,
                response.RoleCredentials.SecretAccessKey,
                response.RoleCredentials.SessionToken,
                credentialsExpiration);
        }
#endif
    }
}