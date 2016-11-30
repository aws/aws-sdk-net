/*
 * Copyright 2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Polly.Model;
using Amazon.Polly.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Amazon.Polly
{
    /// <summary>
    /// Utility methods for synthesizing speech.
    /// </summary>
    public static class SynthesizeSpeechUtil
    {
        private const string LexiconNamesParameter = "LexiconNames";
        private const string HTTPS = "https";
        private const string HTTPGet = "GET";
        private const string XAmzExpires = "X-Amz-Expires";
        private const string PollyServiceName = "polly";
        private static readonly TimeSpan FifteenMinutes = TimeSpan.FromMinutes(15);

        /// <summary>
        /// Generate a presigned URL based on a <see cref="SynthesizeSpeechRequest"/>
        /// using the default configured credentials.
        /// </summary>
        /// <param name="region">The region for the URL.</param>
        /// <param name="request">The request to base the presigned URL on.</param>
        /// <returns></returns>
        public static string GeneratePresignedUrl(RegionEndpoint region, SynthesizeSpeechRequest request)
        {
            AWSCredentials credentials = FallbackCredentialsFactory.GetCredentials();
            return GeneratePresignedUrl(credentials, region, request);
        }

        /// <summary>
        /// Generate a presigned URL based on a <see cref="SynthesizeSpeechRequest"/>.
        /// </summary>
        /// <param name="credentials">The credentials to use in the presigned URL.</param>
        /// <param name="region">The region for the URL.</param>
        /// <param name="request">The request to base the presigned URL on.</param>
        /// <returns></returns>
        public static string GeneratePresignedUrl(AWSCredentials credentials, RegionEndpoint region, SynthesizeSpeechRequest request)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            if (region == null)
                throw new ArgumentNullException("region");

            if (request == null)
                throw new ArgumentNullException("request");

            // Marshall this request and prepare it to be signed
            var marshaller = new SynthesizeSpeechRequestMarshaller();
            var iRequest = marshaller.Marshall(request);
            iRequest.UseQueryString = true;
            iRequest.HttpMethod = HTTPGet;
            iRequest.Endpoint = new UriBuilder(HTTPS, region.GetEndpointForService(PollyServiceName).Hostname).Uri;
            iRequest.Parameters[XAmzExpires] = ((int)FifteenMinutes.TotalSeconds).ToString(CultureInfo.InvariantCulture);

            if (request.IsSetLexiconNames())
            {
                var sortedLexiconNames = new List<string>(request.LexiconNames);
                sortedLexiconNames.Sort(StringComparer.Ordinal);
                iRequest.Parameters[LexiconNamesParameter] = JsonMapper.ToJson(sortedLexiconNames);
            }

            if (request.IsSetOutputFormat())
                iRequest.Parameters["OutputFormat"] = request.OutputFormat.ToString();

            if (request.IsSetSampleRate())
                iRequest.Parameters["SampleRate"] = request.SampleRate.ToString();

            if (request.IsSetText())
                iRequest.Parameters["Text"] = request.Text;

            if (request.IsSetTextType())
                iRequest.Parameters["TextType"] = request.TextType.ToString();

            if (request.IsSetVoiceId())
                iRequest.Parameters["VoiceId"] = request.VoiceId;

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials.UseToken)
            {
                iRequest.Parameters[HeaderKeys.XAmzSecurityTokenHeader] = immutableCredentials.Token;
            }

            // Only the host header should be signed, and the signer adds that.
            // So clear out headers.
            iRequest.Headers.Clear();

            // Create presigned URL and assign it
            var signingResult = SynthesizeSpeechPresignedUrlSigner.SignSynthesizeSpeechRequest(iRequest, new RequestMetrics(),
                immutableCredentials.AccessKey, immutableCredentials.SecretKey, PollyServiceName, region.SystemName);

            var authorization = "&" + signingResult.ForQueryParameters;

            return ComposeUrl(iRequest) + authorization;
        }

        /// <summary>
        /// This method was copied from AmazonServiceClient and adapted for use with this Utility.
        /// TODO When the SDK supports arrays in request parameters use the new implementation and delete this method.
        /// </summary>
        /// <param name="iRequest"></param>
        /// <returns></returns>
        private static Uri ComposeUrl(IRequest iRequest)
        {
            Uri url = iRequest.Endpoint;
            var resourcePath = iRequest.ResourcePath;
            if (resourcePath == null)
                resourcePath = string.Empty;
            else
            {
                if (resourcePath.StartsWith("/", StringComparison.Ordinal))
                    resourcePath = resourcePath.Substring(1);
            }

            // Construct any sub resource/query parameter additions to append to the
            // resource path. Services like S3 which allow '?' and/or '&' in resource paths
            // should use SubResources instead of appending them to the resource path with
            // query string delimiters during request marshalling.

            var delim = "?";
            var sb = new StringBuilder();

            if (iRequest.SubResources.Count > 0)
            {
                foreach (var subResource in iRequest.SubResources)
                {
                    sb.AppendFormat("{0}{1}", delim, subResource.Key);
                    if (subResource.Value != null)
                        sb.AppendFormat("={0}", subResource.Value);
                    delim = "&";
                }
            }

            if (iRequest.UseQueryString && iRequest.Parameters.Count > 0)
            {
                var queryString = SynthesizeSpeechPresignedUrlSigner.CanonicalizeQueryParametersForSynthesizeSpeech(iRequest.Parameters, true);
                sb.AppendFormat("{0}{1}", delim, queryString);
            }


            if (AWSSDKUtils.HasBidiControlCharacters(resourcePath))
                throw new AmazonClientException(string.Format(CultureInfo.InvariantCulture,
                    "Target resource path [{0}] has bidirectional characters, which are not supported" +
                    "by System.Uri and thus cannot be handled by the .NET SDK.", resourcePath));

            var parameterizedPath = string.Concat(AWSSDKUtils.UrlEncode(resourcePath, true), sb);
            var uri = new Uri(url.AbsoluteUri + parameterizedPath);
            DontUnescapePathDotsAndSlashes(uri);
            return uri;
        }

        /// <summary>
        /// This method was copied  as-is from AmazonServiceClient.
        /// TODO When the SDK supports arrays in request parameters remove this method.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        private static void DontUnescapePathDotsAndSlashes(Uri uri)
        {
#if BCL
            // System.UriSyntaxFlags is internal
            const int UnEscapeDotsAndSlashes = 0x2000000;

            if (uri == null)
                throw new ArgumentNullException("uri");

            try
            {
                // currently prefer silent return than exceptions or log messages if reflection fails to
                // find the fields we need, otherwise we could generate a lot of noise if someone
                // runs on a platform without these fields
                FieldInfo fieldInfo = uri.GetType().GetField("m_Syntax", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fieldInfo == null)
                    return;

                var uriParser = fieldInfo.GetValue(uri);

                fieldInfo = typeof(UriParser).GetField("m_Flags", BindingFlags.Instance | BindingFlags.NonPublic);
                if (fieldInfo == null)
                    return;

                var uriSyntaxFlags = fieldInfo.GetValue(uriParser);
                uriSyntaxFlags = (int)uriSyntaxFlags & ~UnEscapeDotsAndSlashes;

                fieldInfo.SetValue(uriParser, uriSyntaxFlags);
            }
            catch (Exception)
            {
                // swallow the exception because this platform doesn't support the hack to fix the big in the Uri class.
            }
#endif
        }

        /// <summary>
        /// TODO When the SDK supports arrays in request parameters use the new implementation and delete this class.
        /// </summary>
        private class SynthesizeSpeechPresignedUrlSigner : AWS4PreSignedUrlSigner
        {
            private const string XAmzAlgorithm = "X-Amz-Algorithm";
            private const string XAmzCredential = "X-Amz-Credential";

            /// <summary>
            /// This method was copied from AWS4PreSignedUrlSigner.SignRequest and adapted for this utility.
            /// </summary>
            /// <param name="request"></param>
            /// <param name="metrics"></param>
            /// <param name="awsAccessKeyId"></param>
            /// <param name="awsSecretAccessKey"></param>
            /// <param name="service"></param>
            /// <param name="region"></param>
            /// <returns></returns>
            public static AWS4SigningResult SignSynthesizeSpeechRequest(IRequest request,
                                         RequestMetrics metrics,
                                         string awsAccessKeyId,
                                         string awsSecretAccessKey,
                                         string service,
                                         string region)
            {
                // clean up any prior signature in the headers if resigning
                request.Headers.Remove(HeaderKeys.AuthorizationHeader);
                if (!request.Headers.ContainsKey(HeaderKeys.HostHeader))
                {
                    var hostHeader = request.Endpoint.Host;
                    if (!request.Endpoint.IsDefaultPort)
                        hostHeader += ":" + request.Endpoint.Port;
                    request.Headers.Add(HeaderKeys.HostHeader, hostHeader);
                }

                var signedAt = AWSSDKUtils.CorrectedUtcNow;

                // AWS4 presigned urls got S3 are expected to contain a 'UNSIGNED-PAYLOAD' magic string
                // during signing (other services use the empty-body sha)
                if (request.Headers.ContainsKey(HeaderKeys.XAmzContentSha256Header))
                    request.Headers.Remove(HeaderKeys.XAmzContentSha256Header);

                var sortedHeaders = SortHeaders(request.Headers);
                var canonicalizedHeaderNames = CanonicalizeHeaderNames(sortedHeaders);

                var parametersToCanonicalize = GetParametersToCanonicalize(request);
                parametersToCanonicalize.Add(XAmzAlgorithm, AWS4AlgorithmTag);
                parametersToCanonicalize.Add(XAmzCredential,
                                             string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}/{3}/{4}",
                                                           awsAccessKeyId,
                                                           FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat),
                                                           region,
                                                           service,
                                                           Terminator));

                parametersToCanonicalize.Add(HeaderKeys.XAmzDateHeader, FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat));
                parametersToCanonicalize.Add(HeaderKeys.XAmzSignedHeadersHeader, canonicalizedHeaderNames);

                var canonicalQueryParams = CanonicalizeQueryParametersForSynthesizeSpeech(parametersToCanonicalize, true);

                var canonicalRequest = CanonicalizeRequest(request.Endpoint,
                                                           request.ResourcePath,
                                                           request.HttpMethod,
                                                           sortedHeaders,
                                                           canonicalQueryParams,
                                                           service == "s3" ? UnsignedPayload : EmptyBodySha256);
                if (metrics != null)
                    metrics.AddProperty(Metric.CanonicalRequest, canonicalRequest);

                return ComputeSignature(awsAccessKeyId,
                                        awsSecretAccessKey,
                                        region,
                                        signedAt,
                                        service,
                                        canonicalizedHeaderNames,
                                        canonicalRequest,
                                        metrics);
            }

            /// <summary>
            /// This method was copied from AWS4PreSignedUrlSigner.CanonicalizeQueryParameters and adapted for this utility.
            /// </summary>
            /// <param name="parameters"></param>
            /// <param name="uriEncodeParameters"></param>
            /// <returns></returns>
            public static string CanonicalizeQueryParametersForSynthesizeSpeech(IDictionary<string, string> parameters,
                bool uriEncodeParameters)
            {
                if (parameters == null || parameters.Count == 0)
                    return string.Empty;

                var canonicalQueryString = new StringBuilder();
                var queryParams = new SortedDictionary<string, string>(parameters, StringComparer.Ordinal);
                foreach (var p in queryParams)
                {
                    if (canonicalQueryString.Length > 0)
                        canonicalQueryString.Append("&");

                    if (string.Equals(LexiconNamesParameter, p.Key, StringComparison.Ordinal))
                        AppendLexiconNamesParameter(canonicalQueryString, p.Value, uriEncodeParameters);
                    else
                    {
                        if (uriEncodeParameters)
                        {
                            if (string.IsNullOrEmpty(p.Value))
                                canonicalQueryString.AppendFormat("{0}=", AWSSDKUtils.UrlEncode(p.Key, false));
                            else
                                canonicalQueryString.AppendFormat("{0}={1}", AWSSDKUtils.UrlEncode(p.Key, false), AWSSDKUtils.UrlEncode(p.Value, false));
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(p.Value))
                                canonicalQueryString.AppendFormat("{0}=", p.Key);
                            else
                                canonicalQueryString.AppendFormat("{0}={1}", p.Key, p.Value);
                        }
                    }
                }

                return canonicalQueryString.ToString();
            }

            private static void AppendLexiconNamesParameter(StringBuilder canonicalQueryString, string jsonArray, bool uriEncodeParameters)
            {
                var startingLength = canonicalQueryString.Length;
                var lexiconNames = JsonMapper.ToObject<List<string>>(jsonArray);
                foreach(var lexiconName in lexiconNames)
                {
                    if (canonicalQueryString.Length > startingLength)
                        canonicalQueryString.Append("&");

                    if (uriEncodeParameters)
                    {
                        if (string.IsNullOrEmpty(lexiconName))
                            canonicalQueryString.AppendFormat("{0}=", AWSSDKUtils.UrlEncode(LexiconNamesParameter, false));
                        else
                            canonicalQueryString.AppendFormat("{0}={1}", AWSSDKUtils.UrlEncode(LexiconNamesParameter, false),
                                AWSSDKUtils.UrlEncode(lexiconName, false));
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(lexiconName))
                            canonicalQueryString.AppendFormat("{0}=", LexiconNamesParameter);
                        else
                            canonicalQueryString.AppendFormat("{0}={1}", LexiconNamesParameter, lexiconName);
                    }
                }
            }
        }

    }
}
