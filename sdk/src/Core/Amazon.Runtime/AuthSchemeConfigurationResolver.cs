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
using Amazon.Runtime.CredentialManagement;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Resolves authentication scheme configuration from various sources with proper precedence.
    /// </summary>
    internal static class AuthSchemeConfigurationResolver
    {
        private static Logger Logger => Logger.GetLogger(typeof(AuthSchemeConfigurationResolver));

        /// <summary>
        /// Resolves authentication scheme preference using configuration precedence hierarchy.
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>The resolved AuthSchemePreference, or null if none is configured.</returns>
        public static AuthSchemePreference ResolveAuthSchemePreference(IClientConfig clientConfig)
        {
            return SafeConfigurationResolver.SafeResolve(() =>
            {
                var legacyPreference = GetLegacySignatureMethodPreference(clientConfig);
                if (legacyPreference != null)
                {
                    Logger.InfoFormat("Using legacy SignatureMethod configuration: {0}", legacyPreference);
                    return legacyPreference;
                }

                if (clientConfig?.AuthSchemePreference != null)
                {
                    Logger.InfoFormat("Using auth scheme preference from client configuration: {0}", 
                        clientConfig.AuthSchemePreference);
                    return clientConfig.AuthSchemePreference;
                }

                var envPreference = EnvironmentConfigurationProvider.GetAuthSchemePreference();
                if (envPreference != null)
                {
                    Logger.InfoFormat("Using auth scheme preference from environment variable: {0}", envPreference);
                    return envPreference;
                }

                var configFilePreference = GetAuthSchemePreferenceFromConfigFile(clientConfig);
                if (configFilePreference != null)
                {
                    Logger.InfoFormat("Using auth scheme preference from configuration file: {0}", configFilePreference);
                    return configFilePreference;
                }

                if (AWSConfigs.AuthSchemePreference != null)
                {
                    Logger.InfoFormat("Using auth scheme preference from global AWSConfigs: {0}", 
                        AWSConfigs.AuthSchemePreference);
                    return AWSConfigs.AuthSchemePreference;
                }

                Logger.DebugFormat("No auth scheme preference configured, using default resolution");
                return null;
            }, "resolving auth scheme preference", Logger);
        }

        /// <summary>
        /// Gets the authentication scheme preference based on legacy SignatureMethod configuration.
        /// Ensures backwards compatibility with existing SignatureMethod settings for S3 services.
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>The AuthSchemePreference based on SignatureMethod, or null if not applicable.</returns>
        private static AuthSchemePreference GetLegacySignatureMethodPreference(IClientConfig clientConfig)
        {
            return SafeConfigurationResolver.SafeResolve(() =>
            {
                if (clientConfig?.SignatureMethod == null || !clientConfig.IsSignatureMethodExplicitlySet)
                    return null;
                
                bool isS3Service = clientConfig.ServiceId?.Equals("S3", StringComparison.OrdinalIgnoreCase) == true ||
                                  clientConfig.ServiceId?.Equals("S3 Control", StringComparison.OrdinalIgnoreCase) == true;
                
                if (!isS3Service)
                    return null;

                switch (clientConfig.SignatureMethod)
                {
                    case SigningAlgorithm.HmacSHA256:
                    case SigningAlgorithm.HmacSHA1:
                        Logger.InfoFormat("Legacy SignatureMethod {0} detected, prioritizing SigV4 authentication", 
                            clientConfig.SignatureMethod);
                        return new AuthSchemePreference(new[] { "sigv4" });
                    default:
                        Logger.DebugFormat("Unknown SignatureMethod {0}, not applying legacy preference", 
                            clientConfig.SignatureMethod);
                        return null;
                }
            }, "resolving legacy SignatureMethod preference", Logger);
        }


        /// <summary>
        /// Gets the authentication scheme preference from the configuration file.
        /// </summary>
        /// <param name="clientConfig">The client configuration to determine which profile to use.</param>
        /// <returns>The AuthSchemePreference from the configuration file, or null if not found.</returns>
        private static AuthSchemePreference GetAuthSchemePreferenceFromConfigFile(IClientConfig clientConfig)
        {
            return SafeConfigurationResolver.SafeResolve(() =>
            {
                var credentialProfileStoreChain = new CredentialProfileStoreChain();
                
                string profileName = clientConfig?.Profile?.Name 
                    ?? DefaultAWSCredentialsIdentityResolver.GetProfileName();

                if (string.IsNullOrEmpty(profileName))
                {
                    Logger.DebugFormat("No profile name available for configuration file lookup");
                    return null;
                }

                if (!credentialProfileStoreChain.TryGetProfile(profileName, out CredentialProfile profile))
                {
                    Logger.DebugFormat("Profile '{0}' not found in configuration file", profileName);
                    return null;
                }

                if (profile.Properties.TryGetValue(SettingsConstants.AuthSchemePreference, out string authSchemePreferenceValue) 
                    && !string.IsNullOrWhiteSpace(authSchemePreferenceValue))
                {
                    Logger.InfoFormat("Found auth_scheme_preference in profile '{0}': {1}", 
                        profileName, authSchemePreferenceValue);
                    return AuthSchemePreference.Parse(authSchemePreferenceValue);
                }

                Logger.DebugFormat("No auth_scheme_preference found in profile '{0}'", profileName);
                return null;
            }, "getting auth scheme preference from configuration file", Logger);
        }

        /// <summary>
        /// Resolves SigV4a signing region set configuration using configuration precedence hierarchy.
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>The resolved SigV4aRegionSetConfiguration, or null if none is configured.</returns>
        public static SigV4aRegionSetConfiguration ResolveSigV4aRegionSetConfiguration(IClientConfig clientConfig)
        {
            return SafeConfigurationResolver.SafeResolve(() =>
            {
                if (clientConfig?.SigV4aRegionSetConfiguration != null)
                {
                    Logger.InfoFormat("Using SigV4a region set from client configuration: {0}", 
                        clientConfig.SigV4aRegionSetConfiguration);
                    return clientConfig.SigV4aRegionSetConfiguration;
                }

                var envRegionSetConfig = SigV4aRegionSetConfiguration.FromEnvironment();
                if (envRegionSetConfig != null)
                {
                    Logger.InfoFormat("Using SigV4a region set from environment variable: {0}", envRegionSetConfig);
                    return envRegionSetConfig;
                }

                var configFileRegionSetConfig = GetSigV4aRegionSetConfigurationFromConfigFile(clientConfig);
                if (configFileRegionSetConfig != null)
                {
                    Logger.InfoFormat("Using SigV4a region set from configuration file: {0}", configFileRegionSetConfig);
                    return configFileRegionSetConfig;
                }

                if (AWSConfigs.SigV4aRegionSetConfiguration != null)
                {
                    Logger.InfoFormat("Using SigV4a region set from global AWSConfigs: {0}", 
                        AWSConfigs.SigV4aRegionSetConfiguration);
                    return AWSConfigs.SigV4aRegionSetConfiguration;
                }

                Logger.DebugFormat("No SigV4a region set configured, will use default from endpoints metadata or client region");
                return null;
            }, "resolving SigV4a region set configuration", Logger);
        }

        /// <summary>
        /// Gets the SigV4a signing region set configuration from the configuration file.
        /// </summary>
        /// <param name="clientConfig">The client configuration to determine which profile to use.</param>
        /// <returns>The SigV4aRegionSetConfiguration from the configuration file, or null if not found.</returns>
        private static SigV4aRegionSetConfiguration GetSigV4aRegionSetConfigurationFromConfigFile(IClientConfig clientConfig)
        {
            return SafeConfigurationResolver.SafeResolve(() =>
            {
                var credentialProfileStoreChain = new CredentialProfileStoreChain();
                
                string profileName = clientConfig?.Profile?.Name 
                    ?? DefaultAWSCredentialsIdentityResolver.GetProfileName();

                if (string.IsNullOrEmpty(profileName))
                {
                    Logger.DebugFormat("No profile name available for configuration file lookup");
                    return null;
                }

                if (!credentialProfileStoreChain.TryGetProfile(profileName, out CredentialProfile profile))
                {
                    Logger.DebugFormat("Profile '{0}' not found in configuration file", profileName);
                    return null;
                }

                if (profile.Properties.TryGetValue(SettingsConstants.SigV4aSigningRegionSet, out string regionSetValue) 
                    && !string.IsNullOrWhiteSpace(regionSetValue))
                {
                    Logger.InfoFormat("Found sigv4a_signing_region_set in profile '{0}': {1}", 
                        profileName, regionSetValue);
                    return SigV4aRegionSetConfiguration.FromConfigFile(regionSetValue);
                }

                Logger.DebugFormat("No sigv4a_signing_region_set found in profile '{0}'", profileName);
                return null;
            }, "getting SigV4a region set from configuration file", Logger);
        }
    }
}