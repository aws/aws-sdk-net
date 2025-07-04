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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Credentials.Internal;
using System;
using System.Globalization;

namespace Amazon.RDS.Util
{
    /// <summary>
    /// Provides authorization tokens for IAM authentication to an RDS database.
    /// </summary>
    public static class RDSAuthTokenGenerator
    {
        private const string RDSServiceName = "rds-db";
        private const string HTTPGet = "GET";
        private const string HTTPS = "https";
        private const string URISchemeDelimiter = "://";
        private const string ActionKey = "Action";
        private const string ActionValue = "connect";
        private const string DBUserKey = "DBUser";
        private const string XAmzExpires = "X-Amz-Expires";
        private const string XAmzSecurityToken = "X-Amz-Security-Token";
        private static readonly TimeSpan FifteenMinutes = TimeSpan.FromMinutes(15);

        /// <summary>
        /// AWS4PreSignedUrlSigner is built around operation request objects.
        /// This request type will only be used to generate the signed token.
        /// It will never be used to make an actual request to RDS.
        /// </summary>
        private class GenerateRDSAuthTokenRequest : AmazonWebServiceRequest
        {
            public GenerateRDSAuthTokenRequest()
            {
                ((IAmazonWebServiceRequest)this).SignatureVersion = SignatureVersion.SigV4;
            }
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

            var immutableCredentials = credentials.GetCredentials();
            return GenerateAuthToken(immutableCredentials, region, hostname, port, dbUser);
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

            var immutableCredentials = await credentials.GetCredentialsAsync().ConfigureAwait(false);
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

            GenerateRDSAuthTokenRequest authTokenRequest = new GenerateRDSAuthTokenRequest();
            IRequest request = new DefaultRequest(authTokenRequest, RDSServiceName);

            request.UseQueryString = true;
            request.HttpMethod = HTTPGet;
            request.Parameters.Add(XAmzExpires, FifteenMinutes.TotalSeconds.ToString(CultureInfo.InvariantCulture));
            request.Parameters.Add(DBUserKey, dbUser);
            request.Parameters.Add(ActionKey, ActionValue);
            request.Endpoint = new UriBuilder(HTTPS, hostname, port).Uri;

            if (immutableCredentials.UseToken)
            {
                request.Parameters[XAmzSecurityToken] = immutableCredentials.Token;
            }

            var signingResult = AWS4PreSignedUrlSigner.SignRequest(request, null, new RequestMetrics(), immutableCredentials.AccessKey,
                immutableCredentials.SecretKey, RDSServiceName, region.SystemName);

            var authorization = "&" + signingResult.ForQueryParameters;
            var url = AmazonServiceClient.ComposeUrl(request);

            // remove the https:// and append the authorization
            return url.AbsoluteUri.Substring(HTTPS.Length + URISchemeDelimiter.Length) + authorization;
        }
    }
}
