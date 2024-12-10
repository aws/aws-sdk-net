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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.SharedInterfaces;
using Amazon.Util;
using Aws.Crt.Auth;
using Aws.Crt.Http;
using AWSSDK.Extensions.CrtIntegration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Amazon.Extensions.CrtIntegration
{
    /// <summary>
    /// Asymmetric Sigv4 (SigV4a) protocol signer using the implementation provided by Aws.Crt.Auth
    /// </summary>
    public class CrtAWS4aSigner : IAWSSigV4aProvider
    {
        /// <summary>
        /// Creates an instance CrtAWS4aSigner with the SignPayload set to true.
        /// </summary>
        public CrtAWS4aSigner() :
            this(true)
        { }

        /// <summary>
        /// Creates an instance of CrtAWS4aSigner
        /// </summary>
        /// <param name="signPayload">Boolean to generate the auth signature with the request payload.</param>
        public CrtAWS4aSigner(bool signPayload)
        {
            SignPayload = signPayload;
        }

        /// <summary>
        /// Boolean to generate the auth signature with the request payload.
        /// </summary>
        public bool SignPayload
        {
            get;
            private set;
        }

        /// <summary>
        /// Protocol for the requests being signed
        /// </summary>
        public ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        /// <summary>
        /// Calculates and signs the specified request using the Asymmetric SigV4 signing protocol 
        /// by using theAWS account credentials given in the method parameters. The resulting signature 
        /// is added to the request headers as 'Authorization'.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the 
        /// SigV4a protocol will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">Metrics for the request</param>
        /// <param name="credentials">The AWS credentials for the account making the service call</param>
        public void Sign(IRequest request,
                         IClientConfig clientConfig,
                         RequestMetrics metrics,
                         ImmutableCredentials credentials)
        {
            SignRequest(request, clientConfig, metrics, credentials);
        }

        /// <summary>
        /// Calculates the signature for the specified request using the Asymmetric SigV4 signing protocol
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the 
        /// SigV4a protocol will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">Metrics for the request</param>
        /// <param name="credentials">The AWS credentials for the account making the service call</param>
        /// <returns>AWS4aSigningResult for the given request</returns>
        public AWS4aSigningResult SignRequest(IRequest request,
                                              IClientConfig clientConfig,
                                              RequestMetrics metrics,
                                              ImmutableCredentials credentials)
        {
            var signedAt = AWS4Signer.InitializeHeaders(request.Headers, request.Endpoint);
            request.SignedAt = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());

            var serviceSigningName = !string.IsNullOrEmpty(request.OverrideSigningServiceName) 
                ? request.OverrideSigningServiceName 
                : AWS4Signer.DetermineService(clientConfig, request);
            if (serviceSigningName == "s3")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            var regionSet = AWS4Signer.DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);
            request.DeterminedSigningRegion = regionSet;
            AWS4Signer.SetXAmzTrailerHeader(request.Headers, request.TrailingHeaders);

            var signingConfig = PrepareCRTSigningConfig(
                AwsSignatureType.HTTP_REQUEST_VIA_HEADERS, 
                regionSet, 
                serviceSigningName, 
                signedAt, 
                credentials,
                request.UseDoubleEncoding);

            // If the request should use a fixed x-amz-content-sha256 header value, determine the appropriate one
            var fixedBodyHash = request.TrailingHeaders?.Count > 0
                ? AWS4Signer.V4aStreamingBodySha256WithTrailer
                : AWS4Signer.V4aStreamingBodySha256;

            signingConfig.SignedBodyValue = AWS4Signer.SetRequestBodyHash(request, SignPayload, fixedBodyHash, ChunkedUploadWrapperStream.V4A_SIGNATURE_LENGTH);

            var crtRequest = CrtHttpRequestConverter.ConvertToCrtRequest(request);
            var signingResult = AwsSigner.SignHttpRequest(crtRequest, signingConfig);

            var authorizationValue = Encoding.Default.GetString(signingResult.Get().Signature);
            var signedCrtRequest = signingResult.Get().SignedRequest;

            CrtHttpRequestConverter.CopyHeadersFromCrtRequest(request, signedCrtRequest);

            var dateStamp = AWS4Signer.FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat);
            var scope = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}", dateStamp, serviceSigningName, AWS4Signer.Terminator);

            AWS4aSigningResult result = new AWS4aSigningResult(
                credentials.AccessKey,
                signedAt,
                CrtHttpRequestConverter.ExtractSignedHeaders(signedCrtRequest),
                scope,
                regionSet,
                authorizationValue,
                serviceSigningName,
                "",
                credentials);

            return result;
        }

        /// /// <summary>
        /// Calculates the signature for the specified request using the Asymmetric SigV4  
        /// signing protocol in preparation for generating a presigned URL.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the 
        /// SigV4a protocol will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">Metrics for the request</param>
        /// <param name="credentials">The AWS credentials for the account making the service call</param>
        /// <param name="serviceSigningName">Service to sign the request for</param>
        /// <param name="overrideSigningRegion">Region to sign the request for</param>
        /// <returns>AWS4aSigningResult for the given request</returns>
        public AWS4aSigningResult Presign4a(IRequest request,
                                            IClientConfig clientConfig,
                                            RequestMetrics metrics,
                                            ImmutableCredentials credentials,
                                            string serviceSigningName,
                                            string overrideSigningRegion)
        {
            if (serviceSigningName == "s3")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            var signedAt = AWS4Signer.InitializeHeaders(request.Headers, request.Endpoint);
            request.SignedAt = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());
            var regionSet = overrideSigningRegion ?? AWS4Signer.DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);

            var signingConfig = PrepareCRTSigningConfig(
                AwsSignatureType.HTTP_REQUEST_VIA_QUERY_PARAMS, 
                regionSet, 
                serviceSigningName, 
                signedAt, 
                credentials,
                request.UseDoubleEncoding);

            if (AWS4PreSignedUrlSigner.ServicesUsingUnsignedPayload.Contains(serviceSigningName))
            {
                signingConfig.SignedBodyValue = AWS4Signer.UnsignedPayload;
            }
            else
            {
                signingConfig.SignedBodyValue = AWS4Signer.EmptyBodySha256;
            }

            // The expiration may have already be set in a header when marshalling the GetPreSignedUrlRequest -> IRequest
            if (request.Parameters != null && request.Parameters.ContainsKey(HeaderKeys.XAmzExpires))
            {
                signingConfig.ExpirationInSeconds = Convert.ToUInt64(request.Parameters[HeaderKeys.XAmzExpires]);
            }

            var crtRequest = CrtHttpRequestConverter.ConvertToCrtRequest(request);
            var signingResult = AwsSigner.SignHttpRequest(crtRequest, signingConfig);

            string authorizationValue = Encoding.Default.GetString(signingResult.Get().Signature);
            var dateStamp = AWS4Signer.FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat);
            var scope = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}", dateStamp, serviceSigningName, AWS4Signer.Terminator);

            AWS4aSigningResult result = new AWS4aSigningResult(
                credentials.AccessKey,
                signedAt,
                CrtHttpRequestConverter.ExtractSignedHeaders(signingResult.Get().SignedRequest),
                scope,
                regionSet,
                authorizationValue,
                serviceSigningName,
                signingResult.Get().SignedRequest.Uri,
                credentials);

            return result;
        }

        /// <summary>
        /// Signs one chunk of a request when transferring a payload using multiple chunks
        /// </summary>
        /// <param name="chunkBody">Content of the current chunk to sign</param>
        /// <param name="previousSignature">Signature of the previously signed chunk</param>
        /// <param name="headerSigningResult">Signing result for the "seed" signature consisting of headers</param>
        /// <returns>Signature of the current chunk</returns>
        public string SignChunk(Stream chunkBody, string previousSignature, AWS4aSigningResult headerSigningResult)
        {
            var signingConfig = PrepareCRTSigningConfig(AwsSignatureType.HTTP_REQUEST_CHUNK, headerSigningResult);
            signingConfig.SignedBodyHeader = AwsSignedBodyHeaderType.NONE;

            // The previous signature may be padded with '*' up to 144 characters, which is used 
            // when actually sending a chunk but not when calculating the next chunk's signature.
            previousSignature = previousSignature.TrimEnd('*');

            var signingResult = AwsSigner.SignChunk(chunkBody, Encoding.UTF8.GetBytes(previousSignature), signingConfig);
            return Encoding.UTF8.GetString(signingResult.Get().Signature);
        }

        /// <summary>
        /// Signs the final chunk containing trailing headers
        /// </summary>
        /// <param name="trailingHeaders">Trailing header keys and values</param>
        /// <param name="previousSignature">Signature of the previously signed chunk</param>
        /// <param name="headerSigningResult">Signing result for the "seed" signature consisting of headers</param>
        /// <returns>Signature of the trailing header chunk</returns>
        public string SignTrailingHeaderChunk(IDictionary<string, string> trailingHeaders, string previousSignature, AWS4aSigningResult headerSigningResult)
        {
            var signingConfig = PrepareCRTSigningConfig(AwsSignatureType.HTTP_REQUEST_TRAILING_HEADERS, headerSigningResult);
            signingConfig.SignedBodyHeader = AwsSignedBodyHeaderType.NONE;

            var headerArray = trailingHeaders.Select(kvp => new HttpHeader(kvp.Key, kvp.Value)).ToArray();

            // The previous signature may be padded with '*' up to 144 characters, which is used 
            // when actually sending a chunk but not when calculating the next chunk's signature.
            previousSignature = previousSignature.TrimEnd('*');

            var signingResult = AwsSigner.SignTrailingHeaders(headerArray, Encoding.UTF8.GetBytes(previousSignature), signingConfig);
            return Encoding.UTF8.GetString(signingResult.Get().Signature);
        }

        /// <summary>
        /// Helper function to set up an Aws.Crt.Auth.SigningConfig
        /// </summary>
        /// <param name="signatureType">Signature type</param>
        /// <param name="headerSigningResult">Signing result for the request's headers</param>
        /// <returns>Prepared CRT signing configuration</returns>
        public AwsSigningConfig PrepareCRTSigningConfig(AwsSignatureType signatureType, AWS4aSigningResult headerSigningResult)
        {
            return PrepareCRTSigningConfig(signatureType,
                headerSigningResult.RegionSet,
                headerSigningResult.Service,
                headerSigningResult.DateTime,
                headerSigningResult.Credentials,
                useDoubleEncoding: true);
        }

        /// <summary>
        /// Helper function to set up an Aws.Crt.Auth.SigningConfig
        /// </summary>
        /// <param name="signatureType">Signature type</param>
        /// <param name="region">Signing region</param>
        /// <param name="service">Service to sign the request for</param>
        /// <param name="signedAt">Timestamp to sign at</param>
        /// <param name="credentials">The AWS credentials for the account making the service call</param>
        /// <param name="useDoubleEncoding">Use double uri encoding when required</param>
        /// <returns>Prepared CRT signing configuration</returns>
        public AwsSigningConfig PrepareCRTSigningConfig(AwsSignatureType signatureType, string region, string service, DateTime signedAt, ImmutableCredentials credentials, bool useDoubleEncoding)
        {
            var signingConfig = new AwsSigningConfig
            {
                Algorithm = AwsSigningAlgorithm.SIGV4A,
                SignedBodyHeader = AwsSignedBodyHeaderType.X_AMZ_CONTENT_SHA256,
                SignatureType = signatureType,
                Region = region,
                Service = service,
                Timestamp = new DateTimeOffset(signedAt),
                Credentials = new Credentials(credentials.AccessKey, credentials.SecretKey, credentials.Token)
            };
            
            signingConfig.UseDoubleUriEncode = useDoubleEncoding;
            signingConfig.ShouldNormalizeUriPath = useDoubleEncoding;

            // The request headers aren't an input for chunked signing, so don't pass the callback that filters headers.
            var addCallback = signatureType != AwsSignatureType.HTTP_REQUEST_CHUNK && signatureType != AwsSignatureType.HTTP_REQUEST_TRAILING_HEADERS;
            if (addCallback)
            {
                signingConfig.ShouldSignHeader = ShouldSignHeader;
            }

            return signingConfig;
        }

        private readonly static List<byte[]> HeadersToIgnore = new List<byte[]>
        {
            Encoding.ASCII.GetBytes(HeaderKeys.XAmznTraceIdHeader),
            Encoding.ASCII.GetBytes(HeaderKeys.TransferEncodingHeader),
            Encoding.ASCII.GetBytes(HeaderKeys.AmzSdkInvocationId),
            Encoding.ASCII.GetBytes(HeaderKeys.AmzSdkRequest)
        };

        /// <summary>
        /// <para>
        /// Callback invoked by the CRT that determines whether the specified header should be signed.
        /// </para>
        /// <para>
        /// Similar to SigV4, we'll exclude headers that do not impact the final signature (for example, "amz-sdk-request" will
        /// be different for the same input in a retried request).
        /// </para>
        /// </summary>
        /// <remarks>
        /// Based on the example from the CRT repository: https://github.com/awslabs/aws-crt-dotnet/blob/v0.4.4/tests/SigningTest.cs#L40-L43
        /// </remarks>
        private static bool ShouldSignHeader(byte[] headerName, uint length)
        {
            var shouldBeSigned = !HeadersToIgnore.Any(x => x.SequenceEqual(headerName));
            return shouldBeSigned;
        }
    }
}
