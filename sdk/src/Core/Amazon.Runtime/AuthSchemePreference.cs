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
    /// Represents a preference list of authentication schemes for AWS service requests.
    /// </summary>
    public class AuthSchemePreference
    {
        /// <summary>
        /// Gets the ordered list of preferred authentication scheme names.
        /// </summary>
        public IReadOnlyList<string> PreferenceList { get; }

        /// <summary>
        /// Initializes a new instance of the AuthSchemePreference class.
        /// </summary>
        /// <param name="schemes">The ordered list of preferred authentication scheme names.</param>
        /// <exception cref="ArgumentNullException">Thrown when schemes is null.</exception>
        public AuthSchemePreference(IEnumerable<string> schemes)
        {
            if (schemes == null)
                throw new ArgumentNullException(nameof(schemes));

            // Filter out null, empty, or whitespace-only scheme names
            var validSchemes = schemes
                .Where(scheme => !string.IsNullOrWhiteSpace(scheme))
                .Select(scheme => scheme.Trim())
                .ToList();

            PreferenceList = validSchemes.AsReadOnly();
        }

        /// <summary>
        /// Parses a comma-separated string of authentication scheme names into an AuthSchemePreference.
        /// </summary>
        /// <param name="commaSeparatedSchemes">A comma-separated string of authentication scheme names.</param>
        /// <returns>An AuthSchemePreference instance containing the parsed scheme names.</returns>
        /// <exception cref="ArgumentNullException">Thrown when commaSeparatedSchemes is null.</exception>
        public static AuthSchemePreference Parse(string commaSeparatedSchemes)
        {
            if (commaSeparatedSchemes == null)
                throw new ArgumentNullException(nameof(commaSeparatedSchemes));

            if (string.IsNullOrWhiteSpace(commaSeparatedSchemes))
                return new AuthSchemePreference(new string[0]);

            var schemes = commaSeparatedSchemes
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(scheme => scheme.Trim())
                .Where(scheme => !string.IsNullOrWhiteSpace(scheme));

            return new AuthSchemePreference(schemes);
        }

        /// <summary>
        /// Gets a value indicating whether the preference list is empty.
        /// </summary>
        public bool IsEmpty => PreferenceList.Count == 0;

        /// <summary>
        /// Determines whether the preference list contains the specified authentication scheme name.
        /// </summary>
        /// <param name="schemeName">The authentication scheme name to search for.</param>
        /// <returns>true if the preference list contains the specified scheme name; otherwise, false.</returns>
        public bool Contains(string schemeName)
        {
            if (string.IsNullOrWhiteSpace(schemeName))
                return false;

            return PreferenceList.Contains(schemeName.Trim(), StringComparer.Ordinal);
        }

        /// <summary>
        /// Gets the index of the specified authentication scheme name in the preference list.
        /// </summary>
        /// <param name="schemeName">The authentication scheme name to search for.</param>
        /// <returns>The zero-based index of the scheme name if found; otherwise, -1.</returns>
        public int IndexOf(string schemeName)
        {
            if (string.IsNullOrWhiteSpace(schemeName))
                return -1;

            var trimmedSchemeName = schemeName.Trim();
            for (int i = 0; i < PreferenceList.Count; i++)
            {
                if (string.Equals(PreferenceList[i], trimmedSchemeName, StringComparison.Ordinal))
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Returns a string representation of the AuthSchemePreference.
        /// </summary>
        /// <returns>A comma-separated string of the authentication scheme names in the preference list.</returns>
        public override string ToString()
        {
            return string.Join(", ", PreferenceList);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current AuthSchemePreference.
        /// </summary>
        /// <param name="obj">The object to compare with the current AuthSchemePreference.</param>
        /// <returns>true if the specified object is equal to the current AuthSchemePreference; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj is AuthSchemePreference other)
            {
                return PreferenceList.SequenceEqual(other.PreferenceList, StringComparer.Ordinal);
            }
            return false;
        }

        /// <summary>
        /// Returns the hash code for this AuthSchemePreference.
        /// </summary>
        /// <returns>A hash code for the current AuthSchemePreference.</returns>
        public override int GetHashCode()
        {
            return HashCodeHelper.CombineHashCodes(PreferenceList.ToArray());
        }
    }
}