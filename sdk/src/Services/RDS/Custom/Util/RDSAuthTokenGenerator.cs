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
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Signing;
using System;
using System.Globalization;
using System.Net.Http;

namespace Amazon.RDS.Util
{
    /// <summary>
    /// Provides authorization tokens for IAM authentication to an RDS database.
    /// </summary>
    public static class RDSAuthTokenGenerator
    {
        private const string RDSServiceName = "rds-db";
        private const string HTTPS = "https";
        private const string URISchemeDelimiter = "://";
        private const string ActionKey = "Action";
        private const string ActionValue = "connect";
        private const string DBUserKey = "DBUser";
        private static readonly TimeSpan FifteenMinutes = TimeSpan.FromMinutes(15);

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static string GenerateAuthToken(string hostname, int port, string dbUser)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateAuthToken(region, hostname, port, dbUser);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the RDS database.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static string GenerateAuthToken(RegionEndpoint region, string hostname, int port, string dbUser)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return GenerateAuthToken(credentials, region, hostname, port, dbUser);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static string GenerateAuthToken(AWSCredentials credentials, string hostname, int port, string dbUser)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateAuthToken(credentials, region, hostname, port, dbUser);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the RDS database.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static string GenerateAuthToken(AWSCredentials credentials, RegionEndpoint region, string hostname, int port, string dbUser)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Force a refresh if the credentials would expire before the token does, so the token stays valid for its full lifetime.
            var immutableCredentials = credentials is RefreshingAWSCredentials refreshing
                ? refreshing.GetCredentials(FifteenMinutes)
                : credentials.GetCredentials();
            return GenerateAuthToken(immutableCredentials, region, hostname, port, dbUser);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateAuthTokenAsync(string hostname, int port, string dbUser)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateAuthTokenAsync(region, hostname, port, dbUser).ConfigureAwait(false);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the RDS database.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateAuthTokenAsync(RegionEndpoint region, string hostname, int port, string dbUser)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return await GenerateAuthTokenAsync(credentials, region, hostname, port, dbUser).ConfigureAwait(false);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateAuthTokenAsync(AWSCredentials credentials, string hostname, int port, string dbUser)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateAuthTokenAsync(credentials, region, hostname, port, dbUser).ConfigureAwait(false);
        }

        /// <summary>
        /// Generate a token for IAM authentication to an RDS database.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the RDS database.</param>
        /// <param name="hostname">Hostname of the RDS database.</param>
        /// <param name="port">Port of the RDS database.</param>
        /// <param name="dbUser">Database user for the token.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateAuthTokenAsync(AWSCredentials credentials, RegionEndpoint region, string hostname, int port, string dbUser)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Force a refresh if the credentials would expire before the token does, so the token stays valid for its full lifetime.
            var immutableCredentials = credentials is RefreshingAWSCredentials refreshing
                ? await refreshing.GetCredentialsAsync(FifteenMinutes).ConfigureAwait(false)
                : await credentials.GetCredentialsAsync().ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, port, dbUser);
        }

        private static string GenerateAuthToken(ImmutableCredentials immutableCredentials, RegionEndpoint region, string hostname, int port, string dbUser)
        {
            if (immutableCredentials == null)
                throw new ArgumentNullException("immutableCredentials");

            if (region == null)
                throw new ArgumentNullException("region");

            if (port < 0 || port > 65535)
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "{0} is an invalid port. Port must be 0 to 65535.", port));

            hostname = hostname?.Trim();
            if (string.IsNullOrEmpty(hostname))
                throw new ArgumentException("Hostname must not be null or empty.");

            dbUser = dbUser?.Trim();
            if (string.IsNullOrEmpty(dbUser))
                throw new ArgumentException("DBUser must not be null or empty.");

            // Build a neutral signing request against the public facade. Credentials have already been
            // resolved (with the refresh above), so wrap them in a non-refreshing AWSCredentials so the
            // facade's own presign-window refresh is a no-op and doesn't re-resolve them.
            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = HttpMethod.Get,
                RequestUri = new Uri(string.Format(CultureInfo.InvariantCulture,
                    "{0}://{1}:{2}/?{3}={4}&{5}={6}",
                    HTTPS, hostname, port, ActionKey, ActionValue, DBUserKey, Uri.EscapeDataString(dbUser))),
            };

            var parameters = new AWSSigV4Parameters
            {
                Credentials = WrapResolved(immutableCredentials),
                Region = region,
                Service = RDSServiceName,
            };

            var presign = AWSSigV4Signer.Presign(signingRequest, parameters, FifteenMinutes);

            // The token is the presigned URL with the scheme stripped: "hostname:port/?..."
            return presign.Uri.AbsoluteUri.Substring(HTTPS.Length + URISchemeDelimiter.Length);
        }

        // Wraps already-resolved credentials as a non-refreshing AWSCredentials for the facade. Since neither
        // BasicAWSCredentials nor SessionAWSCredentials is a RefreshingAWSCredentials, the facade's presign-window
        // refresh degrades to a plain GetCredentials() and returns these same values back.
        private static AWSCredentials WrapResolved(ImmutableCredentials creds)
        {
            return creds.UseToken
                ? (AWSCredentials)new SessionAWSCredentials(creds.AccessKey, creds.SecretKey, creds.Token)
                : new BasicAWSCredentials(creds.AccessKey, creds.SecretKey);
        }
    }
}
