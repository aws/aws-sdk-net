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
        /// A mapping of authentication scheme names to their corresponding AuthScheme instances.
        /// Note: Authentication scheme names are case-sensitive per the Multi-auth specification.
        /// </summary>
        private static readonly Dictionary<string, AuthScheme> KnownSchemes = new Dictionary<string, AuthScheme>(StringComparer.Ordinal)
        {
            { AuthScheme.SigV4.Name, AuthScheme.SigV4 },
            { AuthScheme.SigV4a.Name, AuthScheme.SigV4a },
            { AuthScheme.HttpBearerAuth.Name, AuthScheme.HttpBearerAuth },
            { AuthScheme.NoAuth.Name, AuthScheme.NoAuth }
        };

        /// <summary>
        /// Resolves and reprioritizes authentication schemes based on the client configuration preferences.
        /// </summary>
        /// <param name="clientConfig">The client configuration containing authentication scheme preferences.</param>
        /// <param name="supportedSchemes">The list of authentication schemes supported by the service operation.</param>
        /// <returns>
        /// An ordered list of authentication schemes with preferred schemes prioritized first,
        /// followed by any remaining supported schemes. Unsupported schemes in the preference list are ignored.
        /// </returns>
        public IReadOnlyList<AuthScheme> ResolveAuthSchemes(
            IClientConfig clientConfig, 
            IReadOnlyList<AuthScheme> supportedSchemes)
        {
            if (supportedSchemes == null || supportedSchemes.Count == 0)
            {
                _logger.DebugFormat("No supported schemes provided, returning empty list");
                return new List<AuthScheme>().AsReadOnly();
            }

            try
            {
                // Get the effective authentication scheme preference
                var authSchemePreference = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(clientConfig);

                // If no preference is configured, return the original supported schemes
                if (authSchemePreference == null || authSchemePreference.IsEmpty)
                {
                    _logger.DebugFormat("No auth scheme preference configured, using default order: {0}", 
                        string.Join(", ", supportedSchemes.Select(s => s.Name)));
                    return supportedSchemes;
                }

                _logger.DebugFormat("Applying auth scheme preference: {0}", authSchemePreference);
                _logger.DebugFormat("Supported schemes: {0}", string.Join(", ", supportedSchemes.Select(s => s.Name)));

                var result = ReprioritizeSchemes(authSchemePreference, supportedSchemes);

                _logger.InfoFormat("Resolved auth scheme order: {0}", string.Join(", ", result.Select(s => s.Name)));
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
        private IReadOnlyList<AuthScheme> ReprioritizeSchemes(
            AuthSchemePreference preference, 
            IReadOnlyList<AuthScheme> supportedSchemes)
        {
            var result = new List<AuthScheme>();
            var remainingSchemes = new List<AuthScheme>(supportedSchemes);

            foreach (var preferredSchemeName in preference.PreferenceList)
            {
                var matchingScheme = FindMatchingScheme(preferredSchemeName, remainingSchemes);
                if (matchingScheme != null)
                {
                    result.Add(matchingScheme);
                    remainingSchemes.Remove(matchingScheme);
                    _logger.DebugFormat("Added preferred scheme: {0}", matchingScheme.Name);
                }
                else
                {
                    _logger.DebugFormat("Preferred scheme '{0}' is not supported by this operation, ignoring", preferredSchemeName);
                }
            }

            foreach (var remainingScheme in remainingSchemes)
            {
                result.Add(remainingScheme);
                _logger.DebugFormat("Added remaining supported scheme: {0}", remainingScheme.Name);
            }

            return result.AsReadOnly();
        }

        /// <summary>
        /// Finds a matching authentication scheme by name from the list of supported schemes.
        /// </summary>
        /// <param name="schemeName">The name of the authentication scheme to find.</param>
        /// <param name="supportedSchemes">The list of supported authentication schemes.</param>
        /// <returns>The matching AuthScheme if found; otherwise, null.</returns>
        private static AuthScheme FindMatchingScheme(string schemeName, IList<AuthScheme> supportedSchemes)
        {
            if (string.IsNullOrWhiteSpace(schemeName))
                return null;

            var trimmedSchemeName = schemeName.Trim();
            
            var matchingScheme = supportedSchemes.FirstOrDefault(scheme => 
                string.Equals(scheme.Name, trimmedSchemeName, StringComparison.Ordinal));

            if (matchingScheme != null)
                return matchingScheme;

            matchingScheme = supportedSchemes.FirstOrDefault(scheme =>
            {
                if (string.Equals(scheme.SchemeId, trimmedSchemeName, StringComparison.Ordinal))
                    return true;
                    
                var schemeIdParts = scheme.SchemeId.Split('#');
                if (schemeIdParts.Length == 2)
                {
                    var extractedName = schemeIdParts[1];
                    if (string.Equals(extractedName, trimmedSchemeName, StringComparison.Ordinal))
                        return true;
                }
                
                return false;
            });

            return matchingScheme;
        }
    }
}