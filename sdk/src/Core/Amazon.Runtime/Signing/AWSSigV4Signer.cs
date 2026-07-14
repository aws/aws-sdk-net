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
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// Signs arbitrary HTTP requests with AWS Signature Version 4.
    /// <para>
    /// This is a thin, supported facade over the SDK's internal SigV4 implementation. It supports
    /// header-based signing (which produces the headers to add to an outbound request) and
    /// presigned-URL (query-string) signing. It does not perform any HTTP I/O.
    /// </para>
    /// </summary>
    public static class AWSSigV4Signer
    {
        // 7 days is the maximum period for presigned url expiry with AWS4.
        private static readonly TimeSpan MaxPresignExpiry = TimeSpan.FromSeconds(AWS4PreSignedUrlSigner.MaxAWS4PreSignedUrlExpiry);

        // The session token is carried as this query parameter when presigning (the canonical,
        // capitalized form), versus the lowercase header key used for header signing.
        private const string XAmzSecurityTokenQueryParam = "X-Amz-Security-Token";

        #region Public API

        /// <summary>
        /// Signs the request with SigV4 and returns the headers to add to the outbound request.
        /// </summary>
        public static AWSSigningResult Sign(AWSSigningRequest request, AWSSigningParameters parameters)
        {
            ValidateArguments(request, parameters, presign: false);
            var credentials = parameters.Credentials.GetCredentials();
            return SignInternal(request, parameters, credentials);
        }

        /// <summary>
        /// Signs the request with SigV4 and returns the headers to add to the outbound request.
        /// The returned task awaits credential resolution; the signing computation itself is synchronous.
        /// </summary>
        public static async Task<AWSSigningResult> SignAsync(AWSSigningRequest request, AWSSigningParameters parameters, CancellationToken cancellationToken = default)
        {
            ValidateArguments(request, parameters, presign: false);
            var credentials = await parameters.Credentials.GetCredentialsAsync().ConfigureAwait(false);
            return SignInternal(request, parameters, credentials);
        }

        /// <summary>
        /// Produces a presigned URL (query-string signing) for the request, valid for <paramref name="expiry"/>.
        /// </summary>
        public static PresignResult Presign(AWSSigningRequest request, AWSSigningParameters parameters, TimeSpan expiry)
        {
            ValidateArguments(request, parameters, presign: true);
            ValidateExpiry(expiry);
            var credentials = parameters.Credentials.GetCredentials();
            return PresignInternal(request, parameters, expiry, credentials);
        }

        /// <summary>
        /// Produces a presigned URL (query-string signing) for the request, valid for <paramref name="expiry"/>.
        /// The returned task awaits credential resolution; the signing computation itself is synchronous.
        /// </summary>
        public static async Task<PresignResult> PresignAsync(AWSSigningRequest request, AWSSigningParameters parameters, TimeSpan expiry, CancellationToken cancellationToken = default)
        {
            ValidateArguments(request, parameters, presign: true);
            ValidateExpiry(expiry);
            var credentials = await parameters.Credentials.GetCredentialsAsync().ConfigureAwait(false);
            return PresignInternal(request, parameters, expiry, credentials);
        }

        #endregion

        #region Header signing

        private static AWSSigningResult SignInternal(AWSSigningRequest request, AWSSigningParameters parameters, ImmutableCredentials credentials)
        {
            var internalRequest = BuildRequest(request, parameters);

            // The session token must be covered by the signature, so add it as a header before signing.
            if (credentials.UseToken)
                internalRequest.Headers[HeaderKeys.XAmzSecurityTokenHeader] = credentials.Token;

            var config = new SigningStandaloneClientConfig();
            var signedAt = ResolveSignedAt(parameters, internalRequest);

            var signingResult = new AWS4Signer().SignRequest(internalRequest, config, new RequestMetrics(),
                credentials.AccessKey, credentials.SecretKey, signedAt);

            // SignRequest does not set Authorization on the request (only the Sign(...) wrapper does),
            // so read it off the result. The other signing headers were added onto the request.
            var authorization = signingResult.ForAuthorizationHeader;
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                [HeaderKeys.AuthorizationHeader] = authorization
            };
            CopyHeaderIfPresent(internalRequest.Headers, headers, HeaderKeys.XAmzDateHeader);
            CopyHeaderIfPresent(internalRequest.Headers, headers, HeaderKeys.XAmzContentSha256Header);
            CopyHeaderIfPresent(internalRequest.Headers, headers, HeaderKeys.XAmzSecurityTokenHeader);

            return new AWSSigningResult(headers, authorization);
        }

        #endregion

        #region Presigning

        private static PresignResult PresignInternal(AWSSigningRequest request, AWSSigningParameters parameters, TimeSpan expiry, ImmutableCredentials credentials)
        {
            var internalRequest = BuildRequest(request, parameters);

            // Presigning always emits query parameters (at minimum X-Amz-Expires and the SigV4 auth
            // params), so ensure the parameter collection is rendered into the URL by ComposeUrl.
            internalRequest.UseQueryString = true;

            // The presign signer canonicalizes X-Amz-Expires as a query parameter but does not add it
            // itself, so it must be present up front or the URL won't validate.
            internalRequest.Parameters[HeaderKeys.XAmzExpires] = ((long)expiry.TotalSeconds).ToString(CultureInfo.InvariantCulture);

            // For presigning the session token is carried as a query parameter, not a header.
            if (credentials.UseToken)
                internalRequest.Parameters[XAmzSecurityTokenQueryParam] = credentials.Token;

            var signedAt = ResolveSignedAt(parameters, internalRequest);

            // Pass the static overload with an explicit service and region. clientConfig is null because,
            // with overrideSigningRegion supplied, the signer never derives the region from it.
            var signingResult = AWS4PreSignedUrlSigner.SignRequest(internalRequest, null, new RequestMetrics(),
                credentials.AccessKey, credentials.SecretKey, parameters.Service, parameters.Region, signedAt);

            var baseUrl = AmazonServiceClient.ComposeUrl(internalRequest);
            var presignedUrl = new Uri(baseUrl.AbsoluteUri + "&" + signingResult.ForQueryParameters);

            var signedHeaders = BuildSignedHeaders(internalRequest.Headers, signingResult.SignedHeaders);

            return new PresignResult(presignedUrl, signedHeaders);
        }

        #endregion

        #region Shared helpers

        private static DefaultRequest BuildRequest(AWSSigningRequest request, AWSSigningParameters parameters)
        {
            var internalRequest = new DefaultRequest(new StandaloneSigningRequest(), parameters.Service)
            {
                HttpMethod = request.HttpMethod,
                Endpoint = new Uri(request.RequestUri.GetLeftPart(UriPartial.Authority)),
                ResourcePath = request.RequestUri.AbsolutePath,
                OverrideSigningServiceName = parameters.Service,
                AuthenticationRegion = parameters.Region,
                DisablePayloadSigning = !parameters.SignPayload,
            };

            // Copy caller headers into the request. A caller-supplied x-amz-content-sha256 is routed to
            // PrecomputedContentSha256 (below) rather than left on the header, so the signer honors it
            // instead of scrubbing it during InitializeHeaders/CleanHeaders.
            string precomputedHash = null;
            if (request.Headers != null)
            {
                foreach (var header in request.Headers)
                {
                    if (string.Equals(header.Key, HeaderKeys.XAmzContentSha256Header, StringComparison.OrdinalIgnoreCase))
                        precomputedHash = header.Value;
                    else
                        internalRequest.Headers[header.Key] = header.Value;
                }
            }

            // Parse any query string on the URI into the request's parameter collection. Query components
            // are URL-decoded here because the signer re-encodes them canonically during signing.
            if (!string.IsNullOrEmpty(request.RequestUri.Query))
            {
                internalRequest.UseQueryString = true;
                foreach (var kvp in AWSSDKUtils.ParseQueryParameters(request.RequestUri.Query))
                {
                    var key = Uri.UnescapeDataString(kvp.Key);
                    var value = kvp.Value == null ? null : Uri.UnescapeDataString(kvp.Value);
                    internalRequest.Parameters[key] = value;
                }
            }

            // Body handling (header signing only; the presign path rejects a body in ValidateArguments).
            if (request.Content != null)
            {
                internalRequest.Content = request.Content;
            }
            else if (request.ContentStream != null)
            {
                // When payload signing is enabled and the caller hasn't supplied a hash, the signer must be
                // able to read and rewind the stream. A non-seekable stream would otherwise silently sign
                // UNSIGNED-PAYLOAD, so fail loud instead.
                if (parameters.SignPayload && precomputedHash == null && !request.ContentStream.CanSeek)
                {
                    throw new ArgumentException(
                        "Cannot sign the payload of a non-seekable ContentStream. Supply the body as a byte[] Content, " +
                        "use a seekable stream, set an x-amz-content-sha256 header with a precomputed hash, or set SignPayload = false.");
                }

                internalRequest.ContentStream = request.ContentStream;
            }

            if (precomputedHash != null)
                internalRequest.PrecomputedContentSha256 = precomputedHash;

            return internalRequest;
        }

        private static DateTime ResolveSignedAt(AWSSigningParameters parameters, IRequest internalRequest)
        {
            return parameters.SignedAt.HasValue
                ? parameters.SignedAt.Value.ToUniversalTime()
                : CorrectClockSkew.GetCorrectedUtcNowForEndpoint(internalRequest.Endpoint.ToString());
        }

        private static void CopyHeaderIfPresent(IDictionary<string, string> source, IDictionary<string, string> destination, string key)
        {
            if (source.TryGetValue(key, out var value))
                destination[key] = value;
        }

        /// <summary>
        /// Builds the name→value map of headers that were included in the signature (excluding host,
        /// which is implicit). The signer result only carries the ';'-delimited signed-header names, so
        /// the values are looked up from the request headers that were actually signed.
        /// </summary>
        private static IReadOnlyDictionary<string, string> BuildSignedHeaders(IDictionary<string, string> requestHeaders, string signedHeaderNames)
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (string.IsNullOrEmpty(signedHeaderNames))
                return result;

            foreach (var name in signedHeaderNames.Split(';'))
            {
                if (string.Equals(name, HeaderKeys.HostHeader, StringComparison.OrdinalIgnoreCase))
                    continue;

                if (requestHeaders.TryGetValue(name, out var value))
                    result[name] = value;
            }

            return result;
        }

        #endregion

        #region Validation

        private static void ValidateArguments(AWSSigningRequest request, AWSSigningParameters parameters, bool presign)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));
            if (string.IsNullOrEmpty(request.HttpMethod))
                throw new ArgumentException("HttpMethod must be set.", nameof(request));
            if (request.RequestUri == null)
                throw new ArgumentException("RequestUri must be set.", nameof(request));
            if (!request.RequestUri.IsAbsoluteUri)
                throw new ArgumentException("RequestUri must be an absolute URI.", nameof(request));
            if (string.IsNullOrEmpty(parameters.Region))
                throw new ArgumentException("Region must be set.", nameof(parameters));
            if (string.IsNullOrEmpty(parameters.Service))
                throw new ArgumentException("Service must be set.", nameof(parameters));
            if (parameters.Credentials == null)
                throw new ArgumentException("Credentials must be set.", nameof(parameters));

            var hasPrecomputedHash = TryGetContentSha256Header(request.Headers, out _);

            // SignPayload is the outer gate. false + a precomputed hash express opposite intent; rather
            // than silently discard the hash, reject the contradiction.
            if (!parameters.SignPayload && hasPrecomputedHash)
                throw new ArgumentException(
                    "SignPayload is false but an x-amz-content-sha256 header was supplied. These are contradictory: " +
                    "SignPayload = false signs UNSIGNED-PAYLOAD and ignores any body hash. Remove one.");

            // UNSIGNED-PAYLOAD requires HTTPS (matches AWS4Signer.ValidateRequest); fail early with a clearer message.
            if (!parameters.SignPayload &&
                !string.Equals(request.RequestUri.Scheme, "https", StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("When SignPayload is false the request must be sent over HTTPS.", nameof(request));

            if (request.Content != null && request.ContentStream != null)
                throw new ArgumentException("Content and ContentStream are mutually exclusive; set at most one.", nameof(request));

            if (presign)
            {
                // The presign signer never reads the body (it canonicalizes UNSIGNED-PAYLOAD or the empty-body
                // SHA), so a supplied body would silently produce a URL that only validates for an empty body.
                if (request.Content != null || request.ContentStream != null)
                    throw new ArgumentException("Presigning a request with a body is not supported; Content and ContentStream must be null.", nameof(request));
                if (hasPrecomputedHash)
                    throw new ArgumentException("Presigning does not honor a precomputed x-amz-content-sha256 header; remove it.", nameof(request));
            }
        }

        private static void ValidateExpiry(TimeSpan expiry)
        {
            if (expiry <= TimeSpan.Zero || expiry > MaxPresignExpiry)
                throw new ArgumentOutOfRangeException(nameof(expiry), "Expiry must be greater than 0 and at most 7 days.");
        }

        private static bool TryGetContentSha256Header(IDictionary<string, string> headers, out string value)
        {
            value = null;
            if (headers == null)
                return false;

            foreach (var header in headers)
            {
                if (string.Equals(header.Key, HeaderKeys.XAmzContentSha256Header, StringComparison.OrdinalIgnoreCase))
                {
                    value = header.Value;
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
