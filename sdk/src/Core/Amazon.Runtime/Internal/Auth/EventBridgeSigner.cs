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

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS4/AWS4a protocol signer for service calls that transmit authorization in the header field "Authorization".
    /// Specific for EventBridge
    /// </summary>
    public class EventBridgeSigner : AbstractAWSSigner
    {
        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            Sign(request, clientConfig, metrics, new ImmutableCredentials(awsAccessKeyId, awsSecretAccessKey, ""));
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, ImmutableCredentials credentials)
        {
            var useSigV4 = request.SignatureVersion == SignatureVersion.SigV4;
            var signer = SelectSigner(this, useSigV4, request, clientConfig);
            var aws4aSigner = signer as AWS4aSignerCRTWrapper;
            var aws4Signer = signer as AWS4Signer;
            var useV4a = aws4aSigner != null;
            var useV4 = aws4Signer != null;

            AWSSigningResultBase signingResult;

            if (useV4a)
            {
                signingResult = aws4aSigner.SignRequest(request, clientConfig, metrics, credentials);
            }
            else if(useV4)
            {
                signingResult = aws4Signer.SignRequest(request, clientConfig, metrics, credentials.AccessKey, credentials.SecretKey);
            }
            else
            {
                throw new AmazonClientException("EventBridge supports only SigV4 and SigV4a signature versions");
            }

            request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
        }
    }
}
