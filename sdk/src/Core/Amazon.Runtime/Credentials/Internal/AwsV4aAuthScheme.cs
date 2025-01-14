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
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// The <a href="https://smithy.io/2.0/aws/aws-auth.html#aws-auth-sigv4a-trait">AWS Signature Version 4 Asymmetric (SigV4A) authentication 
    /// scheme</a> (which uses AWS credentials and the SigV4A signer).
    /// </summary>
    public class AwsV4aAuthScheme : IAuthScheme<AWSCredentials>
    {
        private static ISigner _signer;
        
        /// <inheritdoc/>
        public string SchemeId => AuthSchemeOption.SigV4A;

        /// <inheritdoc/>
        public IIdentityResolver GetIdentityResolver(IIdentityResolverConfiguration configuration) 
            => configuration.GetIdentityResolver<AWSCredentials>();

        /// <inheritdoc/>
        public ISigner Signer()
        {
            if (_signer == null)
            {
                Interlocked.Exchange(ref _signer, new AWS4aSignerCRTWrapper());
            }

            return _signer;
        }
    }
}
