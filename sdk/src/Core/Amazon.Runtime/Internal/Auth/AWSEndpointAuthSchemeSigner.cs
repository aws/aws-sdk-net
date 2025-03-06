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

using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS4/AWS4a protocol signer for service calls that transmit authorization in the header field "Authorization".
    /// Specific for services that have been allow listed to use signing specified by the endpoint rules AuthScheme.
    /// </summary>
    public class AWSEndpointAuthSchemeSigner : AbstractAWSSigner
    {
        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
        {
            var useSigV4 = request.SignatureVersion == SignatureVersion.SigV4;
            var signer = SelectSigner(this, useSigV4, request, clientConfig);
            var aws4aSigner = signer as AWS4aSignerCRTWrapper;
            var aws4Signer = signer as AWS4Signer;
            var useV4a = aws4aSigner != null;
            var useV4 = aws4Signer != null;

            if (identity is not AWSCredentials credentials)
            {
                throw new AmazonClientException($"The identity parameter must be of type AWSCredentials for the signer {nameof(AWSEndpointAuthSchemeSigner)}.");
            }

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials is null)
            {
                return;
            }

            AWSSigningResultBase signingResult;
            
            if (useV4a)
            {
                signingResult = aws4aSigner.SignRequest(request, clientConfig, metrics, immutableCredentials);
            }
            else if (useV4)
            {
                signingResult = aws4Signer.SignRequest(request, clientConfig, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
            }
            else
            {
                throw new AmazonClientException($"{request.ServiceName} supports only SigV4 and SigV4a signature versions.");
            }

            request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
        }
    }
}
