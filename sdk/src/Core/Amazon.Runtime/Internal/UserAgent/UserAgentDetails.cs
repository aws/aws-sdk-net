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

        /// <summary>
        /// Gets the list of tracked feature IDs.
        /// </summary>
        public IEnumerable<string> TrackedFeatureIds => _trackedFeatureIds;

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
        /// Generates the User-Agent metrics string.
        /// Ensures the final string does not exceed 1024 bytes.
        /// </summary>
        /// <returns>The formatted User-Agent metrics string.</returns>
#pragma warning disable CA1822 // Mark members as static
        public string GenerateMetricsUserAgent()
#pragma warning restore CA1822 // Mark members as static
        {
            // TODO
            return "m/{metricsString}";
        }
    }
}
