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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;

namespace Amazon.Runtime.Internal.Auth
{
    public enum ClientProtocol { QueryStringProtocol, RestProtocol, Unknown }

    public abstract class AbstractAWSSigner : ISigner
    {
        private readonly object _lock = new object();
        private AWS4Signer _aws4Signer;
        private AWS4Signer AWS4SignerInstance
        {
            get
            {
                if (_aws4Signer == null)
                {
                    lock (_lock)
                    {
                        if (_aws4Signer == null)
                            _aws4Signer = new AWS4Signer();
                    }
                }

                return _aws4Signer;
            }
        }

        private AWS4aSignerCRTWrapper _aws4aSignerCRTWrapper;
        private AWS4aSignerCRTWrapper AWS4aSignerCRTWrapperInstance
        {
            get
            {
                if (_aws4aSignerCRTWrapper == null)
                {
                    lock (_lock)
                    {
                        if (_aws4aSignerCRTWrapper == null)
                            _aws4aSignerCRTWrapper = new AWS4aSignerCRTWrapper();
                    }
                }

                return _aws4aSignerCRTWrapper;
            }
        }

        /// <summary>
        /// Signals to the <see cref="Signer"/> Pipeline Handler
        /// if a Signer requires valid <see cref="ImmutableCredentials"/> in order
        /// to correctly <see cref="Sign(IRequest,IClientConfig,RequestMetrics,BaseIdentity)"/>.
        /// </summary>
        public virtual bool RequiresCredentials { get; } = true;

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature.
        /// </summary>
        protected static string ComputeHash(string data, string secretkey, SigningAlgorithm algorithm)
        {
            try 
            {
                string signature = CryptoUtilFactory.CryptoInstance.HMACSign(data, secretkey, algorithm);

                return signature;
            } 
            catch (Exception e) 
            {
                throw new Amazon.Runtime.SignatureException("Failed to generate signature: " + e.Message, e);
            }
        }

        /// <summary>
        /// Computes RFC 2104-compliant HMAC signature.
        /// </summary>
        protected static string ComputeHash(byte[] data, string secretkey, SigningAlgorithm algorithm)
        {
            try
            {
                string signature = CryptoUtilFactory.CryptoInstance.HMACSign(data, secretkey, algorithm);

                return signature;
            }
            catch (Exception e)
            {
                throw new Amazon.Runtime.SignatureException("Failed to generate signature: " + e.Message, e);
            }
        }

        public abstract void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity);

        public virtual System.Threading.Tasks.Task SignAsync(
            IRequest request, 
            IClientConfig clientConfig,
            RequestMetrics metrics,
            BaseIdentity identity,
            CancellationToken token = default)
        {
            Sign(request, clientConfig, metrics, identity);
#if NETSTANDARD
            return Task.CompletedTask;
#else
            return Task.FromResult(0);
#endif
        }

        public abstract ClientProtocol Protocol { get; }

        /// <summary>
        /// Inspects the supplied evidence to determine if sigv4 signing should be used.
        /// </summary>
        /// <param name="useSigV4Setting">Global setting for the service</param>
        /// <param name="request">The request.</param>
        /// <param name="config">Configuration for the client</param>
        /// <returns>True if signature v4 request signing should be used, false if v2 signing should be used</returns>
        protected static bool UseV4Signing(bool useSigV4Setting, IRequest request, IClientConfig config)
        {
            if (request.SignatureVersion == SignatureVersion.SigV4 || useSigV4Setting)
            {
                return true;
            }
            else
            {
                // do a cascading series of checks to try and arrive at whether we have
                // a recognizable region; this is required to use the AWS4 signer
                RegionEndpoint r = null;
                if (!string.IsNullOrEmpty(request.AuthenticationRegion))
                    r = RegionEndpoint.GetBySystemName(request.AuthenticationRegion);

                if (r == null && !string.IsNullOrEmpty(config.ServiceURL))
                {
                    var parsedRegion = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                    if (!string.IsNullOrEmpty(parsedRegion))
                        r = RegionEndpoint.GetBySystemName(parsedRegion);
                }

                if (r == null && config.RegionEndpoint != null)
                    r = config.RegionEndpoint;

                if (r != null)
                {
                    return true;
                }

                return false;
            }
        }

        protected AbstractAWSSigner SelectSigner(IRequest request, IClientConfig config)
        {
            return SelectSigner(this, useSigV4Setting: false, request: request, config: config);
        }

        protected AbstractAWSSigner SelectSigner(AbstractAWSSigner defaultSigner,bool useSigV4Setting, 
            IRequest request, IClientConfig config)
        {
            if (request.SignatureVersion == SignatureVersion.SigV4a)
                return AWS4aSignerCRTWrapperInstance;
            else if (UseV4Signing(useSigV4Setting, request, config))
                return AWS4SignerInstance;
            else
                return defaultSigner;
        }

        /// <inheritdoc/>
        public virtual IEventSigner CreateEventSigner(BaseIdentity identity, string region, string service, string requestSignature)
        {
            throw new NotImplementedException();
        }
    }
}
