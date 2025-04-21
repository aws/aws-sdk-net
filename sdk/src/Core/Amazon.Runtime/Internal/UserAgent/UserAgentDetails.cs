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

using System.Text;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal.UserAgent
{
    /// <summary>
    /// Represents the User Agent details, including tracked features under User Agent 2.1 (UA2.1).
    /// This class ensures that feature metrics are collected efficiently and the final
    /// User-Agent string is generated only when needed.
    /// </summary>
    public class UserAgentDetails
    {
        private const int MaxSizeBytes = 1024; // 1 KB size limit
        private readonly HashSet<string> _trackedFeatureIds = new HashSet<string>();
        private readonly StringBuilder _userAgentBuilder = new StringBuilder();

        /// <summary>
        /// Gets the list of tracked feature IDs.
        /// </summary>
        public IEnumerable<string> TrackedFeatureIds => _trackedFeatureIds;

        /// <summary>
        /// Adds a component to the user-agent string. 
        /// </summary>
        /// <param name="component">The user-agent component to append.</param>
        public void AddUserAgentComponent(string component)
        {
            if (!string.IsNullOrEmpty(component))
            {
                _userAgentBuilder.Append(' ').Append(component);
            }
        }

        /// <summary>
        /// Adds a feature metric to be included in the User-Agent string.
        /// Duplicate entries are ignored.
        /// </summary>
        /// <param name="featureId">The feature metric ID to track.</param>
        public void AddFeature(UserAgentFeatureId featureId)
        {
            if (featureId == null) return;
            _trackedFeatureIds.Add(featureId.Value);
        }

        /// <summary>
        /// Returns the user agent components that were explicitly added via AddUserAgentComponent,
        /// </summary>
        public string GetCustomUserAgentComponents()
        {
            return _userAgentBuilder.ToString().Trim();
        }

        /// <summary>
        /// Appends the metrics user-agent to the existing user-agent and returns the full string.
        /// </summary>
        /// <returns>The final user-agent string including metrics data.</returns>
        public string GenerateUserAgentWithMetrics()
        {
            var metricsUserAgent = GenerateMetricsUserAgent();
            if (!string.IsNullOrEmpty(metricsUserAgent))
            {
                return $"{_userAgentBuilder.ToString().Trim()} {metricsUserAgent}";
            }
            return _userAgentBuilder.ToString().Trim();
        }

        /// <summary>
        /// Generates the User-Agent metrics string.
        /// Ensures the final string does not exceed 1024 bytes.
        /// </summary>
        /// <returns>The formatted User-Agent metrics string.</returns>
        private string GenerateMetricsUserAgent()
        {
            if (_trackedFeatureIds.Count == 0)
            {
                return string.Empty;
            }
            var metricsString = $"m/{string.Join(",", _trackedFeatureIds)}";
            metricsString = TruncateToSize(metricsString);

            return metricsString;
        }

        /// <summary>
        /// Truncates a comma-separated string to ensure it fits within a given byte limit.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <returns>A truncated version of the string within the byte limit.</returns>
        private static string TruncateToSize(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            if (bytes.Length <= MaxSizeBytes)
            {
                return input;
            }

            var cutOffIndex = MaxSizeBytes;
            while (cutOffIndex > 0 && bytes[cutOffIndex - 1] != ',')
            {
                cutOffIndex--;
            }

            return Encoding.UTF8.GetString(bytes, 0, cutOffIndex - 1); // Remove last comma
        }
    }
}
