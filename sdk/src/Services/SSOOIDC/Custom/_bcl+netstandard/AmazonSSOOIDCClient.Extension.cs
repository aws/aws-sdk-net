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

using System.Threading;
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
            return CoreAmazonSSOOIDC.GetSsoToken(this, request);
        }
#endif

        async Task<GetSsoTokenResponse> ICoreAmazonSSOOIDC.GetSsoTokenAsync(GetSsoTokenRequest request)
        {
            return await CoreAmazonSSOOIDC.GetSsoTokenAsync(this, request).ConfigureAwait(false);
        }

        async Task<GetSsoTokenResponse> ICoreAmazonSSOOIDC_V2.GetSsoTokenAsync(GetSsoTokenRequest request, CancellationToken cancellationToken)
        {
            return await CoreAmazonSSOOIDC.GetSsoTokenAsync(this, request, cancellationToken).ConfigureAwait(false);
        }

#if BCL
        GetSsoTokenResponse ICoreAmazonSSOOIDC.RefreshToken(
            GetSsoTokenResponse previousResponse)
        {
            return CoreAmazonSSOOIDC.RefreshToken(this, previousResponse);
        }
#endif

        async Task<GetSsoTokenResponse> ICoreAmazonSSOOIDC.RefreshTokenAsync(
            GetSsoTokenResponse previousResponse)
        {
            return await CoreAmazonSSOOIDC.RefreshTokenAsync(this, previousResponse).ConfigureAwait(false);
        }
    }
}
