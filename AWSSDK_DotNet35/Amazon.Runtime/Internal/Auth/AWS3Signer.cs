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
using System.Collections.Generic;
using System.Security;
using System.Text;

using Amazon.Util;
using Amazon.Runtime;
using System.Globalization;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
    internal class AWS3Signer : AbstractAWSSigner
    {
        private const string AUTHORIZATION_HEADER = "X-Amzn-Authorization";
        private const string NONCE_HEADER = "x-amz-nonce";
        private const string HTTP_SCHEME = "AWS3";
        private const string HTTPS_SCHEME = "AWS3-HTTPS";

        private bool UseAws3Https { get; set; }

        public AWS3Signer(bool useAws3Https)
        {
            UseAws3Https = useAws3Https;
        }
        public AWS3Signer()
            : this(false)
        {
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        /// <summary>
        /// Signs the specified request with the AWS3 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS public key</param>
        /// <param name="awsSecretAccessKey">The AWS secret key used to sign the request in clear text</param>
        /// <param name="metrics">Request metrics</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="request">The request to have the signature compute for</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey) 
        {
            if (UseAws3Https)
            {
                SignHttps(request, clientConfig, metrics, awsAccessKeyId, awsSecretAccessKey);
            }
            else
            {
                SignHttp(request, metrics, awsAccessKeyId, awsSecretAccessKey);
            }
        }

        private static void SignHttps(IRequest request, ClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            string nonce = Guid.NewGuid().ToString();
            string date = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            string stringToSign;

            stringToSign = date + nonce;
            metrics.AddProperty(Metric.StringToSign, stringToSign);

            string signature = ComputeHash(stringToSign, awsSecretAccessKey, clientConfig.SignatureMethod);

            StringBuilder builder = new StringBuilder();
            builder.Append(HTTPS_SCHEME).Append(" ");
            builder.Append("AWSAccessKeyId=" + awsAccessKeyId + ",");
            builder.Append("Algorithm=" + clientConfig.SignatureMethod.ToString() + ",");
            builder.Append("SignedHeaders=x-amz-date;x-amz-nonce,");
            builder.Append("Signature=" + signature);

            request.Headers[AUTHORIZATION_HEADER] = builder.ToString();
            request.Headers[NONCE_HEADER] = nonce;
            request.Headers["x-amz-date"] = date;
        }

        private static void SignHttp(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
        {
            SigningAlgorithm algorithm = SigningAlgorithm.HmacSHA256;
            string nonce = Guid.NewGuid().ToString();
            string date = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            bool isHttps = IsHttpsRequest(request);

            // Temporarily disabling the AWS3 HTTPS signing scheme and only using AWS3 HTTP
            isHttps = false;

            request.Headers["Date"] = date;
            request.Headers["X-Amz-Date"] = date;

            // AWS3 HTTP requires that we sign the Host header
            // so we have to have it in the request by the time we sign.
            string hostHeader = request.Endpoint.Host;
            if (!request.Endpoint.IsDefaultPort)
                hostHeader += ":" + request.Endpoint.Port;
            request.Headers["Host"] = hostHeader;

            byte[] bytesToSign = null;
            string stringToSign;
            if (isHttps)
            {
                request.Headers[NONCE_HEADER] = nonce;
                stringToSign = date + nonce;
                bytesToSign = Encoding.UTF8.GetBytes(stringToSign);
            }
            else
            {
                Uri url = request.Endpoint;
                if (!string.IsNullOrEmpty(request.ResourcePath))
                    url = new Uri(request.Endpoint, request.ResourcePath);

                stringToSign = request.HttpMethod + "\n"
                    + GetCanonicalizedResourcePath(url) + "\n"
                    + GetCanonicalizedQueryString(request.Parameters) + "\n"
                    + GetCanonicalizedHeadersForStringToSign(request) + "\n"
                    + GetRequestPayload(request);

                bytesToSign = CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(Encoding.UTF8.GetBytes(stringToSign));
            }

            metrics.AddProperty(Metric.StringToSign, stringToSign);
            string signature = ComputeHash(bytesToSign, awsSecretAccessKey, algorithm);

            StringBuilder builder = new StringBuilder();
            builder.Append(isHttps ? HTTPS_SCHEME : HTTP_SCHEME);
            builder.Append(" ");
            builder.Append("AWSAccessKeyId=" + awsAccessKeyId + ",");
            builder.Append("Algorithm=" + algorithm.ToString() + ",");

            if (!isHttps)
            {
                builder.Append(GetSignedHeadersComponent(request) + ",");
            }

            builder.Append("Signature=" + signature);
            string authorizationHeader = builder.ToString();
            request.Headers[AUTHORIZATION_HEADER] = authorizationHeader;
        }

        #region Http signing helpers

        private static string GetCanonicalizedResourcePath(Uri endpoint)
        {
            string uri = endpoint.AbsolutePath;
            if (string.IsNullOrEmpty(uri))
            {
                return "/";
            }
            else
            {
                return AWSSDKUtils.UrlEncode(uri, true);
            }
        }

        private static bool IsHttpsRequest(IRequest request)
        {
            string protocol = request.Endpoint.Scheme;
            if (protocol.Equals("http", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else if (protocol.Equals("https", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                throw new AmazonServiceException(
                    "Unknown request endpoint protocol encountered while signing request: " + protocol);
            }
        }

        private static string GetCanonicalizedQueryString(IDictionary<string, string> parameters)
        {
            IDictionary<string, string> sorted =
                  new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);

            StringBuilder builder = new StringBuilder();
            foreach (var pair in sorted)
            {
                if (pair.Value != null)
                {
                    string key = pair.Key;
                    string value = pair.Value;
                    builder.Append(AWSSDKUtils.UrlEncode(key, false));
                    builder.Append("=");
                    builder.Append(AWSSDKUtils.UrlEncode(value, false));
                    builder.Append("&");
                }
            }

            string result = builder.ToString();
            return (string.IsNullOrEmpty(result) ? string.Empty : result.Substring(0, result.Length - 1));
        }

        private static string GetRequestPayload(IRequest request)
        {
            if (request.Content == null)
                return string.Empty;

            Encoding encoding = Encoding.GetEncoding(DEFAULT_ENCODING);
            return encoding.GetString(request.Content, 0, request.Content.Length);
        }

        private static string GetSignedHeadersComponent(IRequest request)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("SignedHeaders=");
            bool first = true;
            foreach (string header in GetHeadersForStringToSign(request))
            {
                if (!first) builder.Append(";");
                builder.Append(header);
                first = false;
            }
            return builder.ToString();
        }

        private static List<string> GetHeadersForStringToSign(IRequest request)
        {
            List<string> headersToSign = new List<string>();
            foreach (var entry in request.Headers) {
                string key = entry.Key;
                if (key.StartsWith("x-amz", StringComparison.OrdinalIgnoreCase)
                        || key.Equals("content-encoding", StringComparison.OrdinalIgnoreCase)
                        || key.Equals("host", StringComparison.OrdinalIgnoreCase))
                {
                    headersToSign.Add(key);
                }
            }

            headersToSign.Sort(StringComparer.OrdinalIgnoreCase);
            return headersToSign;
        }

        private static string GetCanonicalizedHeadersForStringToSign(IRequest request)
        {
            List<string> headersToSign = GetHeadersForStringToSign(request);

            for (int i = 0; i < headersToSign.Count; i++)
            {
                headersToSign[i] = headersToSign[i].ToLower(CultureInfo.InvariantCulture);
            }

            SortedDictionary<string,string> sortedHeaderMap = new SortedDictionary<string,string>();
            foreach (var entry in request.Headers)
            {
                if (headersToSign.Contains(entry.Key.ToLower(CultureInfo.InvariantCulture)))
                {
                    sortedHeaderMap[entry.Key] = entry.Value;
                }
            }

            StringBuilder builder = new StringBuilder();
            foreach (var entry in sortedHeaderMap)
            {
                builder.Append(entry.Key.ToLower(CultureInfo.InvariantCulture));
                builder.Append(":");
                builder.Append(entry.Value);
                builder.Append("\n");
            }

            return builder.ToString();
        }

        #endregion
    }

    internal class AWS3HTTPSigner : AWS3Signer
    {
        public AWS3HTTPSigner()
            : base(false)
        {
        }
    }
}
