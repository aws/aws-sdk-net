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

using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Amazon.Runtime
{
    /// <summary>
    /// When running in an ECS container and AWS_CONTAINER_CREDENTIALS_RELATIVE_URI is set,
    /// use the given end point to retrieve the credentials.
    /// </summary>
    public class ECSTaskCredentials : URIBasedRefreshingCredentialHelper
    {
        /// <summary>
        /// These constants should not be consumed by client code.  They are only relevant
        /// in the context of ECS container and, especially, AWS_CONTAINER_CREDENTIALS_RELATIVE_URI, AWS_CONTAINER_CREDENTIALS_FULL_URI & AWS_CONTAINER_AUTHORIZATION_TOKEN
        /// environment variable should not be overriden by the client code.
        /// </summary>
        public const string ContainerCredentialsURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_RELATIVE_URI";
        public const string ContainerCredentialsFullURIEnvVariable = "AWS_CONTAINER_CREDENTIALS_FULL_URI";
        public const string ContainerCredentialsAuthorizationTokenEnvVariable = "AWS_CONTAINER_AUTHORIZATION_TOKEN";
        public const string EndpointAddress = "http://169.254.170.2";

        private Uri Uri {
            get
            {
                var relativeUri = Environment.GetEnvironmentVariable(ContainerCredentialsURIEnvVariable);
                var fullUri = Environment.GetEnvironmentVariable(ContainerCredentialsFullURIEnvVariable);

                // AWS_CONTAINER_CREDENTIALS_FULL_URI variable is not compatible with AWS_CONTAINER_CREDENTIALS_RELATIVE_URI, and will not be used if AWS_CONTAINER_CREDENTIALS_RELATIVE_URI is set.
                if (!string.IsNullOrEmpty(relativeUri))
                {
                    var uriBuilder = new UriBuilder(Server);
                    uriBuilder.Path = relativeUri;
                    return uriBuilder.Uri;
                }
                else if (!string.IsNullOrEmpty(fullUri))
                {
                    return new Uri(fullUri);
                }
                else
                {
                    throw new ArgumentException($"Cannot fetch credentials from container - neither {ContainerCredentialsURIEnvVariable} or {ContainerCredentialsFullURIEnvVariable}" +
                                               $" environment variables are set.");
                }
            }
        }

        private string Server = null;
        private static int MaxRetries = 5;

        private IWebProxy Proxy;

        public ECSTaskCredentials() : this(null) { PreemptExpiryTime = TimeSpan.FromMinutes(5); }

        public ECSTaskCredentials(IWebProxy proxy)
        {
            Server = EndpointAddress;
            Proxy = proxy;
            PreemptExpiryTime = TimeSpan.FromMinutes(5);
        }

        protected override CredentialsRefreshState GenerateNewCredentials()
        {
            SecurityCredentials credentials = null;
			Uri ecsEndpointUri = Uri;
            JitteredDelay retry = new JitteredDelay(new TimeSpan(0, 0, 0, 0, 200), new TimeSpan(0, 0, 0, 0, 50));
            // Attempt to get the credentials 4 times ignoring null return/exceptions and on the 5th try, escalate the exception if there is one.
            for (int i = 1; ; i++)
            {
                try
                {
                    // AWS_CONTAINER_AUTHORIZATION_TOKEN is optional environment variable
                    // If this variable is set the SDK will set the Authorization header on the HTTP request with the environment variable's value.
                    var headers = CreateAuthorizationHeader();

                    credentials = GetObjectFromResponse<SecurityCredentials>(ecsEndpointUri, Proxy, headers);
                    if (credentials != null)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    if (i == MaxRetries)
                    {
                        throw new AmazonServiceException(string.Format(CultureInfo.InvariantCulture,
                        "Unable to retrieve credentials. Message = \"{0}\".",
                        e.Message));
                    }
                };
                Util.AWSSDKUtils.Sleep(retry.Next());
            }

            return new CredentialsRefreshState(new ImmutableCredentials(credentials.AccessKeyId, credentials.SecretAccessKey, credentials.Token), credentials.Expiration);
        }

        private static Dictionary<string, string> CreateAuthorizationHeader()
        {
            Dictionary<string, string> headers = null;
            var authorizationToken = Environment.GetEnvironmentVariable(ContainerCredentialsAuthorizationTokenEnvVariable);
            if (!string.IsNullOrEmpty(authorizationToken))
            {
                headers = new Dictionary<string, string>
                {
                    {HeaderKeys.AuthorizationHeader, authorizationToken}
                };
            }

            return headers;
        }
    }
}