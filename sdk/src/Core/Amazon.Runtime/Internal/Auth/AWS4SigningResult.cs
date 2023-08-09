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
using System;
using System.Globalization;
using System.Text;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// Encapsulates the various fields and eventual signing value that makes up 
    /// an AWS4 signature. This can be used to retrieve the required authorization string
    /// or authorization query parameters for the final request as well as hold ongoing
    /// signature computations for subsequent calls related to the initial signing.
    /// </summary>
    public class AWS4SigningResult : AWSSigningResultBase
    {
        private readonly byte[] _signingKey;
        private readonly byte[] _signature;

        /// <summary>
        /// Constructs a new signing result instance for a computed signature
        /// </summary>
        /// <param name="awsAccessKeyId">The access key that was included in the signature</param>
        /// <param name="signedAt">Date/time (UTC) that the signature was computed</param>
        /// <param name="signedHeaders">The collection of headers names that were included in the signature</param>
        /// <param name="scope">Formatted 'scope' value for signing (YYYYMMDD/region/service/aws4_request)</param>
        /// <param name="signingKey">Returns the key that was used to compute the signature</param>
        /// <param name="signature">Computed signature</param>
        public AWS4SigningResult(string awsAccessKeyId,
                                 DateTime signedAt,
                                 string signedHeaders,
                                 string scope,
                                 byte[] signingKey,
                                 byte[] signature) :
            base(awsAccessKeyId, signedAt, signedHeaders, scope)
        {
            _signingKey = signingKey;
            _signature = signature;
        }

        /// <summary>
        /// Returns a copy of the key that was used to compute the signature
        /// </summary>
        public byte[] GetSigningKey()
        {
            var kSigningCopy = new byte[_signingKey.Length];
            _signingKey.CopyTo(kSigningCopy, 0);
            return kSigningCopy;
        }

        /// <summary>
        /// Returns the hex string representing the signature
        /// </summary>
        public override string Signature
        {
            get { return AWSSDKUtils.ToHex(_signature, true); }
        }

        /// <summary>
        /// Returns the signature in a form usable as an 'Authorization' header value.
        /// </summary>
        public override string ForAuthorizationHeader
        {
            get
            {
                var authorizationHeader = new StringBuilder()
                    .Append(AWS4Signer.AWS4AlgorithmTag)
                    .AppendFormat(" {0}={1}/{2},", AWS4Signer.Credential, AccessKeyId, Scope)
                    .AppendFormat(" {0}={1},", AWS4Signer.SignedHeaders, SignedHeaders)
                    .AppendFormat(" {0}={1}", AWS4Signer.Signature, Signature);

                return authorizationHeader.ToString();
            }
        }

        /// <summary>
        /// Returns the signature in a form usable as a set of query string parameters.
        /// </summary>
        public string ForQueryParameters
        {
            get
            {
                var authParams = new StringBuilder()
                    .AppendFormat("{0}={1}", AWSSDKUtils.UrlEncode(HeaderKeys.XAmzAlgorithm, false), AWSSDKUtils.UrlEncode(AWS4Signer.AWS4AlgorithmTag, false))
                    .AppendFormat("&{0}={1}", AWSSDKUtils.UrlEncode(HeaderKeys.XAmzCredential, false), AWSSDKUtils.UrlEncode(string.Format(CultureInfo.InvariantCulture, "{0}/{1}", AccessKeyId, Scope), false))
                    .AppendFormat("&{0}={1}", AWSSDKUtils.UrlEncode(HeaderKeys.XAmzDateHeader, false), AWSSDKUtils.UrlEncode(ISO8601DateTime, false))
                    .AppendFormat("&{0}={1}", AWSSDKUtils.UrlEncode(HeaderKeys.XAmzSignedHeadersHeader, false), AWSSDKUtils.UrlEncode(SignedHeaders, false))
                    .AppendFormat("&{0}={1}", AWSSDKUtils.UrlEncode(HeaderKeys.XAmzSignature, false), AWSSDKUtils.UrlEncode(Signature, false));

                return authParams.ToString();
            }
        }
    }
}
