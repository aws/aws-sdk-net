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

using Amazon.Runtime.Internal.UserAgent;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Runtime
{
    /// <summary>
    /// <para>
    /// Generic provider that supports retrieval of AWS credentials from an arbitrary HTTP(S) endpoint specified by the environment.
    /// </para>
    /// 
    /// <para>
    /// This provider is restricted to communication over loopback and allowlisted link-local interfaces unless the target endpoint is over HTTPS. 
    /// The credentials request can also include an authentication token loaded through the environment.
    /// </para>
    /// </summary>
    public class GenericContainerCredentials : URIBasedRefreshingCredentialHelper
    {
        /// <summary>
        /// Number of times the provider will attempt to fetch credentials before escalating any errors.
        /// </summary>
        private const int MaxRetries = 5;

        // These contants should not be consumed by client code.
        // They are only relevant for the provider to determine which order to use when retrieving credentials.
        internal const string RelativeURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI";
        internal const string FullURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_FULL_URI";

        internal const string AuthorizationTokenEnvVariable = "AWS_CONTAINER_AUTHORIZATION_TOKEN";
        internal const string AuthorizationTokenFileEnvVariable = "AWS_CONTAINER_AUTHORIZATION_TOKEN_FILE";

        private const string ECSContainerHostAddress = "169.254.170.2";
        private const string EKSContainerHostIPv4Address = "169.254.170.23";
        private const string EKSContainerHostIPv6Address = "[fd00:ec2::23]";

        private readonly string[] AllowedHosts = new string[]
        {
            ECSContainerHostAddress,
            EKSContainerHostIPv4Address,
            EKSContainerHostIPv6Address,
        };

        private const string MissingEnvErrorMessage = "Cannot fetch credentials from container - neither {0} or {1} environment variables are set.";
        private const string InvalidHostErrorMessage = "Cannot fetch credentials from container - the full URI contains an invalid host: {0}";

        internal Uri ResolvedEndpointUri { get; private set; }

        public GenericContainerCredentials()
        {
            PreemptExpiryTime = TimeSpan.FromMinutes(15);
            DetermineEndpoint();
            FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_HTTP);
        }

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            SecurityCredentials credentials;
            JitteredDelay retry = new JitteredDelay(TimeSpan.FromMilliseconds(200), TimeSpan.FromMilliseconds(50));

            // Attempt to get the credentials 4 times ignoring null return/exceptions and on the 5th try, escalate the exception if there is one.
            for (int i = 1; ; i++)
            {
                try
                {
                    var headers = CreateAuthorizationHeader();

                    // This provider intentionally does not use a proxy when retrieving credentials from the determined endpoint.
                    credentials = GetObjectFromResponse<SecurityCredentials, SecurityCredentialsJsonSerializerContexts>(ResolvedEndpointUri, proxy: null, headers);
                    if (credentials != null)
                    {
                        break;
                    }
                }
                catch (Exception exception)
                {
                    if (i == MaxRetries)
                    {
                        // GetObjectFromResponse returns a "Unable to reach credentials server" generic message, but we'll check if there are inner exceptions available.
                        // They may contain more details about the error (e.g. 500 Internal Server Error).
                        while (exception.InnerException != null)
                        {
                            exception = exception.InnerException;
                        }

                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Unable to retrieve credentials. Message = \"{0}\"", exception.Message));
                    }
                };

                AWSSDKUtils.Sleep(retry.Next());
            }

            return new CredentialsRefreshState(new ImmutableCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.Token, credentials.AccountId), credentials.Expiration);
        }

        protected override async Task<CredentialsRefreshState> GenerateNewCredentialsAsync()
        {
            SecurityCredentials credentials;
            JitteredDelay retry = new JitteredDelay(TimeSpan.FromMilliseconds(200), TimeSpan.FromMilliseconds(50));

            // Attempt to get the credentials 4 times ignoring null return/exceptions and on the 5th try, escalate the exception if there is one.
            for (int i = 1; ; i++)
            {
                try
                {
                    var headers = CreateAuthorizationHeader();

                    // This provider intentionally does not use a proxy when retrieving credentials from the determined endpoint.
                    credentials = await GetObjectFromResponseAsync<SecurityCredentials, SecurityCredentialsJsonSerializerContexts>(ResolvedEndpointUri, proxy: null, headers).ConfigureAwait(false);
                    if (credentials != null)
                    {
                        break;
                    }
                }
                catch (Exception exception)
                {
                    if (i == MaxRetries)
                    {
                        // GetObjectFromResponse returns a "Unable to reach credentials server" generic message, but we'll check if there are inner exceptions available.
                        // They may contain more details about the error (e.g. 500 Internal Server Error).
                        while (exception.InnerException != null)
                        {
                            exception = exception.InnerException;
                        }

                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture, "Unable to retrieve credentials. Message = \"{0}\"", exception.Message));
                    }
                }

                await Task.Delay(retry.Next()).ConfigureAwait(false);
            }

            return new CredentialsRefreshState(new ImmutableCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.Token, credentials.AccountId), credentials.Expiration);
        }

        /// <summary>
        /// Determines the endpoint where the credentials retrieval request should be sent.
        /// This provider will respect the following sources, in order of priority, to determine the request URI:
        /// <list type="number">
        /// <item>If AWS_CONTAINER_CREDENTIALS_RELATIVE_URI is set, its value is appended to the ECS link-local host</item>
        /// <item>If AWS_CONTAINER_CREDENTIALS_FULL_URI is set, its value is taken as-is</item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// This provider will also validate the URI hostname satisfies one of the following conditions:
        /// <list type="bullet">
        /// <item>Is within the loopback CIDR</item>
        /// <item>Is the ECS or EKS container host</item>
        /// <item>Is using the HTTPS scheme</item>
        /// </list>
        /// <para>This method is also marked as internal so it can be unit tested.</para>
        /// </remarks>
        internal void DetermineEndpoint()
        {
            Uri resolvedUri = null;
            var relativeUri = Environment.GetEnvironmentVariable(RelativeURIEnvVariable);
            var fullUri = Environment.GetEnvironmentVariable(FullURIEnvVariable);

            if (!string.IsNullOrEmpty(relativeUri))
            {
                var uriBuilder = new UriBuilder(ECSContainerHostAddress)
                {
                    Path = relativeUri
                };

                resolvedUri = uriBuilder.Uri;
            }
            else if (!string.IsNullOrEmpty(fullUri))
            {
                resolvedUri = new Uri(fullUri);
            }
            
            if (resolvedUri == null)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, MissingEnvErrorMessage, RelativeURIEnvVariable, FullURIEnvVariable));
            }

            // If the resolved URI's scheme is HTTPS, its hostname may be used in the request as is.
            if (resolvedUri.Scheme != Uri.UriSchemeHttps)
            {
                // Otherwise, we must validate it's an allowlisted address.
                var isValidHost = AllowedHosts.Contains(resolvedUri.Host);
                if (!isValidHost && !resolvedUri.IsLoopback)
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, InvalidHostErrorMessage, resolvedUri.ToString()));
                }
            }

            ResolvedEndpointUri = resolvedUri;
        }

        /// <summary>
        /// Reads the authorization token (if present) to be used when retrieving credentials.
        /// This provider will respect the following sources, in order of priority, to determine how to present authentication in the request:
        /// <list type="number">
        /// <item>AWS_CONTAINER_AUTHORIZATION_TOKEN_FILE</item>
        /// <item>AWS_CONTAINER_AUTHORIZATION_TOKEN</item>
        /// </list>
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the resolved value contains the "\r\n" newline sequence (it would otherwise break the resulting HTTP request).
        /// </exception>
        /// <remarks>This method is marked as internal so it can be unit tested.</remarks>
        internal static Dictionary<string, string> CreateAuthorizationHeader()
        {
            const string NewLineSequence = "\r\n";
            Dictionary<string, string> headers = null;
            string authorizationTokenValue = null;

            var authorizationTokenFilePath = Environment.GetEnvironmentVariable(AuthorizationTokenFileEnvVariable);
            var authorizationTokenStaticValue = Environment.GetEnvironmentVariable(AuthorizationTokenEnvVariable);

            if (!string.IsNullOrEmpty(authorizationTokenFilePath))
            {
                authorizationTokenValue = File.ReadAllText(authorizationTokenFilePath);
            }
            else if (!string.IsNullOrEmpty(authorizationTokenStaticValue))
            {
                authorizationTokenValue = authorizationTokenStaticValue;
            }

            if (!string.IsNullOrEmpty(authorizationTokenValue))
            {
                if (authorizationTokenValue.Contains(NewLineSequence))
                {
                    throw new InvalidOperationException("Authorization token must not contain the newline sequence.");
                }

                headers = new Dictionary<string, string>
                {
                    { HeaderKeys.AuthorizationHeader, authorizationTokenValue }
                };
            }

            return headers;
        }
    }
}
