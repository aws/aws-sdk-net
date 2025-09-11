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
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Amazon.Runtime;
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Util;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Amazon.Extensions.NETCore.Setup
{
    /// <summary>
    /// The factory class for creating AWS service clients from the AWS SDK for .NET.
    /// </summary>
    internal class ClientFactory<T>
        where T : IAmazonService
    {
        private static readonly Type[] EMPTY_TYPES = Array.Empty<Type>();
        private static readonly object[] EMPTY_PARAMETERS = Array.Empty<object>();

        private AWSOptions _awsOptions;

        /// <summary>
        /// Constructs an instance of the ClientFactory
        /// </summary>
        /// <param name="awsOptions">The AWS options used for creating service clients.</param>
        internal ClientFactory(AWSOptions awsOptions)
        {
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

            return CreateServiceClient(logger, options);
        }

        /// <summary>
        /// Creates the AWS service client that implements the service client interface. The AWSOptions object
        /// will be searched for in the IServiceProvider.
        /// </summary>
        /// <param name="logger">Logger instance for writing diagnostic logs.</param>
        /// <param name="options">The AWS options used for creating the service client.</param>
        /// <returns>The AWS service client</returns>
        internal IAmazonService CreateServiceClient(ILogger logger, AWSOptions options)
        {
            PerformGlobalConfig(logger, options);
            var credentials = CreateCredentials(logger, options);

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

            var config = CreateConfig(options);
            var client = CreateClient(credentials, config);
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
        private static AmazonServiceClient CreateClient(AWSCredentials credentials, ClientConfig config)
        {
#if NET8_0_OR_GREATER
            return T.CreateDefaultServiceClient(credentials, config) as AmazonServiceClient;
#else
            var clientTypeName = typeof(T).Namespace + "." + typeof(T).Name.Substring(1) + "Client";
            var clientType = typeof(T).GetTypeInfo().Assembly.GetType(clientTypeName);
            if (clientType == null)
            {
                throw new AmazonClientException($"Failed to find service client {clientTypeName} which implements {typeof(T).FullName}.");
            }

            var constructor = clientType.GetConstructor(new Type[] { typeof(AWSCredentials), config.GetType() });
            if (constructor == null)
            {
                throw new AmazonClientException($"Service client {clientTypeName} missing a constructor with parameters AWSCredentials and {config.GetType().FullName}.");
            }

            return constructor.Invoke(new object[] { credentials, config }) as AmazonServiceClient;
#endif
        }

        /// <summary>
        /// Creates the AWSCredentials using either the profile indicated from the AWSOptions object
        /// of the SDK fallback credentials search.
        /// </summary>
        /// <param name="logger"></param>
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

            var credentials = DefaultIdentityResolverConfiguration.ResolveDefaultIdentity<AWSCredentials>();
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
        private ClientConfig CreateConfig(AWSOptions options)
        {
#if NET8_0_OR_GREATER
            ClientConfig config = T.CreateDefaultClientConfig();
#else
            var configTypeName = typeof(T).Namespace + "." + typeof(T).Name.Substring(1) + "Config";
            var configType = typeof(T).GetTypeInfo().Assembly.GetType(configTypeName);

            var constructor = configType.GetConstructor(EMPTY_TYPES);
            ClientConfig config = constructor.Invoke(EMPTY_PARAMETERS) as ClientConfig;
#endif

            if (options == null)
            {
                options = new AWSOptions();
            }

            var defaultConfig = options.DefaultClientConfig;


            // There is intertwined logic between ServiceURL, Region and DefaultConfigurationMode
            // in the SDK. They are handled at the start together to make it easier to debug SDK behavior.
            if (!string.IsNullOrEmpty(defaultConfig.ServiceURL))
            {
                config.ServiceURL = defaultConfig.ServiceURL;
            }
            // Setting RegionEndpoint only if ServiceURL was not set, because ServiceURL value will be lost otherwise
            else if (options.Region != null)
            {
                config.RegionEndpoint = options.Region;
            }

            if (options.DefaultConfigurationMode.HasValue)
            {
                config.DefaultConfigurationMode = options.DefaultConfigurationMode.Value;
            }



            if (defaultConfig.AllowAutoRedirect.HasValue)
            {
                config.AllowAutoRedirect = defaultConfig.AllowAutoRedirect.Value;
            }
            if (defaultConfig.AuthenticationRegion != null)
            {
                config.AuthenticationRegion = defaultConfig.AuthenticationRegion;
            }
            if (defaultConfig.BufferSize.HasValue)
            {
                config.BufferSize = defaultConfig.BufferSize.Value;
            }
            if (defaultConfig.ClientAppId != null)
            {
                config.ClientAppId = defaultConfig.ClientAppId;
            }
            if (defaultConfig.DisableHostPrefixInjection.HasValue)
            {
                config.DisableHostPrefixInjection = defaultConfig.DisableHostPrefixInjection.Value;
            }
            if (defaultConfig.DisableLogging.HasValue)
            {
                config.DisableLogging = defaultConfig.DisableLogging.Value;
            }
            if (defaultConfig.DisableRequestCompression.HasValue)
            {
                config.DisableRequestCompression = defaultConfig.DisableRequestCompression.Value;
            }
            if (defaultConfig.EndpointDiscoveryCacheLimit.HasValue)
            {
                config.EndpointDiscoveryCacheLimit = defaultConfig.EndpointDiscoveryCacheLimit.Value;
            }
            if (defaultConfig.EndpointDiscoveryEnabled.HasValue)
            {
                config.EndpointDiscoveryEnabled = defaultConfig.EndpointDiscoveryEnabled.Value;
            }
            if (defaultConfig.FastFailRequests.HasValue)
            {
                config.FastFailRequests = defaultConfig.FastFailRequests.Value;
            }
            if (defaultConfig.IgnoreConfiguredEndpointUrls.HasValue)
            {
                config.IgnoreConfiguredEndpointUrls = defaultConfig.IgnoreConfiguredEndpointUrls.Value;
            }
            if (defaultConfig.LogMetrics.HasValue)
            {
                config.LogMetrics = defaultConfig.LogMetrics.Value;
            }
            if (defaultConfig.LogResponse.HasValue)
            {
                config.LogResponse = defaultConfig.LogResponse.Value;
            }
            if (defaultConfig.MaxErrorRetry.HasValue)
            {
                config.MaxErrorRetry = defaultConfig.MaxErrorRetry.Value;
            }
            if (defaultConfig.ProgressUpdateInterval.HasValue)
            {
                config.ProgressUpdateInterval = defaultConfig.ProgressUpdateInterval.Value;
            }
            if (defaultConfig.RequestMinCompressionSizeBytes.HasValue)
            {
                config.RequestMinCompressionSizeBytes = defaultConfig.RequestMinCompressionSizeBytes.Value;
            }
            if (defaultConfig.ResignRetries.HasValue)
            {
                config.ResignRetries = defaultConfig.ResignRetries.Value;
            }
            if (defaultConfig.RetryMode.HasValue)
            {
                config.RetryMode = defaultConfig.RetryMode.Value;
            }
            if (defaultConfig.ThrottleRetries.HasValue)
            {
                config.ThrottleRetries = defaultConfig.ThrottleRetries.Value;
            }
            if (defaultConfig.Timeout.HasValue)
            {
                config.Timeout = defaultConfig.Timeout.Value;
            }
#if NET8_0_OR_GREATER
            if (defaultConfig.ConnectTimeout.HasValue)
            {
                config.ConnectTimeout = defaultConfig.ConnectTimeout.Value;
            }
            if (defaultConfig.MaxConnectionsPerServer.HasValue)
            {
                config.MaxConnectionsPerServer = defaultConfig.MaxConnectionsPerServer.Value;
            }
#endif
            if (defaultConfig.UseAlternateUserAgentHeader.HasValue)
            {
                config.UseAlternateUserAgentHeader = defaultConfig.UseAlternateUserAgentHeader.Value;
            }
            if (defaultConfig.UseDualstackEndpoint.HasValue)
            {
                config.UseDualstackEndpoint = defaultConfig.UseDualstackEndpoint.Value;
            }
            if (defaultConfig.UseFIPSEndpoint.HasValue)
            {
                config.UseFIPSEndpoint = defaultConfig.UseFIPSEndpoint.Value;
            }
            if (defaultConfig.UseHttp.HasValue)
            {
                config.UseHttp = defaultConfig.UseHttp.Value;
            }

            if (defaultConfig.ServiceSpecificSettings.Count > 0)
            {
                ProcessServiceSpecificSettings(config, defaultConfig.ServiceSpecificSettings);
            }

            // It is possible that this library might be used in .NET Framework application. In that
            // case the SDK used at runtime will be the .NET Framework variant. To avoid getting
            // MissingMethodException exceptions for config properties that don't exist in 
            // .NET Framework variant put the set calls in a separate method only called
            // if the SDK is not the .NET Framework variant.
            if (!AWSSDKUtils.IsNETFramework())
            {
                SetNETStandardAndAboveSettings(defaultConfig, config);
            }

            return config;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void SetNETStandardAndAboveSettings(DefaultClientConfig defaultConfig, ClientConfig config)
        {
            if (defaultConfig.HttpClientCacheSize.HasValue)
            {
                config.HttpClientCacheSize = defaultConfig.HttpClientCacheSize.Value;
            }
        }

#if NET8_0_OR_GREATER
        [UnconditionalSuppressMessage("ReflectionAnalysis", "IL2075",
              Justification = "The parent calling method uses the DynamicDependencyAttribute on the service client to ensure the public properties are not trimmed.")]
#endif
        private void ProcessServiceSpecificSettings(ClientConfig clientConfig, IDictionary<string, string> serviceSettings)
        {
            var singleArray = new object[1];
            var properties = clientConfig.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var kvp in serviceSettings)
            {
                var property = properties.FirstOrDefault(x => string.Equals(x.Name, kvp.Key, StringComparison.OrdinalIgnoreCase));
                if (property == null)
                    continue;

                var propertyType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                try
                {
                    if (propertyType == typeof(TimeSpan))
                    {
                        singleArray[0] = TimeSpan.FromMilliseconds(Convert.ToInt64(kvp.Value));
                    }
                    else if (propertyType.IsEnum)
                    {
                        singleArray[0] = Enum.Parse(propertyType, kvp.Value, true);
                    }
                    else
                    {
                        singleArray[0] = Convert.ChangeType(kvp.Value, propertyType);
                    }

                    property.SetMethod.Invoke(clientConfig, singleArray);
                }
                catch (Exception e)
                {
                    throw new ConfigurationException($"Error reading value for property {kvp.Key}.", e)
                    {
                        PropertyName = kvp.Key,
                        PropertyValue = kvp.Value
                    };
                }
            }
        }
    }
}
