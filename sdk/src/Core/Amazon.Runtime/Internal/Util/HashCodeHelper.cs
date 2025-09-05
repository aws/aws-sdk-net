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

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// Utility class for generating hash codes consistently across SDK types.
    /// </summary>
    internal static class HashCodeHelper
    {
        /// <summary>
        /// Combines hash codes for multiple values using a consistent algorithm.
        /// </summary>
        /// <param name="values">The values to combine hash codes for.</param>
        /// <returns>A combined hash code.</returns>
        public static int CombineHashCodes(params object[] values)
        {
            unchecked
            {
                var hash = 17;
                foreach (var value in values)
                    hash = hash * 31 + (value?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}