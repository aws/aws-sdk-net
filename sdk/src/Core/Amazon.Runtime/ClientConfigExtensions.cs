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

namespace Amazon.Runtime
{
    /// <summary>
    /// Extension methods for IClientConfig to provide backwards-compatible access to new authentication scheme properties.
    /// </summary>
    public static class ClientConfigExtensions
    {
        /// <summary>
        /// Gets a value indicating whether the SignatureMethod property was explicitly set by the user.
        /// This is used for backwards compatibility to determine when legacy SignatureMethod configuration
        /// should take precedence over auth scheme preferences.
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>True if SignatureMethod was explicitly set; otherwise, false.</returns>
        public static bool GetIsSignatureMethodExplicitlySet(this IClientConfig clientConfig)
        {
            if (clientConfig is ClientConfig concreteConfig)
            {
                return concreteConfig.IsSignatureMethodExplicitlySet;
            }
            
            // Use reflection for test mock classes or other implementations that have this property
            var isSignatureMethodProperty = clientConfig.GetType().GetProperty("IsSignatureMethodExplicitlySet");
            if (isSignatureMethodProperty != null)
            {
                return (bool)isSignatureMethodProperty.GetValue(clientConfig);
            }
            
            return false;
        }

        /// <summary>
        /// Gets the authentication scheme preference for this client configuration.
        /// <para>
        /// This property allows you to specify a preference list of authentication schemes
        /// that will be used to reprioritize the supported authentication schemes for this client.
        /// If not set, the client will use the global <see cref="AWSConfigs.AuthSchemePreference"/>
        /// or fall back to the default model-based authentication scheme resolution.
        /// </para>
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>The authentication scheme preference, or null if not configured.</returns>
        public static AuthSchemePreference GetAuthSchemePreference(this IClientConfig clientConfig)
        {
            if (clientConfig is ClientConfig concreteConfig)
            {
                return concreteConfig.AuthSchemePreference;
            }
            
            // Use reflection for test mock classes or other implementations that have this property
            var authSchemePreferenceProperty = clientConfig.GetType().GetProperty("AuthSchemePreference");
            if (authSchemePreferenceProperty != null)
            {
                return (AuthSchemePreference)authSchemePreferenceProperty.GetValue(clientConfig);
            }
            
            return null;
        }

        /// <summary>
        /// Gets the SigV4a signing region set configuration for this client.
        /// <para>
        /// This property allows you to specify the region set that will be used for SigV4a signing.
        /// The region set determines which regions the signed request is valid for.
        /// If not set, the client will use environment variables, configuration files,
        /// endpoints metadata, or fall back to the client's configured region.
        /// </para>
        /// </summary>
        /// <param name="clientConfig">The client configuration.</param>
        /// <returns>The SigV4a region set configuration, or null if not configured.</returns>
        public static SigV4aRegionSetConfiguration GetSigV4aRegionSetConfiguration(this IClientConfig clientConfig)
        {
            if (clientConfig is ClientConfig concreteConfig)
            {
                return concreteConfig.SigV4aRegionSetConfiguration;
            }
            
            // Use reflection for test mock classes or other implementations that have this property
            var sigV4aProperty = clientConfig.GetType().GetProperty("SigV4aRegionSetConfiguration");
            if (sigV4aProperty != null)
            {
                return (SigV4aRegionSetConfiguration)sigV4aProperty.GetValue(clientConfig);
            }
            
            return null;
        }
    }
}