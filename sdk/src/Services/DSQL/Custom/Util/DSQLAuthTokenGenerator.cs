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

namespace Amazon.DSQL.Util
{
    /// <summary>
    /// Provides authorization tokens for IAM authentication to an DSQL database.
    /// </summary>
    public static class DSQLAuthTokenGenerator
    {
        private const string DSQLServiceName = "dsql";
        private const string HTTPS = "https";
        private const string URISchemeDelimiter = "://";
        private const string ActionKey = "Action";
        private const string DBConnectActionValue = "DbConnect";
        private const string DBConnectAdminActionValue = "DbConnectAdmin";
        private static readonly TimeSpan FifteenMinutes = TimeSpan.FromMinutes(15);
        private static readonly TimeSpan MaxExpiresIn = TimeSpan.FromDays(7);

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
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAuthToken(region, hostname, expiresIn);
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
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return GenerateDbConnectAuthToken(credentials, region, hostname, expiresIn);
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
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(AWSCredentials credentials, string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAuthToken(credentials, region, hostname, expiresIn);
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

            var immutableCredentials = ResolveCredentials(credentials, FifteenMinutes);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue, FifteenMinutes);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. If not specified on other overloads, defaults to 15 minutes.
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAuthToken(AWSCredentials credentials, RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Validate before the refresh below so an out-of-range expiration cannot trigger a credentials fetch.
            ValidateExpiresIn(expiresIn);

            var immutableCredentials = ResolveCredentials(credentials, expiresIn);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue, expiresIn);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAuthTokenAsync(region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAuthTokenAsync(region, hostname, expiresIn).ConfigureAwait(false);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(RegionEndpoint region, string hostname)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return await GenerateDbConnectAuthTokenAsync(credentials, region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return await GenerateDbConnectAuthTokenAsync(credentials, region, hostname, expiresIn).ConfigureAwait(false);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(AWSCredentials credentials, string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAuthTokenAsync(credentials, region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(AWSCredentials credentials, string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAuthTokenAsync(credentials, region, hostname, expiresIn).ConfigureAwait(false);
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

            var immutableCredentials = await ResolveCredentialsAsync(credentials, FifteenMinutes).ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue, FifteenMinutes);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnect action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. If not specified on other overloads, defaults to 15 minutes.
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAuthTokenAsync(AWSCredentials credentials, RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Validate before the refresh below so an out-of-range expiration cannot trigger a credentials fetch.
            ValidateExpiresIn(expiresIn);

            var immutableCredentials = await ResolveCredentialsAsync(credentials, expiresIn).ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectActionValue, expiresIn);
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
        /// The AWS region and credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAdminAuthToken(region, hostname, expiresIn);
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
        /// The AWS credentials for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return GenerateDbConnectAdminAuthToken(credentials, region, hostname, expiresIn);
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
        /// <remarks>
        /// The AWS region for creating the auth token will be searched for
        /// using the SDK's standard environment search pattern. This includes using
        /// default profile configuration and AWS Compute environment settings.
        /// </remarks>
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(AWSCredentials credentials, string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return GenerateDbConnectAdminAuthToken(credentials, region, hostname, expiresIn);
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

            var immutableCredentials = ResolveCredentials(credentials, FifteenMinutes);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue, FifteenMinutes);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. If not specified on other overloads, defaults to 15 minutes.
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static string GenerateDbConnectAdminAuthToken(AWSCredentials credentials, RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Validate before the refresh below so an out-of-range expiration cannot trigger a credentials fetch.
            ValidateExpiresIn(expiresIn);

            var immutableCredentials = ResolveCredentials(credentials, expiresIn);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue, expiresIn);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAdminAuthTokenAsync(region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAdminAuthTokenAsync(region, hostname, expiresIn).ConfigureAwait(false);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(RegionEndpoint region, string hostname)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return await GenerateDbConnectAdminAuthTokenAsync(credentials, region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            AWSCredentials credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            return await GenerateDbConnectAdminAuthTokenAsync(credentials, region, hostname, expiresIn).ConfigureAwait(false);
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
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(AWSCredentials credentials, string hostname)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAdminAuthTokenAsync(credentials, region, hostname).ConfigureAwait(false);
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
        /// <param name="expiresIn">The token expiry duration. Must be between 0 (exclusive) and 7 days (inclusive).
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(AWSCredentials credentials, string hostname, TimeSpan expiresIn)
        {
            RegionEndpoint region = FallbackRegionFactory.GetRegionEndpoint();
            return await GenerateDbConnectAdminAuthTokenAsync(credentials, region, hostname, expiresIn).ConfigureAwait(false);
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

            var immutableCredentials = await ResolveCredentialsAsync(credentials, FifteenMinutes).ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue, FifteenMinutes);
        }

        /// <summary>
        /// Generate a token for IAM authentication to a DSQL database cluster for the DbConnectAdmin action.
        /// </summary>
        /// <param name="credentials">The credentials for the token.</param>
        /// <param name="region">The region of the DSQL database.</param>
        /// <param name="hostname">Hostname of the DSQL database.</param>
        /// <param name="expiresIn">The token expiry duration. If not specified on other overloads, defaults to 15 minutes.
        /// A token signed with temporary credentials becomes invalid when the credentials session expires, even if this duration is longer;
        /// durations beyond the credentials session lifetime require long-term credentials.</param>
        /// <returns></returns>
        public static async System.Threading.Tasks.Task<string> GenerateDbConnectAdminAuthTokenAsync(AWSCredentials credentials, RegionEndpoint region, string hostname, TimeSpan expiresIn)
        {
            if (credentials == null)
                throw new ArgumentNullException("credentials");

            // Validate before the refresh below so an out-of-range expiration cannot trigger a credentials fetch.
            ValidateExpiresIn(expiresIn);

            var immutableCredentials = await ResolveCredentialsAsync(credentials, expiresIn).ConfigureAwait(false);
            return GenerateAuthToken(immutableCredentials, region, hostname, DBConnectAdminActionValue, expiresIn);
        }

        /// <summary>
        /// Force a refresh if the credentials would expire before the token does, so the token stays valid for its full lifetime.
        /// If someone requests a 30-minute token, we ensure the underlying credentials will last at least that long.
        /// The floor of 15 minutes prevents very short token lifetimes from accepting nearly-expired credentials.
        /// </summary>
        private static ImmutableCredentials ResolveCredentials(AWSCredentials credentials, TimeSpan tokenLifetime)
        {
            var minimumCredentialLifetime = tokenLifetime > FifteenMinutes ? tokenLifetime : FifteenMinutes;
            return credentials is RefreshingAWSCredentials refreshing
                ? refreshing.GetCredentials(minimumCredentialLifetime)
                : credentials.GetCredentials();
        }

        /// <summary>
        /// Force a refresh if the credentials would expire before the token does, so the token stays valid for its full lifetime.
        /// If someone requests a 30-minute token, we ensure the underlying credentials will last at least that long.
        /// The floor of 15 minutes prevents very short token lifetimes from accepting nearly-expired credentials.
        /// </summary>
        private static async System.Threading.Tasks.Task<ImmutableCredentials> ResolveCredentialsAsync(AWSCredentials credentials, TimeSpan tokenLifetime)
        {
            var minimumCredentialLifetime = tokenLifetime > FifteenMinutes ? tokenLifetime : FifteenMinutes;
            return credentials is RefreshingAWSCredentials refreshing
                ? await refreshing.GetCredentialsAsync(minimumCredentialLifetime).ConfigureAwait(false)
                : await credentials.GetCredentialsAsync().ConfigureAwait(false);
        }

        private static void ValidateExpiresIn(TimeSpan expiresIn)
        {
            if (expiresIn <= TimeSpan.Zero || expiresIn > MaxExpiresIn)
                throw new ArgumentOutOfRangeException("expiresIn", "ExpiresIn must be between 0 (exclusive) and 7 days (inclusive).");
        }

        private static string GenerateAuthToken(ImmutableCredentials immutableCredentials, RegionEndpoint region, string hostname, string actionValue, TimeSpan expiresIn)
        {
            if (immutableCredentials == null)
                throw new ArgumentNullException("immutableCredentials");

            if (region == null)
                throw new ArgumentNullException("region");

            hostname = hostname?.Trim();
            if (string.IsNullOrEmpty(hostname))
                throw new ArgumentException("Hostname must not be null or empty.");

            ValidateExpiresIn(expiresIn);

            // Build a neutral signing request against the public facade. Credentials have already been
            // resolved (with the 15-min floor above), so wrap them in a non-refreshing AWSCredentials so the
            // facade's own presign-window refresh is a no-op and doesn't re-resolve them.
            var signingRequest = new AWSSigningRequest
            {
                HttpMethod = HttpMethod.Get,
                RequestUri = new Uri(string.Format(CultureInfo.InvariantCulture,
                    "{0}://{1}/?{2}={3}",
                    HTTPS, hostname, ActionKey, actionValue)),
            };

            var parameters = new AWSSigV4Parameters
            {
                Credentials = WrapResolved(immutableCredentials),
                Region = region,
                Service = DSQLServiceName,
            };

            var presign = AWSSigV4Signer.Presign(signingRequest, parameters, expiresIn);

            // The token is the presigned URL with the scheme stripped: "hostname/?..."
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
