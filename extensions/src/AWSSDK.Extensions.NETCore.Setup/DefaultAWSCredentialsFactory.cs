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
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Microsoft.Extensions.Logging;

namespace AWSSDK.Extensions.NETCore.Setup
{
    public class DefaultAWSCredentialsFactory : IAWSCredentialsFactory
    {
        private readonly AWSOptions _options;
        private readonly ILogger<DefaultAWSCredentialsFactory> _logger;

        public DefaultAWSCredentialsFactory(AWSOptions options, ILogger<DefaultAWSCredentialsFactory> logger = null)
        {
            _options = options;
            _logger = logger;
        }

        /// <summary>
        /// Creates the AWSCredentials using either AWSOptions.Credentials, AWSOptions.Profile + AWSOptions.ProfilesLocation,
        /// or the SDK fallback credentials search.
        /// </summary>
        public AWSCredentials Create()
        {
            if (_options?.Credentials != null)
            {
                _logger?.LogInformation("Using AWS credentials specified with the AWSOptions.Credentials property");
                return _options.Credentials;
            }

            if (!string.IsNullOrWhiteSpace(_options?.Profile))
            {
                var chain = new CredentialProfileStoreChain(_options.ProfilesLocation);
                if (chain.TryGetAWSCredentials(_options.Profile, out var result))
                {
                    _logger?.LogInformation("Found AWS credentials for the profile {OptionsProfile}", _options.Profile);
                    return result;
                }

                _logger?.LogInformation("Failed to find AWS credentials for the profile {OptionsProfile}", _options.Profile);
            }

            var credentials = FallbackCredentialsFactory.GetCredentials();
            if (credentials == null)
            {
                _logger?.LogError("Last effort to find AWS Credentials with AWS SDK's default credential search failed");
                throw new AmazonClientException("Failed to find AWS Credentials for constructing AWS service client");
            }

            _logger?.LogInformation("Found credentials using the AWS SDK's default credential search");

            return credentials;
        }
    }
}