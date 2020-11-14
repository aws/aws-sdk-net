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
using System.Reflection;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// The factory class for creating AWS service clients from the AWS SDK for .NET.
    /// </summary>
    internal class ClientFactory
    {
        private static readonly Type[] EMPTY_TYPES = Array.Empty<Type>();
        private static readonly object[] EMPTY_PARAMETERS = Array.Empty<object>();

        private Type _serviceInterfaceType;
        private AWSOptions _awsOptions;

        /// <summary>
        /// Constructs an instance of the ClientFactory
        /// </summary>
        /// <param name="type">The type object for the Amazon service client interface, for example IAmazonS3.</param>
        internal ClientFactory(Type type, AWSOptions awsOptions)
        {
            _serviceInterfaceType = type;
            _awsOptions = awsOptions;
        }

        /// <summary>
        /// Creates the AWS service client that implements the service client interface. The AWSOptions object
        /// will be searched for in the IServiceProvider.
        /// </summary>
        /// <param name="provider">The dependency injection provider.</param>
        /// <returns>The AWS service client</returns>
        internal object CreateServiceClient(IServiceProvider provider)
        {
            var loggerFactory = provider.GetService<Microsoft.Extensions.Logging.ILoggerFactory>();
            var logger = loggerFactory?.CreateLogger("AWSSDK");

            var options = _awsOptions ?? provider.GetService<AWSOptions>();
            if(options == null)
            {
                var configuration = provider.GetService<IConfiguration>();
                if(configuration != null)
                {
                    options = configuration.GetAWSOptions();
                    if (options != null)
                        logger?.LogInformation("Found AWS options in IConfiguration");
                }
            }

            return CreateServiceClient(logger, _serviceInterfaceType, options);
        }

        /// <summary>
        /// Creates the AWS service client that implements the service client interface. The AWSOptions object
        /// will be searched for in the IServiceProvider.
        /// </summary>
        /// <param name="provider">The dependency injection provider.</param>
        /// <returns>The AWS service client</returns>
        internal static IAmazonService CreateServiceClient(ILogger logger, Type serviceInterfaceType, AWSOptions options)
        {
            PerformGlobalConfig(logger, options);
            var credentials = CreateCredentials(logger, options);

            if (!string.IsNullOrEmpty(options.SessionRoleArn))
            {
                credentials = new AssumeRoleAWSCredentials(credentials, options.SessionRoleArn, options.SessionName);
            }

            var config = CreateConfig(serviceInterfaceType, options);
            var client = CreateClient(serviceInterfaceType, credentials, config);
            return client as IAmazonService;
        }

        /// <summary>
        /// Performs all of the global settings that have been specified in AWSOptions.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="options"></param>
        private static void PerformGlobalConfig(ILogger logger, AWSOptions options)
        {
            if(options?.Logging != null)
            {
                if(options.Logging.LogTo.HasValue && AWSConfigs.LoggingConfig.LogTo != options.Logging.LogTo.Value)
                {
                    AWSConfigs.LoggingConfig.LogTo = options.Logging.LogTo.Value;
                    logger?.LogDebug($"Configuring SDK LogTo: {AWSConfigs.LoggingConfig.LogTo}");
                }

                if (options.Logging.LogResponses.HasValue && AWSConfigs.LoggingConfig.LogResponses != options.Logging.LogResponses.Value)
                {
                    AWSConfigs.LoggingConfig.LogResponses = options.Logging.LogResponses.Value;
                    logger?.LogDebug($"Configuring SDK LogResponses: {AWSConfigs.LoggingConfig.LogResponses}");
                }

                if (options.Logging.LogMetrics.HasValue && AWSConfigs.LoggingConfig.LogMetrics != options.Logging.LogMetrics.Value)
                {
                    AWSConfigs.LoggingConfig.LogMetrics = options.Logging.LogMetrics.Value;
                    logger?.LogDebug($"Configuring SDK LogMetrics: {AWSConfigs.LoggingConfig.LogMetrics}");
                }

                if (options.Logging.LogResponsesSizeLimit.HasValue && AWSConfigs.LoggingConfig.LogResponsesSizeLimit != options.Logging.LogResponsesSizeLimit.Value)
                {
                    AWSConfigs.LoggingConfig.LogResponsesSizeLimit = options.Logging.LogResponsesSizeLimit.Value;
                    logger?.LogDebug($"Configuring SDK LogResponsesSizeLimit: {AWSConfigs.LoggingConfig.LogResponsesSizeLimit}");
                }
            }
        }

        /// <summary>
        /// Creates the service client using the credentials and client config.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        /// <returns></returns>
        private static AmazonServiceClient CreateClient(Type serviceInterfaceType, AWSCredentials credentials, ClientConfig config)
        {
            var clientTypeName = serviceInterfaceType.Namespace + "." + serviceInterfaceType.Name.Substring(1) + "Client";
            var clientType = serviceInterfaceType.GetTypeInfo().Assembly.GetType(clientTypeName);
            if (clientType == null)
            {
                throw new AmazonClientException($"Failed to find service client {clientTypeName} which implements {serviceInterfaceType.FullName}.");
            }

            var constructor = clientType.GetConstructor(new Type[] { typeof(AWSCredentials), config.GetType() });
            if (constructor == null)
            {
                throw new AmazonClientException($"Service client {clientTypeName} missing a constructor with parameters AWSCredentials and {config.GetType().FullName}.");
            }

            return constructor.Invoke(new object[] { credentials, config }) as AmazonServiceClient;
        }

        /// <summary>
        /// Creates the AWSCredentials using either the profile indicated from the AWSOptions object
        /// of the SDK fallback credentials search.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private static AWSCredentials CreateCredentials(ILogger logger, AWSOptions options)
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

            var credentials = FallbackCredentialsFactory.GetCredentials();
            if (credentials == null)
            {
                logger?.LogError("Last effort to find AWS Credentials with AWS SDK's default credential search failed");
                throw new AmazonClientException("Failed to find AWS Credentials for constructing AWS service client");
            }
            else
            {
                logger?.LogInformation("Found credentials using the AWS SDK's default credential search");
            }

            return credentials;
        }

        /// <summary>
        /// Creates the ClientConfig object for the service client.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private static ClientConfig CreateConfig(Type serviceInterfaceType, AWSOptions options)
        {
            var configTypeName = serviceInterfaceType.Namespace + "." + serviceInterfaceType.Name.Substring(1) + "Config";
            var configType = serviceInterfaceType.GetTypeInfo().Assembly.GetType(configTypeName);

            var constructor = configType.GetConstructor(EMPTY_TYPES);
            ClientConfig config = constructor.Invoke(EMPTY_PARAMETERS) as ClientConfig;

            if(options == null)
            {
                options = new AWSOptions();
            }

            if (options.DefaultConfigurationMode.HasValue)
            {
                config.DefaultConfigurationMode = options.DefaultConfigurationMode.Value;
            }

            var defaultConfig = options.DefaultClientConfig;
            if (options.IsDefaultClientConfigSet)
            {
                var emptyArray = new object[0];
                var singleArray = new object[1];

                var clientConfigTypeInfo = typeof(ClientConfig).GetTypeInfo();
                foreach (var property in clientConfigTypeInfo.DeclaredProperties)
                {
                    if (property.GetMethod != null && property.SetMethod != null)
                    {
                        // Skip RegionEndpoint because it is set below and calling the get method on the
                        // property triggers the default region fallback mechanism.
                        if (string.Equals(property.Name, "RegionEndpoint", StringComparison.Ordinal))
                            continue;

                        // DefaultConfigurationMode is skipped from the DefaultClientConfig because it is expected to be set
                        // at the top level of AWSOptions which is done before this loop.
                        if (string.Equals(property.Name, "DefaultConfigurationMode", StringComparison.Ordinal))
                            continue;

                        // Skip setting RetryMode if it is set to legacy but the DefaultConfigurationMode is not legacy.
                        // This will allow the retry mode to be configured from the DefaultConfiguration.
                        // This is a workaround to handle the inability to tell if RetryMode was explicitly set.
                        if (string.Equals(property.Name, "RetryMode", StringComparison.Ordinal) && 
                            defaultConfig.RetryMode == RequestRetryMode.Legacy && 
                            config.DefaultConfigurationMode != DefaultConfigurationMode.Legacy)
                            continue;

                        singleArray[0] = property.GetMethod.Invoke(defaultConfig, emptyArray);
                        if (singleArray[0] != null)
                        {
                            property.SetMethod.Invoke(config, singleArray);
                        }
                    }
                }
            }

            // Setting RegionEndpoint only if ServiceURL was not set, because ServiceURL value will be lost otherwise
            if (options.Region != null && string.IsNullOrEmpty(defaultConfig.ServiceURL))
            {
                config.RegionEndpoint = options.Region;
            }

            return config;
        }
    }
}
