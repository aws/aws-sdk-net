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
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// Signs arbitrary HTTP requests with AWS Signature Version 4.
    /// <para>
    /// Supports header-based signing (which produces the headers to add to an outbound request) and
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

        // The config only exists to satisfy AWS4Signer's IClientConfig parameter; it carries no per-request
        // state (region and service are forced onto the request), so a single shared instance is reused for
        // the header-signing path instead of allocating one per call. The presign path passes null.
        private static readonly SigningStandaloneClientConfig SharedConfig = new SigningStandaloneClientConfig();

        #region Public API

        /// <summary>
        /// Signs the request with SigV4 and returns the headers to add to the outbound request.
        /// </summary>
        public static AWSSigningResult Sign(AWSSigningRequest request, AWSSigV4Parameters parameters)
        {
            ValidateArguments(request, parameters, presign: false);
            parameters = ResolveRegion(parameters);
            var credentials = ResolveCredentials(parameters).GetCredentials();
            return SignInternal(request, parameters, credentials);
        }

        /// <summary>
        /// Signs the request with SigV4 and returns the headers to add to the outbound request.
        /// The returned task awaits credential resolution; the signing computation itself is synchronous.
        /// </summary>
        public static async Task<AWSSigningResult> SignAsync(AWSSigningRequest request, AWSSigV4Parameters parameters, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ValidateArguments(request, parameters, presign: false);
            parameters = ResolveRegion(parameters);
            var credentials = await ResolveCredentials(parameters).GetCredentialsAsync().ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested();
            return SignInternal(request, parameters, credentials);
        }

        /// <summary>
        /// Produces a presigned URL (query-string signing) for the request, valid for <paramref name="expiry"/>.
        /// </summary>
        public static PresignResult Presign(AWSSigningRequest request, AWSSigV4Parameters parameters, TimeSpan expiry)
        {
            ValidateArguments(request, parameters, presign: true);
            ValidateExpiry(expiry);
            parameters = ResolveRegion(parameters);
            var credentials = ResolveForPresign(ResolveCredentials(parameters), expiry);
            return PresignInternal(request, parameters, expiry, credentials);
        }

        /// <summary>
        /// Produces a presigned URL (query-string signing) for the request, valid for <paramref name="expiry"/>.
        /// The returned task awaits credential resolution; the signing computation itself is synchronous.
        /// </summary>
        public static async Task<PresignResult> PresignAsync(AWSSigningRequest request, AWSSigV4Parameters parameters, TimeSpan expiry, CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ValidateArguments(request, parameters, presign: true);
            ValidateExpiry(expiry);
            parameters = ResolveRegion(parameters);
            var credentials = await ResolveForPresignAsync(ResolveCredentials(parameters), expiry).ConfigureAwait(false);
            cancellationToken.ThrowIfCancellationRequested();
            return PresignInternal(request, parameters, expiry, credentials);
        }

        #endregion

        #region Header signing

        private static AWSSigningResult SignInternal(AWSSigningRequest request, AWSSigV4Parameters parameters, ImmutableCredentials credentials)
        {
            EnsureCredentialsResolved(credentials);
            var internalRequest = BuildRequest(request, parameters);

            // The session token must be covered by the signature, so add it as a header before signing.
            if (credentials.UseToken)
                internalRequest.Headers[HeaderKeys.XAmzSecurityTokenHeader] = credentials.Token;

            var config = SharedConfig;
            var signedAt = ResolveSignedAt(parameters, internalRequest);

            // The service-specific path handling is done in BuildRequest (S3 gets the decoded path, non-S3 the
            // encoded path); both then take the same single-pass canonicalization here.
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

            return new AWSSigningResult(headers);
        }

        #endregion

        #region Presigning

        private static PresignResult PresignInternal(AWSSigningRequest request, AWSSigV4Parameters parameters, TimeSpan expiry, ImmutableCredentials credentials)
        {
            EnsureCredentialsResolved(credentials);
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
            // with overrideSigningRegion supplied, the signer never derives the region from it. That also
            // means the signer uses this region verbatim (no normalization), so lowercase it here to match
            // the header path — which routes the region through AWS4Signer.DetermineSigningRegion, where
            // AuthenticationRegion is lowercased. Without this, a RegionEndpoint whose SystemName is
            // mixed-case (e.g. built via GetBySystemName("US-EAST-1")) would produce a presigned URL whose
            // credential-scope region the service rejects.
            var region = parameters.Region.SystemName.ToLowerInvariant();

            // Path handling is service-specific in BuildRequest (S3 decoded, non-S3 encoded); both take the
            // same single-pass canonicalization here.
            var signingResult = AWS4PreSignedUrlSigner.SignRequest(internalRequest, null, new RequestMetrics(),
                credentials.AccessKey, credentials.SecretKey, parameters.Service, region, signedAt);

            // Build the presigned URL's WIRE path from the caller's RequestUri verbatim, not from ComposeUrl.
            // The wire path is always the caller's encoded path; the service recomputes its own canonical path
            // from it (one encode pass for non-S3; decode-then-one-pass for S3) and compares to the signature,
            // which we computed over that same canonical form (see BuildRequest). ComposeUrl, however, runs its
            // own encode pass on the {Path+} value (double-encoding it), so we take only its rendered query
            // string and pair it with the verbatim wire path.
            var composed = AmazonServiceClient.ComposeUrl(internalRequest).AbsoluteUri;
            var queryStart = composed.IndexOf('?');
            // The rendered query (when present) includes its leading '?'. Presigning always adds X-Amz-Expires as
            // a query parameter with UseQueryString = true, so ComposeUrl renders a query today and queryStart is
            // always >= 0. Still, join defensively: the SigV4 auth params attach with '&' when a query is already
            // present and with '?' when it is not, so a future change that drops the query can't emit a malformed
            // URL ("path&X-Amz-Algorithm=..." with an '&' where the query should start).
            var query = queryStart >= 0 ? composed.Substring(queryStart) : string.Empty;
            var authority = request.RequestUri.GetLeftPart(UriPartial.Authority);
            var separator = query.Length > 0 ? "&" : "?";
            var presignedUrl = new Uri(authority + request.RequestUri.AbsolutePath + query + separator + signingResult.ForQueryParameters);

            var signedHeaders = BuildSignedHeaders(internalRequest.Headers, signingResult.SignedHeaders);

            return new PresignResult(presignedUrl, signedHeaders);
        }

        #endregion

        #region Shared helpers

        private static DefaultRequest BuildRequest(AWSSigningRequest request, AWSSigV4Parameters parameters)
        {
            var internalRequest = new DefaultRequest(new StandaloneSigningRequest(), parameters.Service)
            {
                HttpMethod = request.HttpMethod.Method,

                // DefaultRequest keeps the origin (scheme + host + port) and the path in separate fields:
                // ComposeUrl later rebuilds the URL as Endpoint.AbsoluteUri + ResourcePath + query, so
                // Endpoint must be authority-only or the path would be duplicated. Split the caller's URI
                // accordingly. GetLeftPart(UriPartial.Authority) yields exactly the origin and, importantly,
                // omits a default port while keeping a non-default one — matching what belongs in the signed
                // Host header. e.g. for "https://host.example.com:8443/prod/items?x=1":
                //   Endpoint     = "https://host.example.com:8443"   (":443" would be dropped as the default)
                //   ResourcePath = "/prod/items"                     (the query is parsed separately, below)
                // (The SDK's own RedirectHandler does the same split via UriBuilder + an IsDefaultPort branch;
                // GetLeftPart collapses that into one call.)
                Endpoint = new Uri(request.RequestUri.GetLeftPart(UriPartial.Authority)),

                // The path is supplied as a single greedy path-resource ({Path+}) rather than set directly on
                // ResourcePath. A plain ResourcePath string is treated as Literal segments and encoded with the
                // lenient path encoder, which leaves sub-delims like '+' '=' ',' unencoded — but the SigV4
                // canonical form requires them strict-encoded (e.g. "+" -> "%2B", "=" -> "%3D"). A path-resource
                // value is a Label segment and gets the strict encoder, exactly as the generated S3 client
                // encodes an object key ("/{Key+}"). The "+" suffix is greedy so real '/' separators stay
                // segment boundaries. The value bound to {Path+} is set below (encoded for non-S3, decoded for
                // S3); see the comment there.
                ResourcePath = "/{Path+}",
                OverrideSigningServiceName = parameters.Service,
                AuthenticationRegion = parameters.Region.SystemName,
                DisablePayloadSigning = !parameters.SignPayload,

                // Single-pass (non-double) encoding for both S3 and non-S3 — the one pass that the greedy
                // {Path+} label encoder always applies. Combined with the path value chosen below this
                // reproduces each service's canonical path exactly (see below).
                UseDoubleEncoding = false,
            };

            // Bind the {Path+} placeholder to the path the target service canonicalizes, then let the single
            // label-encode pass produce the canonical path.
            //
            //   non-S3: the service applies one URL-encode pass over the ENCODED wire path it receives. So feed
            //           Uri.AbsolutePath (the encoded wire path) unchanged; one pass yields the service's
            //           canonical form (e.g. wire "/hello%20world" -> canonical "/hello%2520world", and an
            //           encoded slash "%2F" is preserved and re-encoded to "%252F", matching execute-api).
            //
            //   S3:     the service DECODES the wire path before signing (e.g. it reads "%2F" as a literal '/'
            //           and "%20" as a space), so its canonical path is one URL-encode of the DECODED key. Feed
            //           the decoded path so the single pass reproduces that (wire "/a%2Fb" -> decoded "/a/b" ->
            //           canonical "/a/b"; wire "/hello%20world" -> decoded "/hello world" -> "/hello%20world").
            //           This is exactly how the generated S3 client signs an object key (raw key bound to
            //           "/{Key+}" with double-encoding off). Signing the encoded "%2F" verbatim would be rejected
            //           by S3 (SignatureDoesNotMatch) because S3's own canonical path is the decoded "/a/b".
            var path = request.RequestUri.AbsolutePath;
            if (IsS3(parameters.Service))
                path = Uri.UnescapeDataString(path);
            if (path.StartsWith("/", StringComparison.Ordinal))
                path = path.Substring(1);
            internalRequest.AddPathResource("{Path+}", path);

            // Copy caller headers into the request. A caller-supplied x-amz-content-sha256 is routed to
            // PrecomputedContentSha256 (below) rather than left on the header, so the signer honors it
            // instead of scrubbing it during InitializeHeaders/CleanHeaders.
            string precomputedHash = null;
            foreach (var header in request.Headers)
            {
                if (string.Equals(header.Key, HeaderKeys.XAmzContentSha256Header, StringComparison.OrdinalIgnoreCase))
                    precomputedHash = header.Value;
                else
                    internalRequest.Headers[header.Key] = header.Value;
            }

            // Parse any query string on the URI into the request's parameter collection. Query components
            // are URL-decoded here because the signer re-encodes them canonically during signing.
            //
            // We parse manually rather than via AWSSDKUtils.ParseQueryParameters because that helper returns
            // a name-keyed dictionary (last-value-wins), which would silently drop repeated keys (?x=1&x=2)
            // and lose the distinction between a valueless flag (?acl) and an empty value. Both must be
            // preserved so the signed canonical query matches what is sent on the wire.
            if (!string.IsNullOrEmpty(request.RequestUri.Query))
            {
                internalRequest.UseQueryString = true;
                foreach (var pair in ParseQueryParameters(request.RequestUri.Query))
                    AddQueryParameter(internalRequest.ParameterCollection, pair.Key, pair.Value);
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
                if (parameters.SignPayload && string.IsNullOrWhiteSpace(precomputedHash) && !request.ContentStream.CanSeek)
                {
                    throw new ArgumentException(
                        "Cannot sign the payload of a non-seekable ContentStream. Supply the body as a byte[] Content, " +
                        "use a seekable stream, set an x-amz-content-sha256 header with a precomputed hash, or set SignPayload = false.");
                }

                internalRequest.ContentStream = request.ContentStream;
            }

            // A blank (empty or whitespace-only) x-amz-content-sha256 is treated as "not supplied": the
            // downstream signer ignores such a value (its own IsNullOrEmpty check), so honoring it here would
            // bypass the non-seekable guard above and let signing silently downgrade to UNSIGNED-PAYLOAD.
            if (!string.IsNullOrWhiteSpace(precomputedHash))
                internalRequest.PrecomputedContentSha256 = precomputedHash;

            return internalRequest;
        }

        /// <summary>
        /// Whether the signing service is part of the S3 family, which decodes the wire path before computing
        /// the canonical path it signs (so the facade feeds the decoded path — see BuildRequest), rather than
        /// canonicalizing the encoded wire path the way every other service does.
        /// <para>
        /// The S3 family is exactly <see cref="AWS4PreSignedUrlSigner.ServicesUsingUnsignedPayload"/> ("s3", "s3express",
        /// "s3-object-lambda", "s3-outposts") — the same set the internal signer special-cases — reused here as
        /// the single source of truth so the two cannot drift. Matching only "s3"/"s3express" would send
        /// "s3-object-lambda"/"s3-outposts" down the non-S3 path, canonicalizing a special-character key the
        /// wrong way and producing a SignatureDoesNotMatch. Compared case-insensitively; AWS service names are
        /// lowercase, but this is lenient for callers who capitalize.
        /// </para>
        /// </summary>
        private static bool IsS3(string service)
        {
            foreach (var s3Service in AWS4PreSignedUrlSigner.ServicesUsingUnsignedPayload)
            {
                if (string.Equals(service, s3Service, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Splits a raw query string ("?a=1&amp;a=2&amp;flag") into decoded (key, value) pairs, preserving repeated
        /// keys and distinguishing a valueless flag (value == null) from an empty value. Order is preserved;
        /// the signer sorts for canonicalization.
        /// <para>
        /// Not <c>AWSSDKUtils.ParseQueryParameters</c>: that helper returns a name-keyed (last-value-wins)
        /// dictionary, which drops repeated keys and the flag-vs-empty-value distinction this must preserve.
        /// Exposed as <c>internal</c> (via InternalsVisibleTo) so the parity tests parse query strings the
        /// same way rather than duplicating this logic.
        /// </para>
        /// <para>
        /// Decoding uses <see cref="WebUtility.UrlDecode"/> (application/x-www-form-urlencoded semantics), which
        /// treats a literal '+' in the query as a space. This matches how AWS services and the other AWS SDKs
        /// (JS, Java, botocore) interpret the query when they recompute the canonical form: a wire query of
        /// "?q=a+b" is signed as "q=a%20b". A caller who wants a literal plus must percent-encode it as "%2B",
        /// which decodes back to '+' and is signed as "q=a%2Bb". Using Uri.UnescapeDataString here instead would
        /// leave the '+' literal and sign "q=a%2Bb" for a wire "+", which the service rejects with
        /// SignatureDoesNotMatch (verified against live STS).
        /// </para>
        /// </summary>
        internal static IEnumerable<KeyValuePair<string, string>> ParseQueryParameters(string query)
        {
            var start = query.IndexOf('?');
            var qs = start >= 0 ? query.Substring(start + 1) : query;

            foreach (var token in qs.Split('&'))
            {
                if (token.Length == 0)
                    continue;

                var eq = token.IndexOf('=');
                if (eq < 0)
                    yield return new KeyValuePair<string, string>(WebUtility.UrlDecode(token), null);
                else
                    yield return new KeyValuePair<string, string>(
                        WebUtility.UrlDecode(token.Substring(0, eq)),
                        WebUtility.UrlDecode(token.Substring(eq + 1)));
            }
        }

        /// <summary>
        /// Adds a query parameter to the collection, accumulating repeated keys into a list so no value is
        /// lost. A valueless flag is stored as an empty string, which canonicalizes as "key=" — matching how
        /// the service canonicalizes a bare "?key" on the wire.
        /// </summary>
        private static void AddQueryParameter(ParameterCollection parameters, string key, string value)
        {
            var normalized = value ?? string.Empty;

            if (!parameters.TryGetValue(key, out var existing))
            {
                parameters.Add(key, normalized);
                return;
            }

            // A key already present: promote to a list (or append to the existing list) so repeated query
            // keys are all signed rather than collapsed to the last value. This method is the only code that
            // populates the collection and only ever stores these two types, so any other type is a broken
            // invariant — fail loud rather than silently drop the value from the signature.
            if (existing is StringListParameterValue list)
                list.Value.Add(normalized);
            else if (existing is StringParameterValue single)
                parameters[key] = new StringListParameterValue(new List<string> { single.Value, normalized });
            else
                throw new InvalidOperationException(
                    $"Query parameter '{key}' has unexpected value type '{existing?.GetType().Name ?? "null"}'; " +
                    $"expected {nameof(StringParameterValue)} or {nameof(StringListParameterValue)}.");
        }

        private static DateTime ResolveSignedAt(AWSSigV4Parameters parameters, IRequest internalRequest)
        {
            return parameters.SignedAt.HasValue
                ? parameters.SignedAt.Value.ToUniversalTime()
                : CorrectClockSkew.GetCorrectedUtcNowForEndpoint(internalRequest.Endpoint.ToString());
        }

        /// <summary>
        /// Resolves credentials for presigning. For <see cref="RefreshingAWSCredentials"/> (e.g. assume-role or
        /// SSO), this forces a refresh when the current credentials would expire within the presign window, so
        /// the URL stays valid for as much of its stated lifetime as the credentials session allows. This
        /// mirrors the RDS/DSQL auth-token generators. Note: a URL signed with temporary credentials still
        /// cannot outlive the credentials session, regardless of the requested expiry.
        /// </summary>
        private static ImmutableCredentials ResolveForPresign(AWSCredentials credentials, TimeSpan expiry)
        {
            return credentials is RefreshingAWSCredentials refreshing
                ? refreshing.GetCredentials(expiry)
                : credentials.GetCredentials();
        }

        /// <inheritdoc cref="ResolveForPresign"/>
        private static async Task<ImmutableCredentials> ResolveForPresignAsync(AWSCredentials credentials, TimeSpan expiry)
        {
            return credentials is RefreshingAWSCredentials refreshing
                ? await refreshing.GetCredentialsAsync(expiry).ConfigureAwait(false)
                : await credentials.GetCredentialsAsync().ConfigureAwait(false);
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
        private static IDictionary<string, string> BuildSignedHeaders(IDictionary<string, string> requestHeaders, string signedHeaderNames)
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

        // Return parameters whose Region is set, falling back to the ambient region (env var, profile, IMDS)
        // when the caller left it null — matching how the service clients resolve a missing region. The
        // caller's object is never mutated; a shallow copy carries the resolved region. Throws only when no
        // region can be determined at all.
        private static AWSSigV4Parameters ResolveRegion(AWSSigV4Parameters parameters)
        {
            if (parameters.Region != null)
                return parameters;

            var region = FallbackRegionFactory.GetRegionEndpoint()
                ?? throw new ArgumentException(
                    "Region must be set. No region was supplied and none could be resolved from the environment " +
                    "(AWS_REGION, the shared config file, or EC2 instance metadata).", nameof(parameters));

            return new AWSSigV4Parameters
            {
                Credentials = parameters.Credentials,
                Region = region,
                Service = parameters.Service,
                SignPayload = parameters.SignPayload,
                SignedAt = parameters.SignedAt,
            };
        }

        // Return the credentials to sign with, falling back to the default credential resolution chain when the
        // caller left them null — matching how the service clients resolve missing credentials. Throws only
        // when no credentials can be determined at all.
        private static AWSCredentials ResolveCredentials(AWSSigV4Parameters parameters)
        {
            return parameters.Credentials
                ?? DefaultAWSCredentialsIdentityResolver.GetCredentials()
                ?? throw new ArgumentException(
                    "Credentials must be set. No credentials were supplied and none could be resolved from the " +
                    "environment (the default AWS credential resolution chain).", nameof(parameters));
        }

        private static void ValidateArguments(AWSSigningRequest request, AWSSigV4Parameters parameters, bool presign)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (parameters == null)
                throw new ArgumentNullException(nameof(parameters));
            if (request.HttpMethod == null)
                throw new ArgumentException("HttpMethod must be set.", nameof(request));
            if (request.RequestUri == null)
                throw new ArgumentException("RequestUri must be set.", nameof(request));
            if (!request.RequestUri.IsAbsoluteUri)
                throw new ArgumentException("RequestUri must be an absolute URI.", nameof(request));
            if (string.IsNullOrEmpty(parameters.Service))
                throw new ArgumentException("Service must be set.", nameof(parameters));
            // Region and Credentials are intentionally not validated here: when unset they are resolved from
            // the environment (FallbackRegionFactory / DefaultAWSCredentialsIdentityResolver), matching the
            // behavior of our other libraries. Resolution — and the error when it too comes up empty — happens
            // in ResolveRegion / the credential resolution path.

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

        // Some AWSCredentials implementations resolve to null rather than throwing — most notably
        // AnonymousAWSCredentials, whose GetCredentials() returns null. SigV4 requires a real access/secret
        // key, so guard here with a clear message instead of letting credentials.UseToken throw an opaque NRE.
        private static void EnsureCredentialsResolved(ImmutableCredentials credentials)
        {
            if (credentials == null)
                throw new ArgumentException(
                    "The supplied AWSCredentials resolved to null (e.g. AnonymousAWSCredentials). " +
                    "SigV4 signing requires credentials with an access key and secret key.", nameof(credentials));
        }

        private static void ValidateExpiry(TimeSpan expiry)
        {
            // X-Amz-Expires is expressed in whole seconds, so any value under one second would truncate to
            // "0" and produce an already-expired URL. Require at least one second (and at most 7 days).
            if (expiry < TimeSpan.FromSeconds(1) || expiry > MaxPresignExpiry)
                throw new ArgumentOutOfRangeException(nameof(expiry), "Expiry must be at least 1 second and at most 7 days.");
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
                    // A blank (empty or whitespace-only) value is treated as "not supplied", matching how
                    // BuildRequest routes the header to PrecomputedContentSha256 and how the downstream signer
                    // (its own IsNullOrEmpty check) ignores such a value. Without this, ValidateArguments would
                    // reject a blank header for presign and SignPayload = false even though it has no effect.
                    if (string.IsNullOrWhiteSpace(header.Value))
                        return false;

                    value = header.Value;
                    return true;
                }
            }

            return false;
        }

        #endregion
    }
}
