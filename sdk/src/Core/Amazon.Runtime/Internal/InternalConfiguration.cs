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

using Amazon.Runtime.Internal.Util;
using System.Collections.Generic;
using System.Linq;
using Amazon.Runtime.Credentials;

#if BCL || NETSTANDARD
using Amazon.Runtime.CredentialManagement;
#endif

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// InternalConfiguration holds the cached SDK configuration values
    /// obtained from the environment and profile configuration
    /// factories. These configuration values are loaded internally and
    /// are not the same as user exposed AWSConfigs.
    /// </summary>
    public class InternalConfiguration
    {
        /// <summary>
        /// Flag indicating if Endpoint Discovery is enabled.
        /// </summary>
        public bool? EndpointDiscoveryEnabled { get; set; }
        
        /// <summary>
        /// The retry mode to use: Standard or Adaptive.
        /// </summary>
        public RequestRetryMode? RetryMode { get; set; }
        
        /// <summary>
        /// The max number of request attempts.
        /// </summary>
        public int? MaxAttempts { get; set; }

        /// <summary>
        /// Endpoint of the EC2 Instance Metadata Service
        /// </summary>
        public string EC2MetadataServiceEndpoint { get; set; }

        /// <summary>
        /// Internet protocol version to be used for communicating with the EC2 Instance Metadata Service
        /// </summary>
        public EC2MetadataServiceEndpointMode? EC2MetadataServiceEndpointMode { get; set; }

        /// <inheritdoc cref="CredentialProfile.DefaultConfigurationModeName"/>
        public string DefaultConfigurationModeName { get; set; }

        /// <summary>
        /// Configures the endpoint calculation for a service to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseDualstackEndpoint { get; set; }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        public bool? UseFIPSEndpoint { get; set; }
    
        /// <summary>
        /// Configures the SDK To ignore configured endpoint URLs in the configuration files or environment variables.
        /// The environment variable overrides the value set in the configuration file.
        /// </summary>
        public bool? IgnoreConfiguredEndpointUrls { get; set; }


        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        public bool? DisableRequestCompression { get; set; }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        public long? RequestMinCompressionSizeBytes { get; set; }

        /// <summary>
        /// Customers can opt-in to provide an app id that is intended to identify their applications
        /// in the user agent header string. The value should have a maximum length of 50.
        /// </summary>
        public string ClientAppId { get; set; }

        /// <summary>
        /// Controls whether the resolved endpoint will include the account id. This allows for direct routing of traffic
        /// to the cell responsible for a given account, which avoids the additional latency of extra backend hops and reduces
        /// complexity in the routing layer.
        /// </summary>
        public AccountIdEndpointMode? AccountIdEndpointMode { get; set; }

        /// <summary>
        /// Determines the behavior for calculating checksums for request payloads.
        /// </summary>
        public RequestChecksumCalculation? RequestChecksumCalculation { get; set; }
        
        /// <summary>
        /// Determines the behavior for validating checksums on response payloads.
        /// </summary>
        public ResponseChecksumValidation? ResponseChecksumValidation { get; set; }
    }

#if BCL || NETSTANDARD

    /// <summary>
    /// Determines the configuration values based on environment variables. If 
    /// no values is found for a configuration the value will be set to null.
    /// </summary>
    public class EnvironmentVariableInternalConfiguration : InternalConfiguration
    {
        private Logger _logger = Logger.GetLogger(typeof(EnvironmentVariableInternalConfiguration));

        public const string ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY = "AWS_ENABLE_ENDPOINT_DISCOVERY";
        public const string ENVIRONMENT_VARIABLE_AWS_MAX_ATTEMPTS = "AWS_MAX_ATTEMPTS";
        public const string ENVIRONMENT_VARIABLE_AWS_RETRY_MODE = "AWS_RETRY_MODE";
        public const string ENVIRONMENT_VARIABLE_AWS_EC2_METADATA_SERVICE_ENDPOINT = "AWS_EC2_METADATA_SERVICE_ENDPOINT";
        public const string ENVIRONMENT_VARIABLE_AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE = "AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE";
        public const string ENVIRONMENT_VARIABLE_AWS_USE_DUALSTACK_ENDPOINT = "AWS_USE_DUALSTACK_ENDPOINT";
        public const string ENVIRONMENT_VARIABLE_AWS_USE_FIPS_ENDPOINT = "AWS_USE_FIPS_ENDPOINT";
        public const string ENVIRONMENT_VARIABLE_AWS_IGNORE_CONFIGURED_ENDPOINT_URLS = "AWS_IGNORE_CONFIGURED_ENDPOINT_URLS";
        public const string ENVIRONMENT_VARIABLE_AWS_DISABLE_REQUEST_COMPRESSION = "AWS_DISABLE_REQUEST_COMPRESSION";
        public const string ENVIRONMENT_VARIABLE_AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES = "AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES";
        public const string ENVIRONMENT_VARIABLE_AWS_SDK_UA_APP_ID = "AWS_SDK_UA_APP_ID";
        public const string ENVIRONMENT_VARAIBLE_AWS_ACCOUNT_ID_ENDPOINT_MODE = "AWS_ACCOUNT_ID_ENDPOINT_MODE";
        public const string ENVIRONMENT_VARIABLE_AWS_REQUEST_CHECKSUM_CALCULATION = "AWS_REQUEST_CHECKSUM_CALCULATION";
        public const string ENVIRONMENT_VARIABLE_AWS_RESPONSE_CHECKSUM_VALIDATION = "AWS_RESPONSE_CHECKSUM_VALIDATION";
        public const int AWS_SDK_UA_APP_ID_MAX_LENGTH = 50;

        /// <summary>
        /// Attempts to construct a configuration instance of configuration environment 
        /// variables. If an environment variable value isn't found then the individual value 
        /// for that environment variable will be null. If unable to obtain a value converter 
        /// to convert a configuration string to the appropriate type a InvalidOperationException 
        /// is thrown.
        /// </summary>
        public EnvironmentVariableInternalConfiguration()
        {
            EndpointDiscoveryEnabled = GetEnvironmentVariable<bool>(ENVIRONMENT_VARIABLE_AWS_ENABLE_ENDPOINT_DISCOVERY);
            MaxAttempts = GetEnvironmentVariable<int>(ENVIRONMENT_VARIABLE_AWS_MAX_ATTEMPTS);
            RetryMode = GetEnvironmentVariable<RequestRetryMode>(ENVIRONMENT_VARIABLE_AWS_RETRY_MODE);
            EC2MetadataServiceEndpoint = GetEC2MetadataEndpointEnvironmentVariable();
            EC2MetadataServiceEndpointMode = GetEnvironmentVariable<EC2MetadataServiceEndpointMode>(ENVIRONMENT_VARIABLE_AWS_EC2_METADATA_SERVICE_ENDPOINT_MODE);
            UseDualstackEndpoint = GetEnvironmentVariable<bool>(ENVIRONMENT_VARIABLE_AWS_USE_DUALSTACK_ENDPOINT);
            UseFIPSEndpoint = GetEnvironmentVariable<bool>(ENVIRONMENT_VARIABLE_AWS_USE_FIPS_ENDPOINT);
            IgnoreConfiguredEndpointUrls = GetEnvironmentVariable(ENVIRONMENT_VARIABLE_AWS_IGNORE_CONFIGURED_ENDPOINT_URLS, false);
            DisableRequestCompression = GetEnvironmentVariable<bool>(ENVIRONMENT_VARIABLE_AWS_DISABLE_REQUEST_COMPRESSION);
            RequestMinCompressionSizeBytes = GetEnvironmentVariable<long>(ENVIRONMENT_VARIABLE_AWS_REQUEST_MIN_COMPRESSION_SIZE_BYTES);
            AccountIdEndpointMode = GetEnvironmentVariable<AccountIdEndpointMode>(ENVIRONMENT_VARAIBLE_AWS_ACCOUNT_ID_ENDPOINT_MODE);
            RequestChecksumCalculation = GetEnvironmentVariable<RequestChecksumCalculation>(ENVIRONMENT_VARIABLE_AWS_REQUEST_CHECKSUM_CALCULATION);
            ResponseChecksumValidation = GetEnvironmentVariable<ResponseChecksumValidation>(ENVIRONMENT_VARIABLE_AWS_RESPONSE_CHECKSUM_VALIDATION);
            ClientAppId = GetClientAppIdEnvironmentVariable();
        }

        private bool GetEnvironmentVariable(string name, bool defaultValue)
        {
            if(!TryGetEnvironmentVariable(name, out var value))
            {
                return defaultValue;
            }
            try
            {
                return bool.Parse(value);
            }
            catch (Exception e)
            {
                _logger.Error(e, e.Message);
                throw new FormatException(e.Message, e.InnerException);
                
            }
        }

        private bool TryGetEnvironmentVariable(string environmentVariableName, out string value)
        {
            value = Environment.GetEnvironmentVariable(environmentVariableName);
            if (string.IsNullOrEmpty(value))
            {
                _logger.DebugFormat($"The environment variable {environmentVariableName} was not set with a value.");
                value = null;
                return false;
            }

            return true;
        }

        private T? GetEnvironmentVariable<T>(string name) where T : struct
        {
            if (!TryGetEnvironmentVariable(name, out var value))
            {
                return null;
            }

            try
            {
                object convertedValue;
                if(typeof(T) == typeof(bool))
                {
                    convertedValue = bool.Parse(value);
                }
                else if (typeof(T) == typeof(int))
                {
                    convertedValue = int.Parse(value);
                }
                else if (typeof(T) == typeof(long))
                {
                    convertedValue = long.Parse(value);
                }
                else if (typeof(T).IsEnum)
                {
                    convertedValue = Enum.Parse(typeof(T), value, true);
                }
                else if (typeof(T) == typeof(string))
                {
                    convertedValue = value.ToString();
                }
                else
                {
                    throw new InvalidOperationException($"Unable to convert type {typeof(T?)} for environment variable {name}.");
                }

                return (T?)convertedValue;
            }
            catch(InvalidOperationException)
            {
                throw;
            }
            catch (Exception e)
            {
                _logger.Error(e, $"The environment variable {name} was set with value {value}, but it could not be parsed as a valid value.");
            }
            return null;
        }

        /// <summary>
        /// Loads the EC2 Instance Metadata endpoint from the environment variable, and validates it is a well-formed uri
        /// </summary>
        /// <returns>Override EC2 instance metadata endpoint if valid, else an empty string</returns>
        private string GetEC2MetadataEndpointEnvironmentVariable()
        {
            if (!TryGetEnvironmentVariable(ENVIRONMENT_VARIABLE_AWS_EC2_METADATA_SERVICE_ENDPOINT, out var rawValue))
            {
                return null;
            }

            if (!Uri.IsWellFormedUriString(rawValue, UriKind.Absolute))
            {
                throw new AmazonClientException($"The environment variable {ENVIRONMENT_VARIABLE_AWS_EC2_METADATA_SERVICE_ENDPOINT} was set with value " +
                    $"{rawValue}, but it could not be parsed as a well-formed Uri.");
            }

            return rawValue;
        }       

        /// <summary>
        /// Loads client app id from the environment variable.
        /// Throws an exception if the length of client app id is longer than 50.
        /// </summary>
        /// <returns>Client app id string</returns>
        private string GetClientAppIdEnvironmentVariable()
        {
            if (!TryGetEnvironmentVariable(ENVIRONMENT_VARIABLE_AWS_SDK_UA_APP_ID, out var rawValue))
            {
                return null;
            }

            if (rawValue?.Length > AWS_SDK_UA_APP_ID_MAX_LENGTH)
            {
                Logger.GetLogger(typeof(InternalConfiguration)).InfoFormat("Warning: Client app id exceeds recommended maximum length of {0} characters: \"{1}\"", AWS_SDK_UA_APP_ID_MAX_LENGTH, rawValue);
            }

            return rawValue;
        }
    }

    /// <summary>
    /// Determines configuration values based on a <see cref="CredentialProfile"/> stored in an <see cref="ICredentialProfileSource"/>.
    /// If the profile doesn't exist, the status will be logged and no value will be set in the configuration.
    /// </summary>
    public class ProfileInternalConfiguration : InternalConfiguration
    {
        private Logger _logger = Logger.GetLogger(typeof(ProfileInternalConfiguration));

        /// <summary>
        /// Attempts to construct an instance of <see cref="ProfileInternalConfiguration"/>.
        /// If the AWS_PROFILE environment variable is set the instance will be constructed using that profile,
        /// otherwise it will use the default profile.
        ///
        /// If the profile doesn't exist status will be logged and no value will be set in the configuration.
        /// </summary>
        /// <param name="source">The ICredentialProfileSource to read the profile from.</param>
        public ProfileInternalConfiguration(ICredentialProfileSource source)
        {
            var profileName = DefaultAWSCredentialsIdentityResolver.GetProfileName();
            Setup(source, profileName);
        }

        /// <summary>
        /// Attempts to construct an instance of <see cref="ProfileInternalConfiguration"/>.
        /// If the profile doesn't exist status will be logged and no value will be set in the configuration.
        /// </summary>
        /// <param name="source">The ICredentialProfileSource to read the profile from.</param>
        /// <param name="profileName">The name of the profile.</param>
        public ProfileInternalConfiguration(ICredentialProfileSource source, string profileName)
        {
            Setup(source, profileName);
        }

        private void Setup(ICredentialProfileSource source, string profileName)
        {
            CredentialProfile profile;
            if (source.TryGetProfile(profileName, out profile))
            {
                DefaultConfigurationModeName = profile.DefaultConfigurationModeName;
                EndpointDiscoveryEnabled = profile.EndpointDiscoveryEnabled;
                RetryMode = profile.RetryMode;
                MaxAttempts = profile.MaxAttempts;
                EC2MetadataServiceEndpoint = profile.EC2MetadataServiceEndpoint;
                EC2MetadataServiceEndpointMode = profile.EC2MetadataServiceEndpointMode;
                UseDualstackEndpoint = profile.UseDualstackEndpoint;
                UseFIPSEndpoint = profile.UseFIPSEndpoint;
                IgnoreConfiguredEndpointUrls = profile.IgnoreConfiguredEndpointUrls;
                DisableRequestCompression = profile.DisableRequestCompression;
                RequestMinCompressionSizeBytes = profile.RequestMinCompressionSizeBytes;
                ClientAppId = profile.ClientAppId;
                AccountIdEndpointMode = profile.AccountIdEndpointMode;
                RequestChecksumCalculation = profile.RequestChecksumCalculation;
                ResponseChecksumValidation = profile.ResponseChecksumValidation;
            }
            else
            {
                _logger.InfoFormat("Unable to find a profile named '" + profileName + "' in store " + source.GetType());
                return;
            }

            var items = new KeyValuePair<string, object>[]
            {
                new KeyValuePair<string, object>("defaults_mode", profile.DefaultConfigurationModeName),
                new KeyValuePair<string, object>("endpoint_discovery_enabled", profile.EndpointDiscoveryEnabled),
                new KeyValuePair<string, object>("retry_mode", profile.RetryMode),
                new KeyValuePair<string, object>("max_attempts", profile.MaxAttempts),
                new KeyValuePair<string, object>("ec2_metadata_service_endpoint", profile.EC2MetadataServiceEndpoint),
                new KeyValuePair<string, object>("ec2_metadata_service_endpoint_mode", profile.EC2MetadataServiceEndpointMode),
                new KeyValuePair<string, object>("use_dualstack_endpoint", profile.UseDualstackEndpoint),
                new KeyValuePair<string, object>("use_fips_endpoint", profile.UseFIPSEndpoint),
                new KeyValuePair<string,object>( "ignore_configured_endpoint_urls", profile.IgnoreConfiguredEndpointUrls),
                new KeyValuePair<string, object>("endpoint_url", profile.EndpointUrl),
                new KeyValuePair<string, object>("disable_request_compression", profile.DisableRequestCompression),
                new KeyValuePair<string, object>("request_min_compression_size_bytes", profile.RequestMinCompressionSizeBytes),
                new KeyValuePair<string, object>("sdk_ua_app_id", profile.ClientAppId),
                new KeyValuePair<string, object>("account_id_endpoint_mode", profile.AccountIdEndpointMode),
                new KeyValuePair<string, object>("request_checksum_calculation", profile.RequestChecksumCalculation),
                new KeyValuePair<string, object>("response_checksum_validation", profile.ResponseChecksumValidation),
            };

            foreach(var item in items)
            {
                _logger.DebugFormat(item.Value == null
                ? $"There is no {item.Key} set in the profile named '{profileName}' in store {source.GetType()}"
                : $"{item.Key} found in profile '{profileName}' in store {source.GetType()}"
                );
            }
        }
    }

#endif

    /// <summary>
    /// Probing mechanism to determine the configuration values from various sources.
    /// </summary>
    public static class FallbackInternalConfigurationFactory
    {
#if BCL || NETSTANDARD
        private static CredentialProfileStoreChain _credentialProfileChain = new CredentialProfileStoreChain();
#endif
        private static InternalConfiguration _cachedConfiguration;

        static FallbackInternalConfigurationFactory()
        {
            Reset();
        }

        private delegate InternalConfiguration ConfigGenerator();

        /// <summary>
        /// Resets all the configuration values reloading as needed. This method will use
        /// the AWS_PROFILE environment variable if set to construct the instance. Otherwise 
        /// the default profile will be used.
        /// </summary>
        public static void Reset()
        {
#if BCL || NETSTANDARD
            //Preload configurations that are fast or pull all the values at the same time. Slower configurations
            //should be called for specific values dynamically.
            InternalConfiguration environmentVariablesConfiguration =  new EnvironmentVariableInternalConfiguration();
            InternalConfiguration profileConfiguration = new ProfileInternalConfiguration(_credentialProfileChain);
#endif

            _cachedConfiguration = new InternalConfiguration();
            var standardGenerators = new List<ConfigGenerator>
            {
#if BCL || NETSTANDARD
                () => environmentVariablesConfiguration,
                () => profileConfiguration,
#endif
            };

            //Find the priority first ordered config value for each property
            _cachedConfiguration.DefaultConfigurationModeName = SeekString(standardGenerators, c => c.DefaultConfigurationModeName, defaultValue: null);
            _cachedConfiguration.EndpointDiscoveryEnabled = SeekValue(standardGenerators, (c) => c.EndpointDiscoveryEnabled);
            _cachedConfiguration.RetryMode = SeekValue(standardGenerators, (c) => c.RetryMode);
            _cachedConfiguration.MaxAttempts = SeekValue(standardGenerators, (c) => c.MaxAttempts);
            _cachedConfiguration.EC2MetadataServiceEndpoint = SeekString(standardGenerators, (c) => c.EC2MetadataServiceEndpoint);
            _cachedConfiguration.EC2MetadataServiceEndpointMode = SeekValue(standardGenerators, (c) => c.EC2MetadataServiceEndpointMode);
            _cachedConfiguration.UseDualstackEndpoint = SeekValue(standardGenerators, (c) => c.UseDualstackEndpoint);
            _cachedConfiguration.UseFIPSEndpoint = SeekValue(standardGenerators, (c) => c.UseFIPSEndpoint);
            _cachedConfiguration.IgnoreConfiguredEndpointUrls = SeekValue(standardGenerators, (c) => c.IgnoreConfiguredEndpointUrls);

            _cachedConfiguration.DisableRequestCompression = SeekValue(standardGenerators, (c) => c.DisableRequestCompression);
            _cachedConfiguration.RequestMinCompressionSizeBytes = SeekValue(standardGenerators, (c) => c.RequestMinCompressionSizeBytes);
            _cachedConfiguration.ClientAppId = SeekString(standardGenerators, (c) => c.ClientAppId, defaultValue: null);
            _cachedConfiguration.AccountIdEndpointMode = SeekValue(standardGenerators,(c) => c.AccountIdEndpointMode);
            _cachedConfiguration.RequestChecksumCalculation = SeekValue(standardGenerators, (c) => c.RequestChecksumCalculation);
            _cachedConfiguration.ResponseChecksumValidation = SeekValue(standardGenerators, (c) => c.ResponseChecksumValidation);
        }        
                
        private static T? SeekValue<T>(List<ConfigGenerator> generators, Func<InternalConfiguration, T?> getValue) where T : struct
        {
            //Look for the configuration value stopping at the first generator that returns the expected value.
            foreach (var generator in generators)
            {
                var configuration = generator();
                T? value = getValue(configuration);
                if (value.HasValue)
                {
                    return value;
                }
            }

            return null;
        }

        private static string SeekString(List<ConfigGenerator> generators, Func<InternalConfiguration, string> getValue, string defaultValue = "")
        {
            //Look for the configuration value stopping at the first generator that returns the expected value.
            foreach (var generator in generators)
            {
                var configuration = generator();
                string value = getValue(configuration);
                if (!string.IsNullOrEmpty(value))
                {
                    return value;
                }
            }

            return defaultValue;
        }

        /// <summary>
        /// Flag that specifies if endpoint discovery is enabled, disabled, 
        /// or not set.
        /// </summary>
        public static bool? EndpointDiscoveryEnabled
        {
            get
            {
                return _cachedConfiguration.EndpointDiscoveryEnabled;
            }
        }

        /// <summary>
        /// Flag that specifies which retry mode to use or if retry mode has 
        /// not been set.
        /// </summary>
        public static RequestRetryMode? RetryMode
        {
            get
            {
                return _cachedConfiguration.RetryMode;
            }
        }

        /// <summary>
        /// Flag that specifies the max number of request attempts or if max 
        /// attempts has not been set.
        /// </summary>
        public static int? MaxAttempts
        {
            get
            {
                return _cachedConfiguration.MaxAttempts;
            }
        }

        /// <summary>
        /// Endpoint of the EC2 Instance Metadata Service
        /// </summary>
        public static string EC2MetadataServiceEndpoint
        {
            get
            {
                return _cachedConfiguration.EC2MetadataServiceEndpoint;
            }
        }

        /// <summary>
        /// Internet protocol version to be used for communicating with the EC2 Instance Metadata Service
        /// </summary>
        public static EC2MetadataServiceEndpointMode? EC2MetadataServiceEndpointMode
        { 
            get
            {
                return _cachedConfiguration.EC2MetadataServiceEndpointMode;
            }
        }

        /// <inheritdoc cref="InternalConfiguration.DefaultConfigurationModeName"/>
        public static string DefaultConfigurationModeName
        {
            get
            {
                return _cachedConfiguration.DefaultConfigurationModeName;
            }
        }

        /// <summary>
        /// Configures the endpoint calculation to go to a dual stack (ipv6 enabled) endpoint
        /// for the configured region.
        /// </summary>
        public static bool? UseDualStackEndpoint
        {
            get
            {
                return _cachedConfiguration.UseDualstackEndpoint;
            }
        }

        /// <summary>
        /// Configures the endpoint calculation to go to a FIPS (https://aws.amazon.com/compliance/fips/) endpoint
        /// for the configured region.
        /// </summary>
        public static bool? UseFIPSEndpoint
        {
            get
            {
                return _cachedConfiguration.UseFIPSEndpoint;
            }
        }
        /// <summary>
        /// Configures the SDK To ignore configured endpoint URLs in the configuration files or environment variables.
        /// The environment variable overrides the value set in the configuration file.
        /// </summary>
        public static bool? IgnoreConfiguredEndpointUrls
        {
            get
            {
                return _cachedConfiguration.IgnoreConfiguredEndpointUrls;
            }
        }

        /// <summary>
        /// Controls whether request payloads are automatically compressed for supported operations.
        /// This setting only applies to operations that support compression.
        /// The default value is "false". Set to "true" to disable compression.
        /// </summary>
        public static bool? DisableRequestCompression {
            get
            {
                return _cachedConfiguration.DisableRequestCompression;
            }
        }

        /// <summary>
        /// Minimum size in bytes that a request body should be to trigger compression.
        /// </summary>
        public static long? RequestMinCompressionSizeBytes {
            get
            {
                return _cachedConfiguration.RequestMinCompressionSizeBytes;
            }
        }

        /// <summary>
        /// Customers can opt-in to provide an app id that is intended to identify their applications
        /// in the user agent header string. The value should have a maximum length of 50.
        /// </summary>
        public static string ClientAppId
        {
            get
            {
                return _cachedConfiguration.ClientAppId;
            }
        }

        /// <summary>
        /// Controls whether the resolved endpoint will include the account id. This allows for direct routing of traffic
        /// to the cell responsible for a given account, which avoids the additional latency of extra backend hops and reduces
        /// complexity in the routing layer.
        /// </summary>
        public static AccountIdEndpointMode? AccountIdEndpointMode
        {
            get
            {
                return _cachedConfiguration.AccountIdEndpointMode;
            }
        }

        public static RequestChecksumCalculation? RequestChecksumCalculation
        {
            get
            {
                return _cachedConfiguration.RequestChecksumCalculation;
            }
        }

        public static ResponseChecksumValidation? ResponseChecksumValidation
        {
            get
            {
                return _cachedConfiguration.ResponseChecksumValidation;
            }
        }
    }
}
