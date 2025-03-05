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
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;

#pragma warning disable 1591

namespace Amazon.Runtime.Internal.Auth
{
    public class S3Signer : AbstractAWSSigner
    {
        public delegate void RegionDetectionUpdater(IRequest request);
        private readonly RegionDetectionUpdater _regionDetector;

        /// <summary>
        /// S3 signer constructor
        /// </summary>
        public S3Signer() :
            this(null)
        {
        }

        /// <summary>
        /// S3 signer constructor
        /// </summary>
        public S3Signer(RegionDetectionUpdater regionDetector)
        {
            _regionDetector = regionDetector;
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, BaseIdentity identity)
        {
            var signer = SelectSigner(this, true, request, clientConfig);
            var aws4Signer = signer as AWS4Signer;
            var aws4aSigner = signer as AWS4aSignerCRTWrapper;
            var useV4 = aws4Signer != null;
            var useV4a = aws4aSigner != null;

            if (identity is not AWSCredentials credentials)
            {
                throw new AmazonClientException($"The identity parameter must be of type AWSCredentials for the signer {nameof(S3Signer)}.");
            }

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials is null)
            {
                return;
            }

            if (useV4a)
            {
                var signingResult = aws4aSigner.SignRequest(request, clientConfig, metrics, immutableCredentials);
                if (request.UseChunkEncoding)
                {
                    request.AWS4aSignerResult = signingResult;
                }
            }
            else if (useV4)
            {
                _regionDetector?.Invoke(request);
                var signingResult = aws4Signer.SignRequest(request, clientConfig, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
                request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
                if (request.UseChunkEncoding)
                    request.AWS4SignerResult = signingResult;
            }
            else
            {
                SignRequest(request, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
            }
        }

        public static void SignRequest(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            request.Headers[HeaderKeys.XAmzDateHeader] = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            request.SignedAt = AWSSDKUtils.CorrectedUtcNow;
            var stringToSign = BuildStringToSign(request);
            metrics.AddProperty(Metric.StringToSign, stringToSign);
            var auth = CryptoUtilFactory.CryptoInstance.HMACSign(stringToSign, awsSecretAccessKey, SigningAlgorithm.HmacSHA1);
            var authorization = string.Concat("AWS ", awsAccessKeyId, ":", auth);
            request.Headers[HeaderKeys.AuthorizationHeader] = authorization;
            request.SignatureVersion = SignatureVersion.SigV2;
        }

        static string BuildStringToSign(IRequest request)
        {
            var sb = new StringBuilder("", 256);

            sb.Append(request.HttpMethod);
            sb.Append("\n");

            var headers = request.Headers;
            var parameters = request.Parameters;

            if (headers != null)
            {
                string value = null;
                if (headers.ContainsKey(HeaderKeys.ContentMD5Header) && !String.IsNullOrEmpty(value = headers[HeaderKeys.ContentMD5Header]))
                {
                    sb.Append(value);
                }
                sb.Append("\n");

                if (parameters.ContainsKey("ContentType"))
                {
                    sb.Append(parameters["ContentType"]);
                }
                else if (headers.ContainsKey(HeaderKeys.ContentTypeHeader))
                {
                    sb.Append(headers[HeaderKeys.ContentTypeHeader]);
                }
                sb.Append("\n");
            }
            else
            {
                // The headers are null, but we still need to append
                // the 2 newlines that are required by S3.
                // Without these, S3 rejects the signature.
                sb.Append("\n\n");
            }

            if (parameters.ContainsKey("Expires"))
            {
                sb.Append(parameters["Expires"]);
                if (headers != null)
                    headers.Remove(HeaderKeys.XAmzDateHeader);
            }

            IDictionary<string, string> headersAndParameters = new Dictionary<string, string>(headers);
            foreach (var pair in parameters)
            {
                // If there's a key that's both a header and a parameter then the header will take precedence.
                if (!headersAndParameters.ContainsKey(pair.Key))
                    headersAndParameters.Add(pair.Key, pair.Value);
            }
            sb.Append("\n");
            sb.Append(BuildCanonicalizedHeaders(headersAndParameters));

            var canonicalizedResource = BuildCanonicalizedResource(request);
            if (!string.IsNullOrEmpty(canonicalizedResource))
            {
                sb.Append(canonicalizedResource);
            }

            return sb.ToString();
        }

        static string BuildCanonicalizedHeaders(IDictionary<string, string> headers)
        {
            // Refer "Constructing the CanonicalizedAmzHeaders element" section at https://docs.aws.amazon.com/AmazonS3/latest/userguide/RESTAuthentication.html.
            var sb = new StringBuilder(256);
            
            // Steps 1 and Steps 2 requires all headers to be in lowercase and lexicographically sorted by header name. StringComparer.OrdinalIgnoreCase incorrectly places '_' after lowercase chracters.
            foreach (var key in headers.Keys.OrderBy(x => x.ToLowerInvariant(), StringComparer.Ordinal))
            {
                var lowerKey = key.ToLowerInvariant();
                if (!lowerKey.StartsWith("x-amz-", StringComparison.Ordinal))
                    continue;

                // Step 5: Trim any spaces around the colon in the header (based on testing spaces at the end of value also needs to be removed).
                sb.Append(String.Concat(lowerKey, ":", headers[key]?.Trim(), "\n"));
            }

            return sb.ToString();
        }

        private static readonly HashSet<string> SignableParameters = new HashSet<string>
        (
            new[]
            {
                "response-content-type",
                "response-content-language",
                "response-expires",
                "response-cache-control",
                "response-content-disposition",
                "response-content-encoding"
            },
            StringComparer.OrdinalIgnoreCase
        );

        //This is a list of sub resources that S3 does not expect to be signed
        //and thus have to be excluded from the signer. This is only applicable to S3SigV2 signer
        //id:- subresource belongs to analytics,inventory and metrics S3 APIs
        private static readonly HashSet<string> SubResourcesSigningExclusion = new HashSet<string>
        (
            new[]
            {
                "id"
            },
            StringComparer.OrdinalIgnoreCase
        );

        static string BuildCanonicalizedResource(IRequest request)
        {
            // CanonicalResourcePrefix will hold the bucket name if we switched to virtual host addressing
            // during request preprocessing (where it would have been removed from ResourcePath)
            var sb = new StringBuilder(request.CanonicalResourcePrefix);
            sb.Append(!string.IsNullOrEmpty(request.ResourcePath)
                                ? AWSSDKUtils.ResolveResourcePathV2(request.ResourcePath, request.PathResources)
                                : "/");

            // form up the set of all subresources and specific query parameters that must be 
            // included in the canonical resource, then append them ordered by key to the 
            // canonicalization
            var resourcesToSign = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (request.SubResources.Count > 0)
            {
                foreach (var subResource in request.SubResources)
                {
                    if (!SubResourcesSigningExclusion.Contains(subResource.Key))
                    {
                        resourcesToSign.Add(subResource.Key, subResource.Value);
                    }
                }
            }

            if (request.Parameters.Count > 0)
            {
                var parameters = request.ParameterCollection.GetSortedParametersList();
                foreach (var parameter in parameters)
                {
                    if (parameter.Value != null && SignableParameters.Contains(parameter.Key))
                    {
                        resourcesToSign.Add(parameter.Key, parameter.Value);
                    }
                }
            }

            var delim = "?";
            List<KeyValuePair<string, string>> resources = new List<KeyValuePair<string, string>>();
            foreach (var kvp in resourcesToSign)
            {
                resources.Add(kvp);
            }

            resources.Sort((firstPair, nextPair) =>
            {
                return string.CompareOrdinal(firstPair.Key, nextPair.Key);
            });

            foreach (var resourceToSign in resources)
            {
                sb.AppendFormat("{0}{1}", delim, resourceToSign.Key);
                if (resourceToSign.Value != null)
                    sb.AppendFormat("={0}", resourceToSign.Value);
                delim = "&";
            }
            return sb.ToString();
        }
    }
}
