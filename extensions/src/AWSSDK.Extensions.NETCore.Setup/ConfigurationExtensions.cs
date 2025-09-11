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

using Amazon;
using Amazon.Runtime;
using Amazon.Util;

using Amazon.Extensions.NETCore.Setup;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Microsoft.Extensions.Configuration
{
    /// <summary>
    /// This class adds extension methods to IConfiguration making it easier to pull out
    /// AWS configuration options.
    /// </summary>
    public static class ConfigurationExtensions
    {
        /// <summary>
        /// The default section where settings are read from the IConfiguration object. This is set to "AWS".
        /// </summary>
        public const string DEFAULT_CONFIG_SECTION = "AWS";

        const string ProfileKey = "Profile";
        const string AWSProfileNameKey = "AWSProfileName";
        const string ProfilesLocationKey = "ProfilesLocation";
        const string AWSProfilesLocationKey = "AWSProfilesLocation";
        const string RegionKey = "Region";
        const string AWSRegionKey = "AWSRegion";
        const string DefaultsModeKey = "DefaultsMode";
        const string SessionRoleArnKey = "SessionRoleArn";
        const string SessionNameKey = "SessionName";
        const string LoggingKey = "Logging";



        /// <summary>
        /// Constructs an AWSOptions class with the options specified in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="config"></param>
        /// <returns>The AWSOptions containing the values set in configuration system.</returns>
        public static AWSOptions GetAWSOptions(this IConfiguration config)
        {
            return GetAWSOptions(config, DEFAULT_CONFIG_SECTION);
        }

        /// <summary>
        /// Constructs an AWSOptions class with the options specified in the "AWS" section in the IConfiguration object.
        /// </summary>
        /// <param name="config"></param>
        /// <param name="configSection">The config section to extract AWS options from.</param>
        /// <returns>The AWSOptions containing the values set in configuration system.</returns>
        public static AWSOptions GetAWSOptions(this IConfiguration config, string configSection)
        {
            var options = new AWSOptions
            {
                DefaultClientConfig = new DefaultClientConfig(),
            };

            IConfiguration section;
            if (string.IsNullOrEmpty(configSection))
                section = config;
            else
                section = config.GetSection(configSection);

            if (section == null)
                return options;

            foreach(var element in section.GetChildren())
            {
                if (string.IsNullOrEmpty(element.Value))
                    continue;


                // Logging is handled outside of this loop
                if (string.Equals(element.Key, LoggingKey, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }
                // Include checking legacy key
                else if (string.Equals(element.Key, ProfileKey, StringComparison.OrdinalIgnoreCase) || string.Equals(element.Key, AWSProfileNameKey, StringComparison.OrdinalIgnoreCase))
                {
                    options.Profile = element.Value;
                }
                // Include checking legacy key
                else if (string.Equals(element.Key, ProfilesLocationKey, StringComparison.OrdinalIgnoreCase) || string.Equals(element.Key, AWSProfilesLocationKey, StringComparison.OrdinalIgnoreCase))
                {
                    options.ProfilesLocation = element.Value;
                }
                // Include checking legacy key
                else if (string.Equals(element.Key, RegionKey, StringComparison.OrdinalIgnoreCase) || string.Equals(element.Key, AWSRegionKey, StringComparison.OrdinalIgnoreCase))
                {
                    options.Region = RegionEndpoint.GetBySystemName(element.Value);
                }
                else if (string.Equals(element.Key, DefaultsModeKey, StringComparison.OrdinalIgnoreCase))
                {
                    if (!Enum.TryParse<DefaultConfigurationMode>(element.Value, out var mode))
                    {
                        throw new ArgumentException($"Invalid value for DefaultConfiguration. Valid values are: {string.Join(", ", Enum.GetNames(typeof(DefaultConfigurationMode)))} ");
                    }
                    options.DefaultConfigurationMode = mode;
                }
                else if (string.Equals(element.Key, SessionRoleArnKey, StringComparison.OrdinalIgnoreCase))
                {
                    options.SessionRoleArn = element.Value;
                }
                else if (string.Equals(element.Key, SessionNameKey, StringComparison.OrdinalIgnoreCase))
                {
                    options.SessionName = element.Value;
                }

                // Start DefaultConfigClient settings
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.AllowAutoRedirect), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var allowAutoRedirect))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.AllowAutoRedirect)}.");
                    }

                    options.DefaultClientConfig.AllowAutoRedirect = allowAutoRedirect;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.AuthenticationRegion), StringComparison.OrdinalIgnoreCase))
                {
                    options.DefaultClientConfig.AuthenticationRegion = element.Value;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.BufferSize), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var bufferSize))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.BufferSize)}.");
                    }

                    options.DefaultClientConfig.BufferSize = bufferSize;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ClientAppId), StringComparison.OrdinalIgnoreCase))
                {
                    options.DefaultClientConfig.ClientAppId = element.Value;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.DisableHostPrefixInjection), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var disableHostPrefixInjection))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.DisableHostPrefixInjection)}.");
                    }

                    options.DefaultClientConfig.DisableHostPrefixInjection = disableHostPrefixInjection;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.DisableLogging), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var disableLogging))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.DisableLogging)}.");
                    }

                    options.DefaultClientConfig.DisableLogging = disableLogging;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.DisableRequestCompression), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var disableRequestCompression))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.DisableRequestCompression)}.");
                    }

                    options.DefaultClientConfig.DisableRequestCompression = disableRequestCompression;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.EndpointDiscoveryCacheLimit), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var endpointDiscoveryCacheLimit))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.EndpointDiscoveryCacheLimit)}.");
                    }

                    options.DefaultClientConfig.EndpointDiscoveryCacheLimit = endpointDiscoveryCacheLimit;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.EndpointDiscoveryEnabled), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var endpointDiscoveryEnabled))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.EndpointDiscoveryEnabled)}.");
                    }

                    options.DefaultClientConfig.EndpointDiscoveryEnabled = endpointDiscoveryEnabled;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.FastFailRequests), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var fastFailRequests))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.FastFailRequests)}.");
                    }

                    options.DefaultClientConfig.FastFailRequests = fastFailRequests;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.HttpClientCacheSize), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var httpClientCacheSize))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.HttpClientCacheSize)}.");
                    }

                    options.DefaultClientConfig.HttpClientCacheSize = httpClientCacheSize;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.IgnoreConfiguredEndpointUrls), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var ignoreConfiguredEndpointUrls))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.IgnoreConfiguredEndpointUrls)}.");
                    }

                    options.DefaultClientConfig.IgnoreConfiguredEndpointUrls = ignoreConfiguredEndpointUrls;
                }

                else if (string.Equals(element.Key, nameof(DefaultClientConfig.LogMetrics), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var logMetrics))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.LogMetrics)}.");
                    }

                    options.DefaultClientConfig.LogMetrics = logMetrics;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.LogResponse), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var logResponse))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.LogResponse)}.");
                    }

                    options.DefaultClientConfig.LogResponse = logResponse;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.MaxErrorRetry), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var maxErrorRetry))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.MaxErrorRetry)}.");
                    }

                    options.DefaultClientConfig.MaxErrorRetry = maxErrorRetry;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ProgressUpdateInterval), StringComparison.OrdinalIgnoreCase))
                {
                    if (!long.TryParse(element.Value, out var progressUpdateInterval))
                    {
                        throw new ArgumentException($"Invalid long value for {nameof(DefaultClientConfig.ProgressUpdateInterval)}.");
                    }

                    options.DefaultClientConfig.ProgressUpdateInterval = progressUpdateInterval;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.RequestMinCompressionSizeBytes), StringComparison.OrdinalIgnoreCase))
                {
                    if (!long.TryParse(element.Value, out var requestMinCompressionSizeBytes))
                    {
                        throw new ArgumentException($"Invalid long value for {nameof(DefaultClientConfig.RequestMinCompressionSizeBytes)}.");
                    }

                    options.DefaultClientConfig.RequestMinCompressionSizeBytes = requestMinCompressionSizeBytes;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ResignRetries), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var resignRetries))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.ResignRetries)}.");
                    }

                    options.DefaultClientConfig.ResignRetries = resignRetries;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.RetryMode), StringComparison.OrdinalIgnoreCase))
                {
                    if (!Enum.TryParse<RequestRetryMode>(element.Value, out var mode))
                    {
                        throw new ArgumentException($"Invalid value for RetryMode. Valid values are: {string.Join(", ", Enum.GetNames(typeof(RequestRetryMode)))} ");
                    }
                    options.DefaultClientConfig.RetryMode = mode;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ServiceURL), StringComparison.OrdinalIgnoreCase))
                {
                    if (!Uri.TryCreate(element.Value, UriKind.Absolute, out var serviceUri))
                    {
                        throw new ArgumentException($"Invalid uri value for {nameof(DefaultClientConfig.ServiceURL)}.");
                    }
                    options.DefaultClientConfig.ServiceURL = serviceUri.ToString();
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ThrottleRetries), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var throttleRetries))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.ThrottleRetries)}.");
                    }

                    options.DefaultClientConfig.ThrottleRetries = throttleRetries;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.Timeout), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var timeout))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.Timeout)}.");
                    }

                    options.DefaultClientConfig.Timeout = TimeSpan.FromMilliseconds(timeout);
                }
#if NET8_0_OR_GREATER
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.ConnectTimeout), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var connectTimeout))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.ConnectTimeout)}.");
                    }

                    options.DefaultClientConfig.ConnectTimeout = TimeSpan.FromMilliseconds(connectTimeout);
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.MaxConnectionsPerServer), StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(element.Value, out var maxConnectionsPerServer))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(DefaultClientConfig.MaxConnectionsPerServer)}.");
                    }

                    options.DefaultClientConfig.MaxConnectionsPerServer = maxConnectionsPerServer;
                }
#endif
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.UseAlternateUserAgentHeader), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var useAlternateUserAgentHeader))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.UseAlternateUserAgentHeader)}.");
                    }

                    options.DefaultClientConfig.UseAlternateUserAgentHeader = useAlternateUserAgentHeader;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.UseDualstackEndpoint), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var useDualstackEndpoint))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.UseDualstackEndpoint)}.");
                    }

                    options.DefaultClientConfig.UseDualstackEndpoint = useDualstackEndpoint;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.UseFIPSEndpoint), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var useFIPSEndpoint))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.UseFIPSEndpoint)}.");
                    }

                    options.DefaultClientConfig.UseFIPSEndpoint = useFIPSEndpoint;
                }
                else if (string.Equals(element.Key, nameof(DefaultClientConfig.UseHttp), StringComparison.OrdinalIgnoreCase))
                {
                    if (!bool.TryParse(element.Value, out var useHttp))
                    {
                        throw new ArgumentException($"Invalid bool value for {nameof(DefaultClientConfig.UseHttp)}.");
                    }

                    options.DefaultClientConfig.UseHttp = useHttp;
                }
                else
                {
                    options.DefaultClientConfig.ServiceSpecificSettings[element.Key] = element.Value;
                }
            }

            if (!string.IsNullOrEmpty(section["ExternalId"]))
            {
                options.ExternalId = section["ExternalId"];
            }

            var loggingSection = section.GetSection(LoggingKey);
            if(loggingSection != null)
            {
                options.Logging = new AWSOptions.LoggingSetting();

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogTo)]))
                {
                    if (!Enum.TryParse<LoggingOptions>(loggingSection[nameof(AWSOptions.LoggingSetting.LogTo)], out var logTo))
                    {
                        throw new ArgumentException($"Invalid value for {nameof(AWSOptions.LoggingSetting.LogTo)}. Valid values are: {string.Join(", ", Enum.GetNames(typeof(LoggingOptions)))} ");
                    }
                    options.Logging.LogTo = logTo;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponses)]))
                {
                    if (!Enum.TryParse<ResponseLoggingOption>(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponses)], out var logResponses))
                    {
                        throw new ArgumentException($"Invalid value for {nameof(AWSOptions.LoggingSetting.LogResponses)}. Valid values are: {string.Join(", ", Enum.GetNames(typeof(ResponseLoggingOption)))} ");
                    }
                    options.Logging.LogResponses = logResponses;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)]))
                {
                    if (!int.TryParse(loggingSection[nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)], out var logResponsesSizeLimit))
                    {
                        throw new ArgumentException($"Invalid integer value for {nameof(AWSOptions.LoggingSetting.LogResponsesSizeLimit)}.");
                    }
                    options.Logging.LogResponsesSizeLimit = logResponsesSizeLimit;
                }

                if (!string.IsNullOrEmpty(loggingSection[nameof(AWSOptions.LoggingSetting.LogMetrics)]))
                {
                    if (!bool.TryParse(loggingSection[nameof(AWSOptions.LoggingSetting.LogMetrics)], out var logMetrics))
                    {
                        throw new ArgumentException($"Invalid boolean value for {nameof(AWSOptions.LoggingSetting.LogMetrics)}.");
                    }
                    options.Logging.LogMetrics = logMetrics;
                }
            }

            return options;
        }
    }
}
