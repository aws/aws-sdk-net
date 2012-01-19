﻿/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Web;
using System.Security.Cryptography;

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

        /// <summary>
        /// Signs the specified request with the AWS3 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS public key</param>
        /// <param name="awsSecretAccessKey">The AWS secret key used to sign the request in clear text</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="request">The request to have the signature compute for</param>
        /// <param name="secureKey">The AWS secret key stored in a secure string</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign<T>(IRequest<T> request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey) 
        {
            if (UseAws3Https)
            {
                SignHttps(request, clientConfig, awsAccessKeyId, awsSecretAccessKey, secureKey);
            }
            else
            {
                SignHttp(request, clientConfig, awsAccessKeyId, awsSecretAccessKey, secureKey);
            }
        }

        private void SignHttps<T>(IRequest<T> request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey)
        {
            string nonce = Guid.NewGuid().ToString();
            string date = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            string stringToSign;

            stringToSign = date + nonce;

            string signature = ComputeHash(stringToSign, awsSecretAccessKey, secureKey, clientConfig.SignatureMethod);

            StringBuilder builder = new StringBuilder();
            builder.Append(HTTPS_SCHEME).Append(" ");
            builder.Append("AWSAccessKeyId=" + awsAccessKeyId + ",");
            builder.Append("Algorithm=" + clientConfig.SignatureMethod.ToString() + ",");
            builder.Append("SignedHeaders=x-amz-date;x-amz-nonce,");
            builder.Append("Signature=" + signature);

            request.Headers.Add(AUTHORIZATION_HEADER, builder.ToString());
            request.Headers.Add(NONCE_HEADER, nonce);
            request.Headers.Add("x-amz-date", date);
        }

        private void SignHttp<T>(IRequest<T> request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey)
        {
            SigningAlgorithm algorithm = SigningAlgorithm.HmacSHA256;
            string nonce = Guid.NewGuid().ToString();
            string date = AWSSDKUtils.FormattedCurrentTimestampRFC822;
            bool isHttps = IsHttpsRequest(request);

            // Temporarily disabling the AWS3 HTTPS signing scheme and only using AWS3 HTTP
            isHttps = false;

            request.Headers.Add("Date", date);
            request.Headers.Add("X-Amz-Date", date);

            // AWS3 HTTP requires that we sign the Host header
            // so we have to have it in the request by the time we sign.
            string hostHeader = request.Endpoint.Host;
            if (!request.Endpoint.IsDefaultPort)
                hostHeader += ":" + request.Endpoint.Port;
            request.Headers.Add("Host", hostHeader);

            byte[] bytesToSign;
            string stringToSign;
            if (isHttps)
            {
                request.Headers.Add(NONCE_HEADER, nonce);
                stringToSign = date + nonce;
                bytesToSign = Encoding.UTF8.GetBytes(stringToSign);
            }
            else
            {
                stringToSign = "POST\n"
                    + GetCanonicalizedResourcePath(request.Endpoint) + "\n"
                    + GetCanonicalizedQueryString(request.Parameters) + "\n"
                    + GetCanonicalizedHeadersForStringToSign(request) + "\n"
                    + GetRequestPayload(request);
                
                HashAlgorithm mac = HashAlgorithm.Create("SHA-256");
                bytesToSign = mac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            }

            string signature = ComputeHash(bytesToSign, awsSecretAccessKey, secureKey, algorithm);

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
            request.Headers.Add(AUTHORIZATION_HEADER, authorizationHeader);
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

        private static bool IsHttpsRequest<T>(IRequest<T> request)
        {
            string protocol = request.Endpoint.Scheme;
            if (protocol.Equals(Uri.UriSchemeHttp, StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            else if (protocol.Equals(Uri.UriSchemeHttps, StringComparison.OrdinalIgnoreCase))
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

        private static string GetRequestPayload<T>(IRequest<T> request)
        {
            if (request.Content == null)
                return string.Empty;

            Encoding encoding = Encoding.GetEncoding(DEFAULT_ENCODING);
            return encoding.GetString(request.Content);
        }

        private static string GetSignedHeadersComponent<T>(IRequest<T> request)
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

        private static List<string> GetHeadersForStringToSign<T>(IRequest<T> request)
        {
            List<string> headersToSign = new List<string>();
            foreach (var entry in request.Headers) {
                string key = entry.Key;
                string lowerCaseKey = key.ToLower();
                if (lowerCaseKey.StartsWith("x-amz")
                        || lowerCaseKey.Equals("content-encoding")
                        || lowerCaseKey.Equals("host")) {
                    headersToSign.Add(key);
                }
            }

            headersToSign.Sort(StringComparer.OrdinalIgnoreCase);
            return headersToSign;
        }

        private static string GetCanonicalizedHeadersForStringToSign<T>(IRequest<T> request)
        {
            List<string> headersToSign = GetHeadersForStringToSign(request);

            for (int i = 0; i < headersToSign.Count; i++)
            {
                headersToSign[i] = headersToSign[i].ToLower();
            }

            SortedDictionary<string,string> sortedHeaderMap = new SortedDictionary<string,string>();
            foreach (var entry in request.Headers)
            {
                if (headersToSign.Contains(entry.Key.ToLower()))
                {
                    sortedHeaderMap[entry.Key] = entry.Value;
                }
            }

            StringBuilder builder = new StringBuilder();
            foreach (var entry in sortedHeaderMap)
            {
                builder.Append(entry.Key.ToLower());
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
