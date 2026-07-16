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

using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// A minimal <see cref="ClientConfig"/> used only to satisfy the <see cref="IClientConfig"/>
    /// parameter of <see cref="Amazon.Runtime.Internal.Auth.AWS4Signer"/> when signing a standalone
    /// request. <see cref="AWSSigV4Signer"/> forces the signing region and service directly on the
    /// request (via <see cref="Amazon.Runtime.Internal.IRequest.AuthenticationRegion"/> and
    /// <see cref="Amazon.Runtime.Internal.IRequest.OverrideSigningServiceName"/>), so the signer never
    /// derives them from this config and never resolves an endpoint through it. Only the four abstract
    /// <see cref="ClientConfig"/> members need real values; the base defaults already supply everything
    /// the signing math reads (e.g. <c>SignatureMethod = HmacSHA256</c>).
    /// </summary>
    internal sealed class SigningStandaloneClientConfig : ClientConfig
    {
        public SigningStandaloneClientConfig()
            : base(new StandaloneConfigurationProvider())
        {
        }

        private sealed class StandaloneConfigurationProvider : IDefaultConfigurationProvider
        {
            public IDefaultConfiguration GetDefaultConfiguration(
                RegionEndpoint clientRegion,
                DefaultConfigurationMode? requestedConfigurationMode = null)
            {
                return new DefaultConfiguration();
            }
        }

        // Throwaway — not read by the signing math.
        public override string ServiceVersion => "1.0";

        // Throwaway — not read by the signing math.
        public override string UserAgent => InternalSDKUtils.BuildUserAgentString("1.0");

        // Not used on the standalone path: the region comes from the request, not this config.
        public override string RegionEndpointServiceName => "signing";

        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            throw new System.NotSupportedException("Endpoint resolution is not used for standalone signing.");
        }
    }
}
