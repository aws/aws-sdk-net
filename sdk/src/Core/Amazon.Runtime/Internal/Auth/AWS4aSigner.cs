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
using System.Linq;
using System.Text;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Identity;

#if !NET7_0_OR_GREATER
using System.Formats.Asn1;
#endif

using static Amazon.Runtime.Internal.Auth.AWS4Signer;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS4a protocol signer for service calls that transmit authorization in the header field "Authorization".
    /// </summary>
    public class AWS4aSigner : AbstractAWSSigner
    {
        internal const string Scheme = "AWS4A";

        /// <summary>
        /// Represents the elliptic curve used for signing requests with the AWS4a protocol.
        /// </summary>
        private static readonly ECCurve SigningCurve = ECCurve.NamedCurves.nistP256;
        /// <summary>
        /// Represents the value of <c>N-2</c>, where <c>N</c> is the order of the
        /// NIST P-256 curve group.
        /// </summary>
        private static readonly byte[] NMinus2 = new byte[] {
            0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00, 0x00, 0x00,
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
            0xBC, 0xE6, 0xFA, 0xAD, 0xA7, 0x17, 0x9E, 0x84,
            0xF3, 0xB9, 0xCA, 0xC2, 0xFC, 0x63, 0x25, 0x4F,
        };

        internal const SigningAlgorithm SignerAlgorithm = SigningAlgorithm.HmacSHA256;

        public AWS4aSigner()
            : this(true)
        {
        }

        public AWS4aSigner(bool signPayload)
        {
            SignPayload = signPayload;
        }

        public bool SignPayload { get; }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        /// <summary>
        /// Calculates and signs the specified request using the AWS4a signing protocol by using the
        /// AWS account credentials given in the method parameters. The resulting signature is added
        /// to the request headers as 'Authorization'. Parameters supplied in the request, either in
        /// the resource path as a query string or in the Parameters collection must not have been
        /// uri encoded. If they have, use the SignRequest method to obtain a signature.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="identity">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        public override void Sign(IRequest request,
                                  IClientConfig clientConfig,
                                  RequestMetrics metrics,
                                  BaseIdentity identity)
        {
            if (identity is not AWSCredentials credentials)
            {
                throw new AmazonClientException($"The identity parameter must be of type AWSCredentials for the signer {nameof(AWS4aSigner)}.");
            }

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials is null)
            {
                return;
            }

            var signingResult = SignRequest(request, clientConfig, metrics, immutableCredentials);
            request.AWS4aSignerResult = signingResult;
            request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
        }

        /// <summary>
        /// Calculates and signs the specified request using the AWS4a signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request.
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        /// </remarks>
        public AWS4aSigningResult SignRequest(IRequest request,
                                             IClientConfig clientConfig,
                                             RequestMetrics metrics,
                                             ImmutableCredentials credentials)
        {
            ValidateRequest(request);
            var signedAt = InitializeHeaders(request.Headers, request.Endpoint);

            var serviceSigningName = !string.IsNullOrEmpty(request.OverrideSigningServiceName)
                ? request.OverrideSigningServiceName
                : DetermineService(clientConfig, request);

            if (serviceSigningName == "s3")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            var region = DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);
            request.DeterminedSigningRegion = region;
            request.Headers[HeaderKeys.XAmzRegionSetHeader] = region;
            SetXAmzTrailerHeader(request.Headers, request.TrailingHeaders);

            var parametersToCanonicalize = GetParametersToCanonicalize(request);
            var canonicalParameters = CanonicalizeQueryParameters(parametersToCanonicalize);

            // If the request should use a fixed x-amz-content-sha256 header value, determine the appropriate one
            var bodySha = request.TrailingHeaders?.Count > 0
                ? V4aStreamingBodySha256WithTrailer
                : V4aStreamingBodySha256;

            var bodyHash = SetRequestBodyHash(request, SignPayload, bodySha, ChunkedUploadWrapperStream.V4A_SIGNATURE_LENGTH);
            var sortedHeaders = SortAndPruneHeaders(request.Headers);

            var canonicalRequest = CanonicalizeRequest(request.Endpoint,
                                                       request.ResourcePath,
                                                       request.HttpMethod,
                                                       sortedHeaders,
                                                       canonicalParameters,
                                                       bodyHash,
                                                       request.PathResources,
                                                       request.UseDoubleEncoding);
            metrics?.AddProperty(Metric.CanonicalRequest, canonicalRequest);
            request.SignatureVersion = SignatureVersion.SigV4a;
            return ComputeSignature(credentials,
                                    request.DeterminedSigningRegion,
                                    signedAt,
                                    serviceSigningName,
                                    CanonicalizeHeaderNames(sortedHeaders),
                                    canonicalRequest,
                                    metrics);
        }

        #region Public Signing Helpers

        /// <summary>
        /// Computes and returns an AWS4a signature for the specified canonicalized request
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="regionSet"></param>
        /// <param name="signedAt"></param>
        /// <param name="service"></param>
        /// <param name="signedHeaders"></param>
        /// <param name="canonicalRequest"></param>
        /// <returns></returns>
        public static AWS4aSigningResult ComputeSignature(ImmutableCredentials credentials,
                                                         string regionSet,
                                                         DateTime signedAt,
                                                         string service,
                                                         string signedHeaders,
                                                         string canonicalRequest)
        {
            return ComputeSignature(credentials, regionSet, signedAt, service, signedHeaders, canonicalRequest, null);
        }

        /// <summary>
        /// Computes and returns an AWS4a signature for the specified canonicalized request
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="regionSet"></param>
        /// <param name="signedAt"></param>
        /// <param name="service"></param>
        /// <param name="signedHeaders"></param>
        /// <param name="canonicalRequest"></param>
        /// <param name="metrics"></param>
        /// <returns></returns>
        public static AWS4aSigningResult ComputeSignature(ImmutableCredentials credentials,
                                                         string regionSet,
                                                         DateTime signedAt,
                                                         string service,
                                                         string signedHeaders,
                                                         string canonicalRequest,
                                                         RequestMetrics metrics)
        {
            var dateStamp = FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat);
            var scope = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}", dateStamp, service, Terminator);

            var stringToSignBuilder = new StringBuilder();
            stringToSignBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}\n{1}\n{2}\n",
                                             AWS4aAlgorithmTag,
                                             FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat),
                                             scope);

            var canonicalRequestHashBytes = AWS4Signer.ComputeHash(canonicalRequest);
            stringToSignBuilder.Append(AWSSDKUtils.ToHex(canonicalRequestHashBytes, true));

            metrics?.AddProperty(Metric.StringToSign, stringToSignBuilder);

            var stringToSign = stringToSignBuilder.ToString();
            var signature = AWSSDKUtils.ToHex(SignBlob(credentials, stringToSign), true);
            return new AWS4aSigningResult(credentials.AccessKey, signedAt, signedHeaders, scope, regionSet, signature, service, "", credentials);
        }

        /// <summary>
        /// Adds one to a large unsigned integer represented by a sequence of bytes in constant time.
        /// </summary>
        /// <remarks>
        /// Implementation adapted from <see href="https://github.com/awslabs/aws-c-auth/blob/e8360a65e0f3337d4ac827945e00c3b55a641a5f/source/key_derivation.c#L106-L189"/>.
        /// </remarks>
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static void AddOneConstantTime(byte[] data)
        {
            uint carry = 1;

            for (int i = 0; i < data.Length; i++)
            {
                int index = data.Length - i - 1;
                uint current_digit = data[index] + carry;
                carry = (current_digit >> 8) & 1;
                data[index] = (byte)(current_digit & 0xFF);
            }
        }

        /// <summary>
        /// Compares two byte arrays in constant time.
        /// </summary>
        /// <param name="lhs">The first byte array to compare.</param>
        /// <param name="rhs"> The second byte array to compare.</param>
        /// <exception cref="ArgumentException"><paramref name="lhs"/> and <paramref name="rhs"/> have a different length.</exception>
        /// <remarks>
        /// Implementation adapted from <see href="https://github.com/awslabs/aws-c-auth/blob/e8360a65e0f3337d4ac827945e00c3b55a641a5f/source/key_derivation.c#L191-L215"/>.
        /// </remarks>
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        private static int CompareConstantTime(byte[] lhs, byte[] rhs)
        {
            if (lhs.Length != rhs.Length)
                throw new ArgumentException("Arrays must be of equal length for constant time comparison.");

            byte gt = 0, eq = 0;

            for (int i = 0; i < lhs.Length; i++)
            {
                int lhs_digit = lhs[i];
                int rhs_digit = rhs[i];

                gt |= (byte)(((rhs_digit - lhs_digit) >> 31) & eq);
                eq &= (byte)((((lhs_digit ^ rhs_digit) - 1) >> 31) & 1);
            }

            return gt + gt + eq - 1;
        }

        /// <summary>
        /// Compute and return the signing key for the request.
        /// </summary>
        /// <param name="awsAccessKey">Access key credential.</param>
        /// <param name="awsSecretAccessKey">Secret access key credential.</param>
        /// <returns>Computed signing key</returns>
        public static ECDsa ComputeSigningKey(string awsAccessKey, string awsSecretAccessKey)
        {
            byte[] kvalue = null;
            byte[] ksecret = null;

            try
            {
                ksecret = Encoding.UTF8.GetBytes(Scheme + awsSecretAccessKey);

                // The key value is constructed as follows:
                // 0x00000001 || "AWS4-ECDSA-P256-SHA256" || 0x00 || AccessKeyId || CounterValue as uint8_t || 0x00000100(Length)
                kvalue = new byte[sizeof(uint) + AWS4aAlgorithmTag.Length + 1 + Encoding.UTF8.GetByteCount(awsAccessKey) + 1 + sizeof(uint)];
                int idx = 0;
                kvalue[idx + 3] = 1;
                idx += 4;
                idx += Encoding.UTF8.GetBytes(AWS4aAlgorithmTag, 0, AWS4aAlgorithmTag.Length, kvalue, idx);
                idx++;
                idx += Encoding.UTF8.GetBytes(awsAccessKey, 0, awsAccessKey.Length, kvalue, idx);
                ref byte counterValue = ref kvalue[idx++];
                kvalue[idx + 2] = 1;

                counterValue = 1;
                while (counterValue < 0xFF)
                {
                    byte[] kDerived = ComputeKeyedHash(SignerAlgorithm, ksecret, kvalue);
                    if (CompareConstantTime(kDerived, NMinus2) > 0)
                    {
                        // increment the counter value
                        counterValue++;
                        continue;
                    }

                    AddOneConstantTime(kDerived);
                    var ecdsa = ECDsa.Create(new ECParameters
                    {
                        Curve = SigningCurve,
                        D = kDerived,
                    });
                    Array.Clear(kDerived, 0, kDerived.Length);
                    return ecdsa;
                }

                throw new AmazonClientException("Failed to derive a SigV4a key for the request.");
            }
            finally
            {
                // clean up all secrets, regardless of how initially seeded (for simplicity)
                if (ksecret != null)
                    Array.Clear(ksecret, 0, ksecret.Length);
                if (kvalue != null)
                    Array.Clear(kvalue, 0, kvalue.Length);
            }
        }

        /// <summary>
        /// Returns the ECDSA signature for an arbitrary blob using the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials to use.</param>
        /// <param name="data">The data to sign.</param>
        public static byte[] SignBlob(ImmutableCredentials credentials, string data)
        {
            return SignBlob(credentials, Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// Returns the ECDSA signature for an arbitrary blob using the specified credentials.
        /// </summary>
        /// <param name="credentials">The credentials to use.</param>
        /// <param name="data">The data to sign.</param>
        public static byte[] SignBlob(ImmutableCredentials credentials, byte[] data)
        {
            var key = credentials.AWS4aSigningKey ??= ComputeSigningKey(credentials.AccessKey, credentials.SecretKey);
#if NET7_0_OR_GREATER
            return key.SignData(data, HashAlgorithmName.SHA256, DSASignatureFormat.Rfc3279DerSequence);
#else
            return ConvertToRfc3279DerSequence(key.SignData(data, HashAlgorithmName.SHA256));
#endif
        }

#if !NET7_0_OR_GREATER
        private static byte[] ConvertToRfc3279DerSequence(byte[] signature)
        {
            var writer = new AsnWriter(AsnEncodingRules.DER);
            writer.PushSequence();
            writer.WriteIntegerUnsigned(signature.AsSpan(0, signature.Length / 2)); // R value
            writer.WriteIntegerUnsigned(signature.AsSpan(signature.Length / 2)); // S value
            writer.PopSequence();
            return writer.Encode();
        }
#endif
        #endregion
    }

    /// <summary>
    /// AWS4a protocol signer for Amazon S3 presigned urls.
    /// </summary>
    public static class AWS4aPreSignedUrlSigner
    {
        // 7 days is the maximum period for presigned url expiry with AWS4a
        public const Int64 MaxAWS4aPreSignedUrlExpiry = 7 * 24 * 60 * 60;

        public static readonly IEnumerable<string> ServicesUsingUnsignedPayload = AWS4PreSignedUrlSigner.ServicesUsingUnsignedPayload;

        /// <summary>
        /// Calculates the AWS4a signature for a presigned url.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing. If the Expires parameter
        /// is present, it is renamed to 'X-Amz-Expires' before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        /// </remarks>
        public static AWS4aSigningResult SignRequest(IRequest request,
                                                         IClientConfig clientConfig,
                                                         RequestMetrics metrics,
                                                         ImmutableCredentials credentials)
        {
            var service = "s3";
            if (!string.IsNullOrEmpty(request.OverrideSigningServiceName))
                service = request.OverrideSigningServiceName;
            return SignRequest(request, clientConfig, metrics, credentials, service, null);
        }

        /// <summary>
        /// Calculates the AWS4a signature for a presigned url.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4a protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing. If the Expires parameter
        /// is present, it is renamed to 'X-Amz-Expires' before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="credentials">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <param name="service">
        /// The service to sign for
        /// </param>
        /// <param name="overrideSigningRegion">
        /// The region to sign to, if null then the region the client is configured for will be used.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        ///
        /// The X-Amz-Content-SHA256 is cleared out of the request.
        /// If the request is for S3 then the UNSIGNED_PAYLOAD value is used to generate the canonical request.
        /// If the request isn't for S3 then the empty body SHA is used to generate the canonical request.
        /// </remarks>
        public static AWS4aSigningResult SignRequest(IRequest request,
                                                 IClientConfig clientConfig,
                                                 RequestMetrics metrics,
                                                 ImmutableCredentials credentials,
                                                 string service,
                                                 string overrideSigningRegion)
        {
            if (service == "s3" || service == "s3express")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            // clean up any prior signature in the headers if resigning
            request.Headers.Remove(HeaderKeys.AuthorizationHeader);
            if (!request.Headers.ContainsKey(HeaderKeys.HostHeader))
            {
                var hostHeader = request.Endpoint.Host;
                if (!request.Endpoint.IsDefaultPort)
                    hostHeader += ":" + request.Endpoint.Port;
                request.Headers.Add(HeaderKeys.HostHeader, hostHeader);
            }

            var signedAt = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());
            request.SignedAt = signedAt;
            var regionSet = overrideSigningRegion ?? DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);

            // AWS4a presigned urls got S3 are expected to contain a 'UNSIGNED-PAYLOAD' magic string
            // during signing (other services use the empty-body sha)
            request.Headers.Remove(HeaderKeys.XAmzContentSha256Header);

            var sortedHeaders = SortAndPruneHeaders(request.Headers);
            var canonicalizedHeaderNames = CanonicalizeHeaderNames(sortedHeaders);

            var parametersToCanonicalize = GetParametersToCanonicalize(request);
            parametersToCanonicalize.Add(new KeyValuePair<string, string>(HeaderKeys.XAmzAlgorithm, AWS4aAlgorithmTag));
            parametersToCanonicalize.Add(new KeyValuePair<string, string>(HeaderKeys.XAmzRegionSetHeader, regionSet));
            var xAmzCredentialValue = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}/{3}",
                                                       credentials.AccessKey,
                                                       FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat),
                                                       service,
                                                       Terminator);
            parametersToCanonicalize.Add(new KeyValuePair<string, string>(HeaderKeys.XAmzCredential, xAmzCredentialValue));

            parametersToCanonicalize.Add(new KeyValuePair<string, string>(HeaderKeys.XAmzDateHeader, FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat)));
            parametersToCanonicalize.Add(new KeyValuePair<string, string>(HeaderKeys.XAmzSignedHeadersHeader, canonicalizedHeaderNames));

            var canonicalQueryParams = CanonicalizeQueryParameters(parametersToCanonicalize);

            var canonicalRequest = CanonicalizeRequest(request.Endpoint,
                                                       request.ResourcePath,
                                                       request.HttpMethod,
                                                       sortedHeaders,
                                                       canonicalQueryParams,
                                                       ServicesUsingUnsignedPayload.Contains(service) ? UnsignedPayload : EmptyBodySha256,
                                                       request.PathResources,
                                                       request.UseDoubleEncoding);
            metrics?.AddProperty(Metric.CanonicalRequest, canonicalRequest);

            return AWS4aSigner.ComputeSignature(credentials,
                                                regionSet,
                                                signedAt,
                                                service,
                                                canonicalizedHeaderNames,
                                                canonicalRequest,
                                                metrics);
        }
    }
}
