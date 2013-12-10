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
using System.Collections.Specialized;
using System.Linq;
using System.Security;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;


using Amazon.Util;
using Amazon.Runtime;
using System.Runtime.InteropServices;
using Amazon.S3.Model;
using System.Net;
using Amazon.S3;
using Amazon.S3.Util;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
    internal class S3Signer : AbstractAWSSigner
    {
        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        public override void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            request.Headers["x-amz-date"] = AWSSDKUtils.FormattedCurrentTimestampRFC822;

            string toSign = buildSigningString(request.HttpMethod, request.CanonicalResource, request.Parameters, request.Headers);
            metrics.AddProperty(Metric.StringToSign, toSign);
            string auth = CryptoUtilFactory.CryptoInstance.HMACSign(toSign, awsSecretAccessKey, SigningAlgorithm.HmacSHA1);
            string authorization = string.Concat("AWS ", awsAccessKeyId, ":", auth);
            request.Headers[S3QueryParameter.Authorization.ToString()] = authorization;
        }

        static string buildSigningString(string verb, string canonicalizedResource, IDictionary<string, string> parameters, IDictionary<string,string> webHeaders)
        {
            StringBuilder sb = new StringBuilder("", 256);
            string value = null;

            sb.Append(verb);
            sb.Append("\n");

            if (webHeaders != null)
            {
                if (webHeaders.ContainsKey(AWSSDKUtils.ContentMD5Header) && !String.IsNullOrEmpty(value = webHeaders[AWSSDKUtils.ContentMD5Header]))
                {
                    sb.Append(value);
                }
                sb.Append("\n");

                if (parameters.ContainsKey(S3QueryParameter.ContentType.ToString()))
                {
                    sb.Append(parameters[S3QueryParameter.ContentType.ToString()]);
                }
                else if (webHeaders.ContainsKey("Content-Type"))
                {
                    sb.Append(webHeaders["Content-Type"]);
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

            if (parameters.ContainsKey(S3QueryParameter.Expires.ToString()))
            {
                sb.Append(parameters[S3QueryParameter.Expires.ToString()]);
                webHeaders.Remove(S3Constants.AmzDateHeader);
            }

            sb.Append("\n");
            sb.Append(buildCanonicalizedHeaders(webHeaders));

            if (!string.IsNullOrEmpty(canonicalizedResource))
            {
                int quotePos = canonicalizedResource.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                if (quotePos != -1)
                {
                    var path = canonicalizedResource.Substring(0, quotePos);
                    var query = canonicalizedResource.Substring(quotePos);
                    var fullPath = AmazonS3Util.UrlEncode(path, true) + query;
                    sb.Append(fullPath);
                }
                else
                {
                    sb.Append(AmazonS3Util.UrlEncode(canonicalizedResource, true));
                }
            }

            return sb.ToString();
        }

        static StringBuilder buildCanonicalizedHeaders(IDictionary<string, string> headers)
        {
            // Create the canonicalized header string to return.
            StringBuilder sb = new StringBuilder(256);
            foreach (string key in headers.Keys.OrderBy(x => x, StringComparer.OrdinalIgnoreCase))
            {
                var lowerKey = key.ToLower(CultureInfo.InvariantCulture);
                if (!lowerKey.StartsWith("x-amz-", StringComparison.Ordinal))
                    continue;

                sb.Append(String.Concat(lowerKey, ":", headers[key], "\n"));
            }

            return sb;
        }
    }
}
