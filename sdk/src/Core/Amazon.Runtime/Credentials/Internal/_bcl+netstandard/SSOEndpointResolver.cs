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
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Resolves Identity Center instance ID and AWS region from customer-provided SSO endpoints.
    /// Supports AWS-owned portal URLs and vanity domains that redirect to AWS endpoints.
    ///
    /// This utility is intended to be called explicitly by tools (CLI, PowerShell, IDE plugins)
    /// before initiating the SSO login flow. SDKs MUST NOT call this automatically during
    /// credential resolution — they consume the resolved region from the cached token.
    /// </summary>
    public static class SSOEndpointResolver
    {
        // AWS-owned Identity Center domain suffixes for label-boundary matching.
        // Each entry is matched as a suffix on a DNS label boundary (preceded by '.' or equal to the full hostname).
        // Covers the aws, aws-cn, and aws-eusc partitions; GovCloud (aws-us-gov) reuses the commercial
        // ".awsapps.com" / ".portal.amazonaws.com" domains and is covered by the commercial entries.
        private static readonly string[] AwsDomainSuffixes =
        {
            ".app.aws", ".portal.amazonaws.com", ".awsapps.com", // Commercial (aws)
            ".portal.amazonaws.com.cn", ".app.amazonwebservices.com.cn", ".awsapps.cn",  // China (aws-cn)
            ".portal.amazonaws.eu", ".api.amazonwebservices.eu", // European Sovereign Cloud (aws-eusc)
        };

        private static readonly string[] IdentityCenterDomains =
        {
            "identitycenter.amazonaws.com",       // Commercial (aws) and GovCloud (aws-us-gov)
            "identitycenter.amazonaws.com.cn",    // China (aws-cn)
            "identitycenter.amazonaws.eu",        // European Sovereign Cloud (aws-eusc)
        };

        private static readonly Regex[] UrlPatterns =
        {
            // New portal, DualStack: https://{idcInstanceId}.portal.{region}.app.amazonwebservices.com.cn
            new Regex(@"^(https?://)?(?<id>[^.]+)\.portal\.(?<region>[^./]+)\.app\.amazonwebservices\.com\.cn", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // New portal, IPv4-only: https://{idcInstanceId}.{region}.portal.amazonaws.com.cn
            new Regex(@"^(https?://)?(?<id>[^.]+)\.(?<region>[^.]+)\.portal\.amazonaws\.com\.cn", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // Legacy portal: https://start.{region}.home.awsapps.cn/directory/{directoryId}
            new Regex(@"^(https?://)?start\.(?:[^./]+\.)?home\.awsapps\.cn/directory/(?<id>[^/?#]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // Issuer URL: https://identitycenter.amazonaws.com.cn/{idcInstanceId} (region-less)
            new Regex(@"^(https?://)?identitycenter\.amazonaws\.com\.cn/(?<id>[^/]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // New portal, DualStack: https://{idcInstanceId}.portal.{region}.api.amazonwebservices.eu
            new Regex(@"^(https?://)?(?<id>[^.]+)\.portal\.(?<region>[^./]+)\.api\.amazonwebservices\.eu", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // New portal, IPv4-only: https://{idcInstanceId}.{region}.portal.amazonaws.eu
            new Regex(@"^(https?://)?(?<id>[^.]+)\.(?<region>[^.]+)\.portal\.amazonaws\.eu", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // Issuer URL: https://identitycenter.amazonaws.eu/{idcInstanceId} (region-less)
            new Regex(@"^(https?://)?identitycenter\.amazonaws\.eu/(?<id>[^/]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),

            // New portal, DualStack: https://{idcInstanceId}.portal.{region}.app.aws
            new Regex(@"^(https?://)?(?<id>[^.]+)\.portal\.(?<region>[^./]+)\.app\.aws", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // New portal, IPv4-only: https://{idcInstanceId}.{region}.portal.amazonaws.com
            new Regex(@"^(https?://)?(?<id>[^.]+)\.(?<region>[^.]+)\.portal\.amazonaws\.com", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // GovCloud legacy portal: https://start.us-gov-home.awsapps.com/directory/{directoryId}
            new Regex(@"^(https?://)?start\.us-gov-home\.awsapps\.com/directory/(?<id>[^/?#]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // Legacy portal: https://{directoryId}.awsapps.com/start (also https://{alias}.awsapps.com/start)
            new Regex(@"^(https?://)?(?<id>[^.]+)\.awsapps\.com", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
            // Issuer URL: https://identitycenter.amazonaws.com/{idcInstanceId}
            new Regex(@"^(https?://)?identitycenter\.amazonaws\.com/(?<id>[^/]+)", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(1)),
        };

        private static readonly TimeSpan HttpTimeout = TimeSpan.FromSeconds(5);

        /// <summary>
        /// Resolves a customer-provided SSO endpoint into both the canonical issuer URL and region
        /// in a single resolution pass (one HTTP redirect at most).
        /// When the URL carries region information, the URL-derived region is used and regionOverride is ignored.
        /// regionOverride is only used as a fallback for region-less URL forms (awsapps.com, issuer URL).
        /// Throws ArgumentException if the URL cannot be resolved to an AWS-generated domain.
        /// </summary>
        /// <param name="startUrl">The customer-provided sso_start_url (may be vanity URL or AWS-owned).</param>
        /// <param name="regionOverride">Fallback region for URL forms that don't carry region (awsapps.com, issuer URL). May be null.</param>
        /// <returns>A resolved endpoint containing issuer URL, region, and vanity URL metadata.</returns>
        public static async Task<SSOResolvedEndpoint> ResolveAsync(string startUrl, string regionOverride)
        {
            // sso_start_url MUST use the https scheme; reject early before any domain checks.
            if (string.IsNullOrEmpty(startUrl) || !startUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    $"The sso_start_url must use HTTPS: {startUrl}");
            }

            // Determine if the original URL is a vanity domain (not AWS-owned) before resolution.
            var isVanityUrl = !IsAwsDomain(startUrl);

            var resolvedUrl = await ResolveToAwsGeneratedDomainAsync(startUrl).ConfigureAwait(false);
            if (resolvedUrl == null)
            {
                throw new ArgumentException(
                    $"Unable to resolve Identity Center instance from URL: {startUrl}. " +
                    "The URL must be an AWS-generated domain or a vanity domain that redirects to one.");
            }
            var parts = ParseUrl(resolvedUrl, startUrl);
            var issuerUrl = $"https://{GetIssuerHost(resolvedUrl)}/{parts.InstanceId}";

            // Region is NOT validated against a local list of known region codes.
            // Validating would block users authenticating against newly launched or unreleased
            // regions until they upgrade their tool. The redirect target is already verified to
            // be an AWS-owned domain, so a malformed region cannot direct traffic to a non-AWS
            // endpoint. If the region is invalid, the subsequent OIDC service call will fail.
            var region = !string.IsNullOrEmpty(parts.Region) ? parts.Region : regionOverride;

            return new SSOResolvedEndpoint(issuerUrl, region, isVanityUrl, startUrl, resolvedUrl);
        }

        /// <summary>
        /// Checks if the URL is an AWS-generated domain. If not, follows up to 1 redirect
        /// and checks again. Returns the AWS-generated URL if found, or null if the URL
        /// cannot be resolved to an AWS-generated domain.
        /// </summary>
        private static async Task<string> ResolveToAwsGeneratedDomainAsync(string url)
        {
            return await ResolveToAwsGeneratedDomainAsync(url, maxRedirects: 1).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks if the URL is an AWS-generated domain. If not, follows the redirect chain
        /// up to maxRedirects hops, then checks if the final location is an AWS-generated domain.
        /// Returns the AWS-generated URL if found, or null otherwise.
        /// Enforces HTTPS: both the initial URL and redirect targets must use HTTPS.
        /// </summary>
        private static async Task<string> ResolveToAwsGeneratedDomainAsync(string url, int maxRedirects)
        {
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }

            // Redundant with ResolveAsync's check, but kept as a defensive guard since
            // this method is private and could be called from new code paths in the future.
            if (!url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(
                    $"The sso_start_url must use HTTPS: {url}");
            }

            // Validate that the URL is a well-formed absolute URI before making any network requests
            if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                throw new ArgumentException(
                    $"The sso_start_url is not a valid URL: {url}");
            }

            if (IsAwsDomain(url))
            {
                return url;
            }

            try
            {
                var currentUrl = url;
                for (int i = 0; i < maxRedirects; i++)
                {
                    var redirectLocation = await FollowSingleRedirectAsync(currentUrl).ConfigureAwait(false);
                    if (redirectLocation == null)
                    {
                        break;
                    }

                    // Every redirect target MUST use https
                    if (!redirectLocation.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                    {
                        throw new ArgumentException(
                            $"Redirect target must use HTTPS. Got: {redirectLocation}");
                    }

                    currentUrl = redirectLocation;
                }

                if (IsAwsDomain(currentUrl))
                {
                    return currentUrl;
                }
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (HttpRequestException)
            {
                // Network errors are non-fatal
            }
            catch (TaskCanceledException)
            {
                // Timeout is non-fatal
            }

            return null;
        }

        /// <summary>
        /// Attempts to follow a single HTTP redirect from the given URL.
        /// Tries HEAD first since only the Location header is needed.
        /// Falls back to GET if the server rejects HEAD (e.g. 405 Method Not Allowed),
        /// since not all servers/load balancers support HEAD requests.
        /// Returns the redirect target URL, or null if no redirect occurred.
        /// </summary>
        private static async Task<string> FollowSingleRedirectAsync(string url)
        {
            var location = await TrySendRequestAsync(url, HttpMethod.Head).ConfigureAwait(false);
            if (location != null)
            {
                return location;
            }
            return await TrySendRequestAsync(url, HttpMethod.Get).ConfigureAwait(false);
        }

        /// <summary>
        /// Sends an HTTP request with auto-redirect disabled and returns the Location header
        /// value if the response is a redirect (301, 302, 303, 307, or 308).
        /// Returns null for non-redirect responses.
        /// Resolves relative Location URIs against the request URL.
        /// </summary>
        private static async Task<string> TrySendRequestAsync(string url, HttpMethod method)
        {
            using (var handler = new HttpClientHandler { AllowAutoRedirect = false })
            using (var client = new HttpClient(handler) { Timeout = HttpTimeout })
            using (var request = new HttpRequestMessage(method, url))
            using (var response = await client.SendAsync(request).ConfigureAwait(false))
            {
                var statusCode = (int)response.StatusCode;

                if ((statusCode == 301 || statusCode == 302 || statusCode == 303 ||
                     statusCode == 307 || statusCode == 308) && response.Headers.Location != null)
                {
                    var location = response.Headers.Location;
                    if (location.IsAbsoluteUri)
                    {
                        return location.AbsoluteUri;
                    }
                    // Resolve relative URI against the request URL
                    var baseUri = new Uri(url);
                    var resolved = new Uri(baseUri, location);
                    return resolved.AbsoluteUri;
                }

                return null;
            }
        }

        /// <summary>
        /// Checks if a URL belongs to a known AWS-generated Identity Center domain.
        /// Uses case-insensitive, label-boundary suffix matching per RFC 4343.
        /// A hostname matches if it ends with one of the AWS suffixes on a DNS label boundary
        /// (i.e., preceded by '.') or is exactly equal to the suffix without the leading dot.
        /// This prevents look-alike domains like "awsapps.com.evil.net" from matching.
        /// </summary>
        private static bool IsAwsDomain(string url)
        {
            try
            {
#pragma warning disable CA1308 // Hostnames are ASCII; lowercase is safe and natural for DNS comparison per RFC 4343
                var hostname = new Uri(url).Host.ToLowerInvariant();
#pragma warning restore CA1308

                // Check exact match for identity center issuer hostnames (all partitions)
                foreach (var issuerDomain in IdentityCenterDomains)
                {
                    if (hostname.Equals(issuerDomain, StringComparison.Ordinal))
                    {
                        return true;
                    }
                }

                // Check label-boundary suffix match for other domains
                foreach (var suffix in AwsDomainSuffixes)
                {
                    if (hostname.EndsWith(suffix, StringComparison.Ordinal))
                    {
                        return true;
                    }
                    // Also match if hostname equals the suffix without leading dot (e.g., "awsapps.com")
                    var bareHostname = suffix.TrimStart('.');
                    if (hostname.Equals(bareHostname, StringComparison.Ordinal))
                    {
                        return true;
                    }
                }
            }
            catch (UriFormatException)
            {
            }
            return false;
        }

        /// <summary>
        /// Returns the partition-appropriate Identity Center issuer hostname for a resolved AWS-owned URL.
        /// </summary>
        private static string GetIssuerHost(string resolvedUrl)
        {
            try
            {
#pragma warning disable CA1308 // Hostnames are ASCII; lowercase is the canonical form for DNS comparison
                var hostname = new Uri(resolvedUrl).Host.ToLowerInvariant();
#pragma warning restore CA1308

                // China partition (aws-cn) hosts end in ".cn".
                if (hostname.EndsWith(".cn", StringComparison.Ordinal))
                {
                    return "identitycenter.amazonaws.com.cn";
                }
                // European Sovereign Cloud (aws-eusc) hosts end in ".eu".
                if (hostname.EndsWith(".eu", StringComparison.Ordinal))
                {
                    return "identitycenter.amazonaws.eu";
                }
            }
            catch (UriFormatException)
            {
            }

            // Commercial (aws) and GovCloud (aws-us-gov).
            return "identitycenter.amazonaws.com";
        }

        /// <summary>
        /// Parses an AWS-generated URL to extract the Identity Center instance ID and optionally the region.
        /// Throws ArgumentException if the URL does not match any known pattern.
        /// </summary>
        private static SSOEndpointParts ParseUrl(string resolvedUrl, string originalUrl)
        {
            foreach (var pattern in UrlPatterns)
            {
                var match = pattern.Match(resolvedUrl);
                if (match.Success)
                {
                    var id = match.Groups["id"].Value;
#pragma warning disable CA1308 // Region codes are ASCII; lowercase is the canonical form used by RegionEndpoint
                    var region = match.Groups["region"].Success ? match.Groups["region"].Value.ToLowerInvariant() : null;
#pragma warning restore CA1308
                    return new SSOEndpointParts(id, region);
                }
            }

            throw new ArgumentException(
                $"Unable to resolve Identity Center instance from URL: {originalUrl}. " +
                "Supported formats: https://{{id}}.portal.{{region}}.app.aws, " +
                "https://{{id}}.{{region}}.portal.amazonaws.com, " +
                "https://{{id}}.awsapps.com, " +
                "https://identitycenter.amazonaws.com/{{id}}, " +
                "the equivalent China (amazonaws.com.cn, amazonwebservices.com.cn, awsapps.cn) " +
                "and European Sovereign Cloud (amazonaws.eu, amazonwebservices.eu) formats, " +
                "or a vanity domain that redirects to one of these.");
        }

        private readonly struct SSOEndpointParts
        {
            internal string InstanceId { get; }
            internal string Region { get; }

            internal SSOEndpointParts(string instanceId, string region)
            {
                InstanceId = instanceId;
                Region = region;
            }
        }
    }

    /// <summary>
    /// Contains the resolved issuer URL and region from an SSO endpoint resolution.
    /// </summary>
    public readonly struct SSOResolvedEndpoint
    {
        /// <summary>
        /// The canonical Identity Center issuer URL (https://identitycenter.amazonaws.com/{idcInstanceId}).
        /// </summary>
        public string IssuerUrl { get; }

        /// <summary>
        /// The AWS region, or null if not determinable from the URL (legacy/issuer formats without override).
        /// </summary>
        public string Region { get; }

        /// <summary>
        /// True if the original sso_start_url was a customer vanity URL (not an AWS-owned domain)
        /// that was resolved to an AWS endpoint. Can be used to set SSO_LOGIN_VANITY_URL feature ID
        /// on SSO-OIDC requests.
        /// </summary>
        public bool IsVanityUrl { get; }

        /// <summary>
        /// The original start URL provided by the user (before resolution).
        /// </summary>
        public string StartUrl { get; }

        /// <summary>
        /// The AWS-owned URL that the start URL resolved to (after following redirects if needed).
        /// </summary>
        public string ResolvedUrl { get; }

        /// <summary>
        /// Creates a new SSOResolvedEndpoint.
        /// </summary>
        public SSOResolvedEndpoint(string issuerUrl, string region, bool isVanityUrl, string startUrl, string resolvedUrl)
        {
            IssuerUrl = issuerUrl;
            Region = region;
            IsVanityUrl = isVanityUrl;
            StartUrl = startUrl;
            ResolvedUrl = resolvedUrl;
        }
    }
}
