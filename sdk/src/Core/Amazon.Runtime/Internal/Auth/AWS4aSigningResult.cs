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
using System.Text;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// Encapsulates the various fields and eventual signing value that makes up 
    /// an AWS4a signature. This can be used to retrieve the required authorization string
    /// or authorization query parameters for the final request as well as hold ongoing
    /// signature computations for subsequent calls related to the initial signing.
    /// </summary>
    public class AWS4aSigningResult : AWSSigningResultBase
    {
        private readonly string _regionSet;
        private readonly string _signature;
        private readonly string _service;
        private readonly string _presignedUri;
        private readonly ImmutableCredentials _credentials;

        /// <summary>
        /// Constructs a new signing result instance for a computed signature
        /// </summary>
        /// <param name="awsAccessKeyId">The access key that was included in the signature</param>
        /// <param name="signedAt">Date/time (UTC) that the signature was computed</param>
        /// <param name="signedHeaders">The collection of headers names that were included in the signature</param>
        /// <param name="scope">Formatted 'scope' value for signing (YYYYMMDD/region/service/aws4_request)</param>
        /// <param name="regionSet">The set of AWS regions this signature is valid for</param>
        /// <param name="signature">Computed signature</param>
        /// <param name="service">Service the request was signed for</param>
        /// <param name="presignedUri">Presigned Uri</param>
        /// <param name="credentials">Credentials of the AWS account making the signed request</param>
        public AWS4aSigningResult(string awsAccessKeyId,
                                    DateTime signedAt,
                                    string signedHeaders,
                                    string scope,
                                    string regionSet,
                                    string signature,
                                    string service,
                                    string presignedUri,
                                    ImmutableCredentials credentials) :
            base(awsAccessKeyId, signedAt, signedHeaders, scope)
        {
            _regionSet = regionSet;
            _signature = signature;
            _service = service;
            _presignedUri = presignedUri;
            _credentials = credentials;
        }

        /// <summary>
        /// Returns the hex string representing the signature
        /// </summary>
        public override string Signature
        {
            get { return _signature; }
        }

        /// <summary>
        /// Returns the signature in a form usable as an 'Authorization' header value.
        /// </summary>
        public override string ForAuthorizationHeader
        {
            get
            {
                var authorizationHeader = new StringBuilder()
                    .Append(AWS4Signer.AWS4aAlgorithmTag)
                    .AppendFormat(" {0}={1}/{2},", AWS4Signer.Credential, AccessKeyId, Scope)
                    .AppendFormat(" {0}={1},", AWS4Signer.SignedHeaders, SignedHeaders)
                    .AppendFormat(" {0}={1}", AWS4Signer.Signature, Signature);

                return authorizationHeader.ToString();
            }
        }

        /// <summary>
        /// Returns the set of regions this signature is valid for
        /// </summary>
        public string RegionSet
        {
            get { return _regionSet; }
        }


        /// <summary>
        /// Returns the full presigned Uri
        /// </summary>
        public string PresignedUri
        { 
            get { return _presignedUri; }
        }

        /// <summary>
        /// Returns the service the request was signed for
        /// </summary>
        public string Service
        {
            get { return _service; }
        }

        /// <summary>
        /// Returns the credentials of the AWS account making the signed request
        /// </summary>
        public ImmutableCredentials Credentials
        {
            get { return _credentials; }
        }
    }
}
