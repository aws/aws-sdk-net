﻿/*
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
using System.Security;
using System.Text;
using System.Globalization;

using Amazon.Util;
using Amazon.Runtime;
using System.Web;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Amazon.Runtime.Internal.Auth
{
    internal class AWS4Signer : AbstractAWSSigner
    {
        private const string SCHEME = "AWS4";
        private const string ALGORITHM = "HMAC-SHA256";
        private const string TERMINATOR = "aws4_request";

        /// <summary>
        /// Calculates and signs the specified request using the AWS4 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="awsAccessKeyId">The AWS public key</param>
        /// <param name="awsSecretAccessKey">The AWS secret key used to sign the request in clear text</param>
        /// <param name="clientConfig">The configuration that specifies which hashing algorithm to use</param>
        /// <param name="request">The request to have the signature compute for</param>
        /// <param name="secureKey">The AWS secret key stored in a secure string</param>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public override void Sign(IRequest request, ClientConfig clientConfig, string awsAccessKeyId, string awsSecretAccessKey, SecureString secureKey)
        {
            string signingAlgorithm = SigningAlgorithm.HmacSHA256.ToString().ToUpper();

            DateTime dt = DateTime.UtcNow;
            string dateTime = dt.ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat, CultureInfo.InvariantCulture);
            string dateStamp = dt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);

            string region = DetermineRegion(clientConfig);
            string service = DetermineService(clientConfig);

            if (!request.Headers.ContainsKey("Host"))
            {
                string hostHeader = request.Endpoint.Host;
                if (!request.Endpoint.IsDefaultPort)
                    hostHeader += ":" + request.Endpoint.Port;
                request.Headers.Add("Host", hostHeader);
            }
            request.Headers.Add("X-Amz-Date", dateTime);

            string scope = string.Format("{0}/{1}/{2}/{3}", dateStamp, region, service, TERMINATOR);
            List<string> headersToSign = GetHeadersForSigning(request.Headers);
            string canonicalRequest = GetCanonicalRequest(headersToSign,
                                                          request.Endpoint,
                                                          request.Headers,
                                                          GetRequestPayload(request));

            StringBuilder stringToSign = new StringBuilder();
            stringToSign.AppendFormat("{0}-{1}\n{2}\n{3}\n", SCHEME, ALGORITHM, dateTime, scope);

            HashAlgorithm ha = HashAlgorithm.Create("SHA-256");
            byte[] canonicalRequestHashBytes = ha.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest));
            stringToSign.Append(ToHex(canonicalRequestHashBytes, true));

            KeyedHashAlgorithm kha = KeyedHashAlgorithm.Create(signingAlgorithm);
            kha.Key = ComposeSigningKey(signingAlgorithm, awsSecretAccessKey, secureKey, region, dateStamp, service);
            byte[] signature = kha.ComputeHash(Encoding.UTF8.GetBytes(stringToSign.ToString()));

            StringBuilder authorizationHeader = new StringBuilder();
            authorizationHeader.AppendFormat("{0}-{1} ", SCHEME, ALGORITHM);
            authorizationHeader.AppendFormat("Credential={0}/{1}, ", awsAccessKeyId, scope);
            authorizationHeader.AppendFormat("SignedHeaders={0}, ", GetSignedHeaders(headersToSign));
            authorizationHeader.AppendFormat("Signature={0}", ToHex(signature, true));

            request.Headers.Add("Authorization", authorizationHeader.ToString());
        }

        /// <summary>
        /// Calculates the AWS4 signature using the supplied request parameters and AWS account credentials.
        /// </summary>
        /// <param name="parameters">Request header parameters to be included in the signature</param>
        /// <param name="serviceURL">Service endpoint URL</param>
        /// <param name="authenticationServiceName">
        /// The short-form name of the target service for inclusion in the signature; only needed if this 
        /// cannot be determined by parsing the endpoint.
        /// </param>
        /// <param name="authenticationRegion">
        /// Region name for inclusion in the signature; only needed if this  cannot be determined by parsing 
        /// the endpoint.
        /// </param>
        /// <param name="credentials">User credentials</param>
        /// <returns>The signature string to be added as header 'Authorization' on the eventual request</returns>
        /// <exception cref="Amazon.Runtime.SignatureException">If any problems are encountered while signing the request</exception>
        public static string CalculateSignature(IDictionary<string, string> parameters,
                                                string serviceURL,
                                                string authenticationServiceName,
                                                string authenticationRegion,
                                                ImmutableCredentials credentials)
        {
            string signingAlgorithm = SigningAlgorithm.HmacSHA256.ToString().ToUpper();

            DateTime dt = DateTime.UtcNow;
            string dateTime = dt.ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat, CultureInfo.InvariantCulture);
            string dateStamp = dt.ToString("yyyyMMdd", CultureInfo.InvariantCulture);

            string region;
            if (!string.IsNullOrEmpty(authenticationRegion))
                region = authenticationRegion;
            else
                region = AWSSDKUtils.DetermineRegion(serviceURL).ToLower();
            string service = authenticationServiceName.Trim().ToLower();

            if (!parameters.ContainsKey("Host"))
                parameters.Add("Host", serviceURL);
            parameters.Add("X-Amz-Date", dateTime);

            string scope = string.Format("{0}/{1}/{2}/{3}", dateStamp, region, service, TERMINATOR);

            List<string> headersToSign = GetHeadersForSigning(parameters);
            string canonicalRequest = GetCanonicalRequest(headersToSign,
                                                          new Uri(serviceURL),
                                                          parameters,
                                                          AWSSDKUtils.GetParametersAsString(parameters));

            StringBuilder stringToSign = new StringBuilder();
            stringToSign.AppendFormat("{0}-{1}\n{2}\n{3}\n", SCHEME, ALGORITHM, dateTime, scope);

            HashAlgorithm ha = HashAlgorithm.Create("SHA-256");
            byte[] canonicalRequestHashBytes = ha.ComputeHash(Encoding.UTF8.GetBytes(canonicalRequest));
            stringToSign.Append(ToHex(canonicalRequestHashBytes, true));

            KeyedHashAlgorithm kha = KeyedHashAlgorithm.Create(signingAlgorithm);
            kha.Key = ComposeSigningKey(signingAlgorithm, credentials.ClearSecretKey, credentials.SecureSecretKey, region, dateStamp, service);
            byte[] signature = kha.ComputeHash(Encoding.UTF8.GetBytes(stringToSign.ToString()));

            StringBuilder authorizationHeader = new StringBuilder();
            authorizationHeader.AppendFormat("{0}-{1} ", SCHEME, ALGORITHM);
            authorizationHeader.AppendFormat("Credential={0}/{1}, ", credentials.AccessKey, scope);
            authorizationHeader.AppendFormat("SignedHeaders={0}, ", GetSignedHeaders(headersToSign));
            authorizationHeader.AppendFormat("Signature={0}", ToHex(signature, true));

            return authorizationHeader.ToString();
        }

        #region Http signing helpers

        /// <summary>
        /// Helper function to format a byte array into string
        /// </summary>
        /// <param name="data">The data blob to process</param>
        /// <param name="lowercase">If true, returns hex digits in lower case form</param>
        /// <returns>String version of the data</returns>
        private static string ToHex(byte[] data, bool lowercase)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString(lowercase ? "x2" : "X2"));
            }

            return sb.ToString();
        }

        private static string DetermineRegion(ClientConfig clientConfig)
        {
            if (!string.IsNullOrEmpty(clientConfig.AuthenticationRegion))
                return clientConfig.AuthenticationRegion.ToLower();
            else
                return AWSSDKUtils.DetermineRegion(clientConfig.ServiceURL).ToLower();
        }

        private static string DetermineService(ClientConfig clientConfig)
        {
            if (!string.IsNullOrEmpty(clientConfig.AuthenticationServiceName))
                return clientConfig.AuthenticationServiceName.ToLower();
            else
                return AWSSDKUtils.DetermineService(clientConfig.ServiceURL).ToLower();
        }

        /// <summary>
        /// Compute and return the multi-stage signing key for the request.
        /// </summary>
        /// <param name="algorithm">Hashing algorithm to use</param>
        /// <param name="awsSecretAccessKey">The clear-text AWS secret key, if not held in secureKey</param>
        /// <param name="secureKey">SecureKey version of the AWS secret key, if not in clear text</param>
        /// <param name="region">The region in which the service request will be processed</param>
        /// <param name="date">Date of the request, in yyyyMMdd format</param>
        /// <param name="service">The name of the service being called by the request</param>
        /// <returns>Computed signing key</returns>
        private static byte[] ComposeSigningKey(string algorithm, string awsSecretAccessKey, SecureString secureKey, string region, string date, string service)
        {
            const string KsecretPrefix = "AWS4";
            IntPtr bstr = IntPtr.Zero;
            char[] Ksecret = null;

            try
            {
                if (string.IsNullOrEmpty(awsSecretAccessKey))
                {
                    Ksecret = new char[KsecretPrefix.Length + secureKey.Length];
                    Array.Copy(KsecretPrefix.ToCharArray(), 0, Ksecret, 0, KsecretPrefix.Length);

                    bstr = Marshal.SecureStringToBSTR(secureKey);
                    Marshal.Copy(bstr, Ksecret, KsecretPrefix.Length, secureKey.Length);
                }
                else
                {
                    Ksecret = (KsecretPrefix + awsSecretAccessKey).ToCharArray();
                }

                byte[] hashDate = ComputeHash(algorithm, Encoding.UTF8.GetBytes(Ksecret), Encoding.UTF8.GetBytes(date));
                byte[] hashRegion = ComputeHash(algorithm, hashDate, Encoding.UTF8.GetBytes(region));
                byte[] hashService = ComputeHash(algorithm, hashRegion, Encoding.UTF8.GetBytes(service));
                return ComputeHash(algorithm, hashService, Encoding.UTF8.GetBytes(TERMINATOR));
            }
            finally
            {
                // clean up all secrets, regardless of how initially seeded (for simplicity)
                if (Ksecret != null)
                    Array.Clear(Ksecret, 0, Ksecret.Length);

                if (bstr != IntPtr.Zero)
                    Marshal.ZeroFreeBSTR(bstr);
            }
        }

        /// <summary>
        /// Compute and return the hash of a data blob using the specified key
        /// </summary>
        /// <param name="algorithm">Algorithm to use for hashing</param>
        /// <param name="key">Hash key</param>
        /// <param name="data">Data blob</param>
        /// <returns>Hash of the data</returns>
        private static byte[] ComputeHash(string algorithm, byte[] key, byte[] data)
        {
            KeyedHashAlgorithm kha = KeyedHashAlgorithm.Create(algorithm);
            kha.Key = key;
            return kha.ComputeHash(data);
        }

        /// <summary>
        /// Computes and returns the canonical request
        /// </summary>
        /// <param name="headersToSign">Request headers that are to be included in the signature</param>
        /// <param name="serviceEndPoint">The endpoint to the service being called</param>
        /// <param name="headers">The full request headers</param>
        /// <param name="requestBody">The body of the request</param>
        /// <returns>Canonicalised request as a string</returns>
        private static string GetCanonicalRequest(List<string> headersToSign,
                                                  Uri serviceEndPoint,
                                                  IDictionary<string, string> headers,
                                                  string requestBody)
        {
            StringBuilder canonicalRequest = new StringBuilder("POST\n");
            canonicalRequest.AppendFormat("{0}\n", GetCanonicalizedResourcePath(serviceEndPoint));
            canonicalRequest.Append("\n");

            canonicalRequest.AppendFormat("{0}\n", GetCanonicalizedHeaders(headersToSign, headers));
            canonicalRequest.AppendFormat("{0}\n", GetSignedHeaders(headersToSign));

            HashAlgorithm ha = HashAlgorithm.Create("SHA-256");
            byte[] payloadHashBytes = ha.ComputeHash(Encoding.UTF8.GetBytes(requestBody));
            canonicalRequest.Append(ToHex(payloadHashBytes, true));
            return canonicalRequest.ToString();
        }

        /// <summary>
        /// Returns the canonicalized resource path for the service endpoint
        /// </summary>
        /// <param name="endpoint">Endpoint to the service</param>
        /// <returns>Canonicalized resource path for the endpoint</returns>
        private static string GetCanonicalizedResourcePath(Uri endpoint)
        {
            string uri = endpoint.AbsolutePath;
            return string.IsNullOrEmpty(uri) ? "/" : AWSSDKUtils.UrlEncode(uri, true);
        }

        /// <summary>
        /// Returns the set of headers included in the signature as a flattened, ;-delimited string
        /// </summary>
        /// <param name="headersToSign">The headers included in the signature</param>
        /// <returns>Flattened string of header name</returns>
        private static string GetSignedHeaders(List<string> headersToSign)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string header in headersToSign)
            {
                if (builder.Length > 0)
                    builder.Append(";");
                builder.Append(header.ToLower());
            }
            return builder.ToString();
        }

        /// <summary>
        /// Computes the canonical headers with values for the request. Only headers included in the signature
        /// are included in the canonicalization process.
        /// </summary>
        /// <param name="headersToSign">The set of headers required to be in the signature</param>
        /// <param name="allHeaders">All request headers</param>
        /// <returns>Canonicalized string of headers</returns>
        private static string GetCanonicalizedHeaders(List<string> headersToSign, IDictionary<string, string> allHeaders)
        {
            if (headersToSign == null || headersToSign.Count == 0)
                return string.Empty;

            for (int i = 0; i < headersToSign.Count; i++)
            {
                headersToSign[i] = headersToSign[i].ToLower();
            }

            SortedDictionary<string, string> sortedHeaderMap = new SortedDictionary<string, string>();
            foreach (var entry in allHeaders)
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

        /// <summary>
        /// Returns the request parameters in the form of a query string.
        /// </summary>
        /// <param name="request">The request instance</param>
        /// <returns>Request parameters in query string format</returns>
        private static string GetRequestPayload(IRequest request)
        {
            if (request.Content == null)
                return AWSSDKUtils.GetParametersAsString(request.Parameters);
            else
            {
                Encoding encoding = Encoding.GetEncoding(DEFAULT_ENCODING);
                return encoding.GetString(request.Content);
            }
        }

        /// <summary>
        /// Returns the set of headers on the request that should be included in the signing process,
        /// sorted into ascending order.
        /// </summary>
        /// <param name="requestHeaders">The set of proposed headers for the request</param>
        /// <returns>List of headers that must be included in the signature</returns>
        /// <remarks>For V2 signing, all headers are considered viable for inclusion</remarks>
        private static List<string> GetHeadersForSigning(IDictionary<string, string> requestHeaders)
        {
            List<string> headersToSign = new List<string>();
            foreach (var entry in requestHeaders)
            {
                headersToSign.Add(entry.Key);
            }

            headersToSign.Sort(StringComparer.OrdinalIgnoreCase);
            return headersToSign;
        }

        #endregion
    }
}
