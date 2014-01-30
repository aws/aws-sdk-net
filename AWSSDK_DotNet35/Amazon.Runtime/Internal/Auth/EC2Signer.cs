/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Internal.Auth
{
    internal class EC2Signer : QueryStringSigner
    {
        private bool _useSigV4 = false;

        AWS4Signer _aws4Signer;
        AWS4Signer AWS4SignerInstance
        {
            get
            {
                if (_aws4Signer == null)
                {
                    lock (this)
                    {
                        if (_aws4Signer == null)
                            _aws4Signer = new AWS4Signer();
                    }
                }

                return _aws4Signer;
            }
        }

        /// <summary>
        /// EC2 signer constructor
        /// </summary>
        public EC2Signer()
        {
            _useSigV4 = AWSConfigs.EC2UseSignatureVersion4;
        }

        /// <summary>
        /// Inspects the supplied evidence to return the signer appropriate for the operation
        /// </summary>
        /// <param name="irequest"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        AbstractAWSSigner SelectSigner(IRequest irequest, ClientConfig config)
        {
            // do a cascading series of checks to try and arrive at whether we have
            // a recognisable region; this is required to use the AWS4 signer
            RegionEndpoint r = null;
            if (!string.IsNullOrEmpty(config.AuthenticationRegion))
                r = RegionEndpoint.GetBySystemName(config.AuthenticationRegion);

            if (r == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                var parsedRegion = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                if (!string.IsNullOrEmpty(parsedRegion))
                    r = RegionEndpoint.GetBySystemName(parsedRegion);
            }

            if (r == null && config.RegionEndpoint != null)
                r = config.RegionEndpoint;

            if (_useSigV4 || r == RegionEndpoint.CNNorth1)
                return AWS4SignerInstance;

            return this;
        }

        /// <summary>
        /// Determines the appropriate signer and signs the request.
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS public key</param>
        /// <param name="awsSecretAccessKey">The AWS secret key used to sign the request in clear text</param>
        /// <param name="metrics">Request metrics</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="request">The request to have the signature compute for</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            var aws4Signer = SelectSigner(request, clientConfig) as AWS4Signer;
            if (aws4Signer != null)
                aws4Signer.Sign(request, clientConfig, metrics, awsAccessKeyId, awsSecretAccessKey);
            else
                base.Sign(request, clientConfig, metrics, awsAccessKeyId, awsSecretAccessKey);
        }
    }
}
