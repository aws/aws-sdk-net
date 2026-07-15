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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Signing
{
    /// <summary>
    /// Convenience extensions for signing a <see cref="HttpRequestMessage"/> with SigV4. Kept separate
    /// from <see cref="AWSSigV4Signer"/> so the core signing API carries no <c>System.Net.Http</c> coupling.
    /// </summary>
    public static class HttpRequestMessageSigningExtensions
    {
        /// <summary>
        /// Signs the message in place: reads its method, URI, headers, and content, computes the SigV4
        /// signature, and applies the resulting signing headers back onto the same message. The content
        /// (if any) is buffered into memory so its hash can be computed.
        /// </summary>
        /// <param name="message">The request message to sign.</param>
        /// <param name="parameters">The signing configuration (credentials, region, service).</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public static async Task SignWithSigV4Async(this HttpRequestMessage message,
                                                    AWSSigningParameters parameters,
                                                    CancellationToken cancellationToken = default)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));
            if (message.RequestUri == null)
                throw new ArgumentException("The message must have a RequestUri.", nameof(message));

            var headers = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var header in message.Headers)
            {
                // Skip signing artifacts from any prior signing pass. The signer strips a stale Authorization
                // and overwrites x-amz-date, but it does not strip x-amz-security-token — so a leftover token
                // (e.g. from an earlier pass with different credentials) would otherwise be signed and sent.
                if (IsSigningHeader(header.Key))
                    continue;
                headers[header.Key] = string.Join(", ", header.Value);
            }

            byte[] content = null;
            if (message.Content != null)
            {
                foreach (var header in message.Content.Headers)
                    headers[header.Key] = string.Join(", ", header.Value);

                // Buffer the body so the payload hash can be computed from bytes.
                content = await message.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            }

            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = message.Method.Method,
                RequestUri = message.RequestUri,
                Headers = headers,
                Content = content,
            };

            var result = await AWSSigV4Signer.SignAsync(signingRequest, parameters, cancellationToken).ConfigureAwait(false);

            // Clear any signing headers from a prior pass before applying the new ones. This is necessary
            // because (a) HttpRequestHeaders.TryAddWithoutValidation appends rather than replaces, so re-adding
            // would duplicate; and (b) a header that the new pass does NOT set (e.g. X-Amz-Security-Token when
            // re-signing with non-session credentials after a session-credential pass) must still be removed,
            // or a stale value would be left on the message.
            foreach (var name in SigningHeaderNames)
                message.Headers.Remove(name);

            foreach (var header in result.Headers)
                message.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        private static readonly string[] SigningHeaderNames =
        {
            "Authorization",
            "X-Amz-Date",
            "X-Amz-Content-SHA256",
            "X-Amz-Security-Token",
        };

        private static bool IsSigningHeader(string name)
        {
            foreach (var signingHeader in SigningHeaderNames)
            {
                if (string.Equals(name, signingHeader, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
