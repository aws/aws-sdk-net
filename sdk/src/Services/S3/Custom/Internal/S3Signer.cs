/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Internal.Auth;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public class S3Signer : AbstractAWSSigner
    {
        private readonly bool _useSigV4;

        /// <summary>
        /// S3 signer constructor
        /// </summary>
        public S3Signer()
        {
            _useSigV4 = AWSConfigsS3.UseSignatureVersion4;
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            var signer = SelectSigner(this, _useSigV4, request, clientConfig);
            var aws4Signer = signer as AWS4Signer;
            var useV4 = aws4Signer != null;

            //var aws4Signer = SelectSigner(clientConfig) as AWS4Signer;
            if (useV4)
            {
                var signingResult = aws4Signer.SignRequest(request, clientConfig, metrics, awsAccessKeyId, awsSecretAccessKey);
                request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
                if (request.UseChunkEncoding)
                    request.AWS4SignerResult = signingResult;
            }
            else
                SignRequest(request, metrics, awsAccessKeyId, awsSecretAccessKey);
        }

        internal static void SignRequest(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            request.Headers[HeaderKeys.XAmzDateHeader] = AWSSDKUtils.FormattedCurrentTimestampRFC822;

            var stringToSign = BuildStringToSign(request);
            metrics.AddProperty(Metric.StringToSign, stringToSign);
            var auth = CryptoUtilFactory.CryptoInstance.HMACSign(stringToSign, awsSecretAccessKey, SigningAlgorithm.HmacSHA1);
            var authorization = string.Concat("AWS ", awsAccessKeyId, ":", auth);
            request.Headers[HeaderKeys.AuthorizationHeader] = authorization;
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

            sb.Append("\n");
            sb.Append(BuildCanonicalizedHeaders(headers));

            var canonicalizedResource = BuildCanonicalizedResource(request);
            if (!string.IsNullOrEmpty(canonicalizedResource))
                sb.Append(canonicalizedResource);

            return sb.ToString();
        }

        static string BuildCanonicalizedHeaders(IDictionary<string, string> headers)
        {
            var sb = new StringBuilder(256);
            foreach (var key in headers.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            {
                var lowerKey = key.ToLowerInvariant();
                if (!lowerKey.StartsWith("x-amz-", StringComparison.Ordinal))
                    continue;

                sb.Append(String.Concat(lowerKey, ":", headers[key], "\n"));
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

        static string BuildCanonicalizedResource(IRequest request)
        {
            // CanonicalResourcePrefix will hold the bucket name if we switched to virtual host addressing
            // during request preprocessing (where it would have been removed from ResourcePath)
            var sb = new StringBuilder(request.CanonicalResourcePrefix);
            sb.Append(!string.IsNullOrEmpty(request.ResourcePath)
                                ? AWSSDKUtils.UrlEncode(request.ResourcePath, true)
                                : "/");

            // form up the set of all subresources and specific query parameters that must be 
            // included in the canonical resource, then append them ordered by key to the 
            // canonicalization
            var resourcesToSign = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (request.SubResources.Count > 0)
            {
                foreach (var subResource in request.SubResources)
                {
                    resourcesToSign.Add(subResource.Key, subResource.Value);
                }
            }

            if (request.Parameters.Count > 0)
            {
                foreach (var parameter in request.Parameters)
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
