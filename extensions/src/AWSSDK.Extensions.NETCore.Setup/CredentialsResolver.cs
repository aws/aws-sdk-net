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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;

using Microsoft.Extensions.Logging;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// Resolves the <see cref="AWSCredentials"/> described by an <see cref="AWSOptions"/> instance.
    /// This is the single credential-resolution path shared by service client creation
    /// (<see cref="ClientFactory{T}"/>) and the public <see cref="AWSOptions.GetCredentials()"/> method,
    /// so both honor the same precedence and assume-role behavior.
    /// </summary>
    internal static class CredentialsResolver
    {
        /// <summary>
        /// Resolves the AWSCredentials for the supplied options, applying the SessionRoleArn assume-role
        /// wrapping when configured. This is the fully-resolved set of credentials that would be handed to a
        /// service client created from the same options.
        /// </summary>
        /// <param name="options">The AWS options describing how to resolve credentials.</param>
        /// <param name="logger">Optional logger for diagnostic messages.</param>
        /// <returns>The resolved credentials. Never null; throws if no credentials can be found.</returns>
        internal static AWSCredentials ResolveCredentials(AWSOptions options, ILogger logger = null)
        {
            var credentials = ResolveBaseCredentials(options, logger);

            // If a role to assume is configured, wrap the resolved credentials so the returned credentials
            // match what a service client built from these same options would use.
            if (!string.IsNullOrEmpty(options?.SessionRoleArn))
            {
                if (string.IsNullOrEmpty(options?.ExternalId))
                {
                    credentials = new AssumeRoleAWSCredentials(credentials, options.SessionRoleArn, options.SessionName);
                }
                else
                {
                    credentials = new AssumeRoleAWSCredentials(credentials, options.SessionRoleArn, options.SessionName, new AssumeRoleAWSCredentialsOptions() { ExternalId = options.ExternalId });
                }
            }

            return credentials;
        }

        /// <summary>
        /// Resolves the base AWSCredentials using either the explicitly set Credentials, the profile indicated
        /// from the AWSOptions object, or the SDK fallback credentials search. Does not apply the SessionRoleArn
        /// assume-role wrapping.
        /// </summary>
        /// <param name="options">The AWS options describing how to resolve credentials.</param>
        /// <param name="logger">Optional logger for diagnostic messages.</param>
        /// <returns>The resolved base credentials. Never null; throws if no credentials can be found.</returns>
        private static AWSCredentials ResolveBaseCredentials(AWSOptions options, ILogger logger)
        {
            if (options != null)
            {
                if (options.Credentials != null)
                {
                    logger?.LogInformation("Using AWS credentials specified with the AWSOptions.Credentials property");
                    return options.Credentials;
                }
                if (!string.IsNullOrEmpty(options.Profile))
                {
                    var chain = new CredentialProfileStoreChain(options.ProfilesLocation);
                    AWSCredentials result;
                    if (chain.TryGetAWSCredentials(options.Profile, out result))
                    {
                        logger?.LogInformation($"Found AWS credentials for the profile {options.Profile}");
                        return result;
                    }
                    else
                    {
                        logger?.LogInformation($"Failed to find AWS credentials for the profile {options.Profile}");
                    }
                }
            }

            var credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
            if (credentials == null)
            {
                logger?.LogError("Last effort to find AWS Credentials with AWS SDK's default credential search failed");
                throw new AmazonClientException("Failed to find AWS Credentials using the SDK's default credential search");
            }
            else
            {
                logger?.LogInformation("Found credentials using the AWS SDK's default credential search");
            }

            return credentials;
        }
    }
}
