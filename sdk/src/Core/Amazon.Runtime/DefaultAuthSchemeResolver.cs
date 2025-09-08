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
using System.Linq;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
    /// <summary>
    /// Default implementation of IAuthSchemeResolver that reprioritizes authentication schemes
    /// based on client configuration preferences.
    /// </summary>
    public class DefaultAuthSchemeResolver : IAuthSchemeResolver
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(DefaultAuthSchemeResolver));

        /// <summary>
        /// Resolves and reprioritizes authentication schemes based on the client configuration preferences.
        /// </summary>
        /// <param name="clientConfig">The client configuration containing authentication scheme preferences.</param>
        /// <param name="supportedSchemes">The list of authentication schemes supported by the service operation.</param>
        /// <returns>
        /// An ordered list of authentication schemes with preferred schemes prioritized first,
        /// followed by any remaining supported schemes. Unsupported schemes in the preference list are ignored.
        /// </returns>
        public IReadOnlyList<IAuthSchemeOption> ResolveAuthSchemes(
            IClientConfig clientConfig, 
            IReadOnlyList<IAuthSchemeOption> supportedSchemes)
        {
            if (supportedSchemes == null || supportedSchemes.Count == 0)
            {
                _logger.DebugFormat("No supported schemes provided, returning empty list");
                return new List<IAuthSchemeOption>().AsReadOnly();
            }

            try
            {
                // Get the effective authentication scheme preference
                var authSchemePreference = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(clientConfig);

                // If no preference is configured, return the original supported schemes
                if (authSchemePreference == null || authSchemePreference.IsEmpty)
                {
                    _logger.DebugFormat("No auth scheme preference configured, using default order: {0}", 
                        string.Join(", ", supportedSchemes.Select(s => s.SchemeId)));
                    return supportedSchemes;
                }

                _logger.DebugFormat("Applying auth scheme preference: {0}", authSchemePreference);
                _logger.DebugFormat("Supported schemes: {0}", string.Join(", ", supportedSchemes.Select(s => s.SchemeId)));

                var result = ReprioritizeSchemes(authSchemePreference, supportedSchemes);

                _logger.InfoFormat("Resolved auth scheme order: {0}", string.Join(", ", result.Select(s => s.SchemeId)));
                return result;
            }
            catch (ArgumentException ex)
            {
                _logger.Error(ex, "Failed to resolve auth schemes due to invalid argument, falling back to default order");
                return supportedSchemes;
            }
            catch (InvalidOperationException ex)
            {
                _logger.Error(ex, "Failed to resolve auth schemes due to invalid operation, falling back to default order");
                return supportedSchemes;
            }
        }

        /// <summary>
        /// Reprioritizes the supported schemes based on the preference list.
        /// </summary>
        /// <param name="preference">The authentication scheme preference.</param>
        /// <param name="supportedSchemes">The list of supported authentication schemes.</param>
        /// <returns>A reprioritized list of authentication schemes.</returns>
        private IReadOnlyList<IAuthSchemeOption> ReprioritizeSchemes(
            AuthSchemePreference preference, 
            IReadOnlyList<IAuthSchemeOption> supportedSchemes)
        {
            var result = new List<IAuthSchemeOption>();
            var remainingSchemes = new List<IAuthSchemeOption>(supportedSchemes);

            foreach (var preferredSchemeName in preference.PreferenceList)
            {
                var matchingScheme = FindMatchingScheme(preferredSchemeName, remainingSchemes);
                if (matchingScheme != null)
                {
                    result.Add(matchingScheme);
                    remainingSchemes.Remove(matchingScheme);
                    _logger.DebugFormat("Added preferred scheme: {0}", matchingScheme.SchemeId);
                }
                else
                {
                    _logger.DebugFormat("Preferred scheme '{0}' is not supported by this operation, ignoring", preferredSchemeName);
                }
            }

            foreach (var remainingScheme in remainingSchemes)
            {
                result.Add(remainingScheme);
                _logger.DebugFormat("Added remaining supported scheme: {0}", remainingScheme.SchemeId);
            }

            return result.AsReadOnly();
        }

        /// <summary>
        /// Finds a matching authentication scheme by name from the list of supported schemes.
        /// </summary>
        /// <param name="schemeName">The name of the authentication scheme to find.</param>
        /// <param name="supportedSchemes">The list of supported authentication schemes.</param>
        /// <returns>The matching IAuthSchemeOption if found; otherwise, null.</returns>
        private static IAuthSchemeOption FindMatchingScheme(string schemeName, IList<IAuthSchemeOption> supportedSchemes)
        {
            if (string.IsNullOrWhiteSpace(schemeName))
                return null;

            var trimmedSchemeName = schemeName.Trim();
            
            // First try to match by short name (e.g., "sigv4")
            var matchingScheme = supportedSchemes.FirstOrDefault(scheme => 
            {
                var shortName = AuthSchemeOption.GetNameFromSchemeId(scheme.SchemeId);
                return string.Equals(shortName, trimmedSchemeName, StringComparison.Ordinal);
            });

            if (matchingScheme != null)
                return matchingScheme;

            // If no match by short name, try matching by full scheme ID
            // This supports specifying full IDs like "aws.auth#sigv4" in preferences
            return supportedSchemes.FirstOrDefault(scheme => 
                string.Equals(scheme.SchemeId, trimmedSchemeName, StringComparison.Ordinal));
        }
    }
}