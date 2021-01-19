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

using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SSOOIDC.Internal;

namespace Amazon.SSOOIDC
{
    public partial class AmazonSSOOIDCClient : AmazonServiceClient, IAmazonSSOOIDC
    {
#if BCL
        GetSsoTokenResponse ICoreAmazonSSOOIDC.GetSsoToken(GetSsoTokenRequest request)
        {
            var ssoToken = CoreAmazonSSOOIDC.GetSsoToken(this, request);

            return new GetSsoTokenResponse()
            {
                AccessToken = ssoToken.AccessToken,
                ExpiresAt = ssoToken.ExpiresAt,
            };
        }
#endif

#if AWS_ASYNC_API
        async Task<GetSsoTokenResponse> ICoreAmazonSSOOIDC.GetSsoTokenAsync(GetSsoTokenRequest request)
        {
            var ssoToken = await CoreAmazonSSOOIDC.GetSsoTokenAsync(this, request).ConfigureAwait(false);

            return new GetSsoTokenResponse()
            {
                AccessToken = ssoToken.AccessToken,
                ExpiresAt = ssoToken.ExpiresAt,
            };
        }
#endif
    }
}
