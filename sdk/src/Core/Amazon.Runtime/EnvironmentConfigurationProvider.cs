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

namespace Amazon.Runtime
{
    /// <summary>
    /// Provides configuration values from environment variables for authentication schemes.
    /// </summary>
    internal static class EnvironmentConfigurationProvider
    {
        /// <summary>
        /// Environment variable name for authentication scheme preference.
        /// </summary>
        public const string AuthSchemePreferenceEnvVar = "AWS_AUTH_SCHEME_PREFERENCE";

        /// <summary>
        /// Environment variable name for SigV4a signing region set.
        /// </summary>
        public const string SigV4aRegionSetEnvVar = "AWS_SIGV4A_SIGNING_REGION_SET";

        private static Logger Logger => Logger.GetLogger(typeof(EnvironmentConfigurationProvider));

        /// <summary>
        /// Gets the authentication scheme preference from environment variables.
        /// </summary>
        /// <returns>An AuthSchemePreference instance if the environment variable is set and valid; otherwise, null.</returns>
        public static AuthSchemePreference GetAuthSchemePreference()
        {
            try
            {
                var envValue = Environment.GetEnvironmentVariable(AuthSchemePreferenceEnvVar);
                if (string.IsNullOrWhiteSpace(envValue))
                    return null;

                Logger.InfoFormat("Found {0} environment variable: {1}", AuthSchemePreferenceEnvVar, envValue);
                return AuthSchemePreference.Parse(envValue);
            }
            catch (ArgumentException ex)
            {
                Logger.Error(ex, "Failed to parse {0} environment variable due to invalid argument", AuthSchemePreferenceEnvVar);
                return null;
            }
        }

        /// <summary>
        /// Gets the SigV4a signing region set from environment variables.
        /// </summary>
        /// <returns>A comma-separated string of regions if the environment variable is set; otherwise, null.</returns>
        public static string GetSigV4aRegionSet()
        {
            try
            {
                var envValue = Environment.GetEnvironmentVariable(SigV4aRegionSetEnvVar);
                if (string.IsNullOrWhiteSpace(envValue))
                    return null;

                Logger.InfoFormat("Found {0} environment variable: {1}", SigV4aRegionSetEnvVar, envValue);
                return envValue.Trim();
            }
            catch (ArgumentException ex)
            {
                Logger.Error(ex, "Failed to get {0} environment variable due to invalid argument", SigV4aRegionSetEnvVar);
                return null;
            }
        }
    }
}