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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Util;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// A <see cref="DelegatingHandler"/> that signs each outbound request with AWS Signature Version 4
    /// before it is sent. Install it on an <see cref="HttpClient"/> — directly or via
    /// <c>IHttpClientFactory</c> — to sign transparently, so callers write ordinary <see cref="HttpClient"/>
    /// code and every request is signed. It is a thin front door over <see cref="AWSSigV4Signer"/> and
    /// performs no signing computation of its own.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The signing region, service, and payload-signing mode are handler-level defaults for the common
    /// one-service-per-client case. A single client that must sign for more than one service or region,
    /// or vary payload signing per request, can override any of them on an individual message through
    /// <c>HttpRequestMessage.Options</c> (net5.0+) or <c>HttpRequestMessage.Properties</c> (earlier
    /// targets), using <see cref="ServiceOptionKey"/>, <see cref="RegionOptionKey"/>, and
    /// <see cref="SignPayloadOptionKey"/>.
    /// </para>
    /// <para>
    /// Credentials are resolved on every send (not captured at construction), so a rotating credential
    /// source such as SSO, assume-role, or IMDS always signs with current credentials.
    /// </para>
    /// <para>
    /// <b>Important — disable automatic redirects.</b> The primary/inner handler must set
    /// <c>AllowAutoRedirect = false</c>. An auto-followed redirect is replayed below this handler, so it is
    /// not re-signed; because it often targets a different host it would carry a signature computed for the
    /// original host and be rejected. Handle redirects above this handler so each hop is re-signed.
    /// </para>
    /// <para>
    /// <b>Important — retry ordering.</b> Any retry handler must sit <i>outside</i> (before) this handler in
    /// the chain so each attempt re-enters signing and is signed with a fresh timestamp. A retry handler
    /// placed closer to the transport would replay one frozen signature and a delayed retry could fall
    /// outside the allowed clock-skew window.
    /// </para>
    /// <para>
    /// To hash the body the handler buffers request content into memory (and rebuffers it as re-readable
    /// content so it survives a resend on retry). For a large or streaming upload where this is undesirable,
    /// set <see cref="AWSSigningParameters.SignPayload"/> to <c>false</c> (the body is signed as
    /// UNSIGNED-PAYLOAD and never read; requires HTTPS) or supply a precomputed
    /// <c>x-amz-content-sha256</c> header (the body is not read).
    /// </para>
    /// </remarks>
    public class SigV4SigningHandler : DelegatingHandler
    {
        /// <summary>
        /// The <c>HttpRequestMessage.Options</c> / <c>Properties</c> key (a <see cref="string"/>) that
        /// overrides the signing service for a single request.
        /// </summary>
        public const string ServiceOptionKey = "Amazon.Runtime.Signing.Service";

        /// <summary>
        /// The <c>HttpRequestMessage.Options</c> / <c>Properties</c> key (a <see cref="string"/>) that
        /// overrides the signing region for a single request.
        /// </summary>
        public const string RegionOptionKey = "Amazon.Runtime.Signing.Region";

        /// <summary>
        /// The <c>HttpRequestMessage.Options</c> / <c>Properties</c> key (a <see cref="bool"/>) that
        /// overrides payload signing for a single request.
        /// </summary>
        public const string SignPayloadOptionKey = "Amazon.Runtime.Signing.SignPayload";

        private readonly AWSSigningParameters _parameters;

        /// <summary>
        /// Creates a handler that signs each request for the given credentials, region, and service.
        /// </summary>
        /// <param name="credentials">The credentials to sign with; resolved on every send.</param>
        /// <param name="region">The default signing region.</param>
        /// <param name="service">The default signing service name, e.g. "execute-api".</param>
        public SigV4SigningHandler(AWSCredentials credentials, RegionEndpoint region, string service)
            : this(BuildParameters(credentials, region, service))
        {
        }

        /// <summary>
        /// Creates a handler from a set of default signing parameters. <see cref="AWSSigningParameters.Credentials"/>
        /// is resolved on every send. Leave <see cref="AWSSigningParameters.SignedAt"/> unset so each request is
        /// signed with a current timestamp.
        /// </summary>
        /// <param name="parameters">The default signing parameters.</param>
        public SigV4SigningHandler(AWSSigningParameters parameters)
        {
            _parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
            if (_parameters.Credentials == null)
                throw new ArgumentException("Credentials must be set.", nameof(parameters));
            if (string.IsNullOrEmpty(_parameters.Region))
                throw new ArgumentException("Region must be set.", nameof(parameters));
            if (string.IsNullOrEmpty(_parameters.Service))
                throw new ArgumentException("Service must be set.", nameof(parameters));
        }

        /// <summary>
        /// Signs <paramref name="request"/> with SigV4 and forwards it to the inner handler.
        /// </summary>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            if (request.RequestUri == null || !request.RequestUri.IsAbsoluteUri)
                throw new InvalidOperationException(
                    "The request URI must be an absolute URI. Set HttpClient.BaseAddress or use an absolute request URI.");

            var parameters = ResolveParameters(request);
            var signingRequest = await BuildSigningRequestAsync(request, parameters, cancellationToken).ConfigureAwait(false);

            var result = await AWSSigV4Signer.SignAsync(signingRequest, parameters, cancellationToken).ConfigureAwait(false);

            ApplySigningHeaders(request, result);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }

        private static AWSSigningParameters BuildParameters(AWSCredentials credentials, RegionEndpoint region, string service)
        {
            if (region == null)
                throw new ArgumentNullException(nameof(region));

            return new AWSSigningParameters
            {
                Credentials = credentials,
                Region = region.SystemName,
                Service = service,
            };
        }

        // Produce a per-request copy of the defaults, applying any per-message overrides. A copy is required
        // because the same handler instance signs concurrent requests that may carry different overrides.
        private AWSSigningParameters ResolveParameters(HttpRequestMessage request)
        {
            var parameters = new AWSSigningParameters
            {
                Credentials = _parameters.Credentials,
                Region = _parameters.Region,
                Service = _parameters.Service,
                SignPayload = _parameters.SignPayload,
                SignedAt = _parameters.SignedAt,
            };

            if (TryGetOption(request, ServiceOptionKey, out string service) && !string.IsNullOrEmpty(service))
                parameters.Service = service;
            if (TryGetOption(request, RegionOptionKey, out string region) && !string.IsNullOrEmpty(region))
                parameters.Region = region;
            if (TryGetOption(request, SignPayloadOptionKey, out bool signPayload))
                parameters.SignPayload = signPayload;

            return parameters;
        }

        private static async Task<AWSSigningRequest> BuildSigningRequestAsync(HttpRequestMessage request, AWSSigningParameters parameters, CancellationToken cancellationToken)
        {
            // The body is only needed when the signer will hash it: payload signing is on and the caller
            // hasn't already supplied a hash. Otherwise (UNSIGNED-PAYLOAD, or a precomputed hash) the body is
            // never read, which is what keeps a large or streaming upload from being buffered.
            var hasPrecomputedHash = HasContentSha256Header(request);
            var mustHashBody = parameters.SignPayload && !hasPrecomputedHash && request.Content != null;

            byte[] body = null;
            if (mustHashBody)
            {
                cancellationToken.ThrowIfCancellationRequested();
#if NET5_0_OR_GREATER
                body = await request.Content.ReadAsByteArrayAsync(cancellationToken).ConfigureAwait(false);
#else
                body = await request.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
#endif

                // Replace the (possibly one-shot) content with a re-readable buffer so the body survives a
                // resend on retry, preserving the original content headers.
                var buffered = new ByteArrayContent(body);
                foreach (var header in request.Content.Headers)
                    buffered.Headers.TryAddWithoutValidation(header.Key, header.Value);
                request.Content = buffered;
            }

            return new AWSSigningRequest
            {
                HttpMethod = request.Method.Method,
                RequestUri = request.RequestUri,
                Headers = CollectHeaders(request),
                Content = body,
            };
        }

        // Flatten the request and content headers into the single-value-per-name shape AWSSigningRequest
        // expects. A multi-valued header is joined with commas, each value trimmed, per the SigV4 canonical
        // form documented on AWSSigningRequest.Headers.
        private static IDictionary<string, string> CollectHeaders(HttpRequestMessage request)
        {
            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (var header in request.Headers)
                headers[header.Key] = JoinValues(header.Value);

            if (request.Content != null)
            {
                foreach (var header in request.Content.Headers)
                    headers[header.Key] = JoinValues(header.Value);
            }

            return headers;
        }

        private static string JoinValues(IEnumerable<string> values)
        {
            return string.Join(",", values.Select(v => v == null ? string.Empty : v.Trim()));
        }

        private static bool HasContentSha256Header(HttpRequestMessage request)
        {
            if (request.Headers.TryGetValues(HeaderKeys.XAmzContentSha256Header, out var values) &&
                values.Any(v => !string.IsNullOrWhiteSpace(v)))
                return true;

            if (request.Content != null &&
                request.Content.Headers.TryGetValues(HeaderKeys.XAmzContentSha256Header, out var contentValues) &&
                contentValues.Any(v => !string.IsNullOrWhiteSpace(v)))
                return true;

            return false;
        }

        // Apply the computed signing headers, replacing any left over from a previous signing pass so a
        // re-signed retry does not accumulate duplicate header lines. A signing header may also have been set
        // by the caller on the content headers (e.g. a precomputed X-Amz-Content-SHA256), so clear it from
        // there too — otherwise the outgoing request carries the header twice (once on the request, once on
        // the content), which SigV4 validation can reject.
        private static void ApplySigningHeaders(HttpRequestMessage request, AWSSigningResult result)
        {
            foreach (var header in result.Headers)
            {
                RemoveFromContentHeaders(request.Content, header.Key);
                request.Headers.Remove(header.Key);
                request.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }
        }

        // Remove a signing header from the content headers if present. HttpContentHeaders validates the name
        // and throws for a request-only header (e.g. Authorization), so guard the call: request-only headers
        // can never be on the content headers anyway, and a custom header such as x-amz-content-sha256 (which
        // a caller may have set there) is removed cleanly.
        private static void RemoveFromContentHeaders(HttpContent content, string name)
        {
            if (content == null)
                return;

            try
            {
                content.Headers.Remove(name);
            }
            catch (InvalidOperationException)
            {
                // Not a valid content header name, so it cannot have been set on the content headers.
            }
        }

#if NET5_0_OR_GREATER
        private static bool TryGetOption<T>(HttpRequestMessage request, string key, out T value)
        {
            return request.Options.TryGetValue(new HttpRequestOptionsKey<T>(key), out value);
        }
#else
        private static bool TryGetOption<T>(HttpRequestMessage request, string key, out T value)
        {
            if (request.Properties.TryGetValue(key, out var raw) && raw is T typed)
            {
                value = typed;
                return true;
            }

            value = default;
            return false;
        }
#endif
    }
}
