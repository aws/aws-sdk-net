/*
 * Copyright 2016-2017 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using System;
using System.Globalization;

namespace Amazon.Polly
{
    /// <summary>
    /// Utility methods for synthesizing speech.
    /// </summary>
    public static class SynthesizeSpeechUtil
    {
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
                iRequest.ParameterCollection.Add("LexiconNames", request.LexiconNames);

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

            if (request.IsSetSpeechMarkTypes())
                iRequest.ParameterCollection.Add("SpeechMarkTypes", request.SpeechMarkTypes);

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials.UseToken)
            {
                // Don't use HeaderKeys.XAmzSecurityTokenHeader because Polly treats this as case-sensitive
                iRequest.Parameters["X-Amz-Security-Token"] = immutableCredentials.Token;
            }

            // Only the host header should be signed, and the signer adds that.
            // So clear out headers.
            iRequest.Headers.Clear();

            // Create presigned URL and assign it
            var signingResult = AWS4PreSignedUrlSigner.SignRequest(iRequest, null, new RequestMetrics(),
                immutableCredentials.AccessKey, immutableCredentials.SecretKey, PollyServiceName, region.SystemName);

            var authorization = "&" + signingResult.ForQueryParameters;

            return AmazonServiceClient.ComposeUrl(iRequest).AbsoluteUri + authorization;
        }
    }
}
