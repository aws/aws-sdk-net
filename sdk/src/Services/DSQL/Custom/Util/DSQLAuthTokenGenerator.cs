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
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System;
using System.Globalization;

namespace Amazon.DSQL.Util
{
    /// <summary>
    /// Provides authorization tokens for IAM authentication to an DSQL database.
    /// </summary>
    public static class DSQLAuthTokenGenerator
    {
        private const string DSQLServiceName = "dsql";
        private const string HTTPGet = "GET";
        private const string HTTPS = "https";
        private const string URISchemeDelimiter = "://";
        private const string ActionKey = "Action";
        private const string DBConnectActionValue = "DbConnect";
        private const string DBConnectAdminActionValue = "DbConnectAdmin";
        private const string XAmzExpires = "X-Amz-Expires";
        private const string XAmzSecurityToken = "X-Amz-Security-Token";
        private static readonly TimeSpan FifteenMinutes = TimeSpan.FromMinutes(15);

        /// <summary>
        /// AWS4PreSignedUrlSigner is built around operation request objects.
        /// This request type will only be used to generate the signed token.
        /// It will never be used to make an actual request to DSQL.
        /// </summary>
        private class GenerateDSQLAuthTokenRequest : AmazonWebServiceRequest
        {
            public GenerateDSQLAuthTokenRequest()
            {
                ((IAmazonWebServiceRequest)this).SignatureVersion = SignatureVersion.SigV4;
            }
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// <remarks>
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAuthToken(region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// <remarks>
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(RegionEndpoint region, string hostname)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return GenerateDbConnectAuthToken(credentials, region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(AWSCredentials credentials, string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAuthToken(credentials, region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(AWSCredentials credentials, RegionEndpoint region, string hostname)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            var immutableCredentials = credentials.GetCredentials();
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(AWSCredentials credentials, RegionEndpoint region, string hostname)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            var immutableCredentials = await credentials.GetCredentialsAsync().ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// <remarks>
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAdminAuthToken(region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// <remarks>
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(RegionEndpoint region, string hostname)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return GenerateDbConnectAdminAuthToken(credentials, region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(AWSCredentials credentials, string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAdminAuthToken(credentials, region, hostname);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(AWSCredentials credentials, RegionEndpoint region, string hostname)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            var immutableCredentials = credentials.GetCredentials();
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(AWSCredentials credentials, RegionEndpoint region, string hostname)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            var immutableCredentials = await credentials.GetCredentialsAsync().ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue);
        }

        private static string GenerateAuthToken(ImmutableCredentials immutableCredentials, RegionEndpoint region, string hostname, string actionValue)
        {
            if (immutableCredentials == null)
                throw new ArgumentNullException("immutableCredentials");

            if (region == null)
                throw new ArgumentNullException("region");

            hostname = hostname?.Trim();
            if (string.IsNullOrEmpty(hostname))
                throw new ArgumentException("Hostname must not be null or empty.");

            GenerateDSQLAuthTokenRequest authTokenRequest = new GenerateDSQLAuthTokenRequest();
            IRequest request = new DefaultRequest(authTokenRequest, DSQLServiceName);

            request.UseQueryString = true;
            request.HttpMethod = HTTPGet;
            request.Parameters.Add(XAmzExpires, FifteenMinutes.TotalSeconds.ToString(CultureInfo.InvariantCulture));
            request.Parameters.Add(ActionKey, actionValue);
            request.Endpoint = new UriBuilder(HTTPS, hostname).Uri;

            if (immutableCredentials.UseToken)
            {
                request.Parameters[XAmzSecurityToken] = immutableCredentials.Token;
            }

            var signingResult = AWS4PreSignedUrlSigner.SignRequest(request, null, new RequestMetrics(), immutableCredentials.AccessKey,
                immutableCredentials.SecretKey, DSQLServiceName, region.SystemName);

            var authorization = "&" + signingResult.ForQueryParameters;
            var url = AmazonServiceClient.ComposeUrl(request);

            // remove the https:// and append the authorization
            return url.AbsoluteUri.Substring(HTTPS.Length + URISchemeDelimiter.Length) + authorization;
        }
    }
}
