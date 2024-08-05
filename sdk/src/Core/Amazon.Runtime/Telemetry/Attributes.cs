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

namespace Amazon.Runtime.Telemetry
{
    /// <summary>
    /// Represents a collection of attributes used for telemetry purposes.
    /// Attributes are key-value pairs where the key is a string and the value is an object.
    /// These attributes provide additional information for spans and metrics in telemetry data.
    /// </summary>
    public class Attributes
    {
        private readonly Dictionary<string, object> _attributes;

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// </summary>
        public Attributes()
        {
            _attributes = new Dictionary<string, object>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attributes"/> class.
        /// If duplicate keys are present in the provided collection, the value of the last occurrence of the key will be used.
        /// </summary>
        /// <param name="attributes">An optional initial set of attributes to populate the collection. 
        /// If duplicate keys are found, the last value will override previous ones.</param>
        public Attributes(IEnumerable<KeyValuePair<string, object>> attributes)
        {
            _attributes = new Dictionary<string, object>();

            foreach (var kvp in attributes)
            {
                _attributes[kvp.Key] = kvp.Value;
            }
        }

        /// <summary>
        /// Sets the value for the given attribute key.
        /// If the key already exists, the value is updated.
        /// </summary>
        /// <param name="key">The key of the attribute.</param>
        /// <param name="value">The value of the attribute.</param>
        public void Set(string key, object value)
        {
            _attributes[key] = value;
        }

        /// <summary>
        /// Gets the value for the given attribute key.
        /// </summary>
        /// <param name="key">The attribute key.</param>
        /// <returns>The attribute value, or null if the key does not exist.</returns>
        public object Get(string key)
        {
            _attributes.TryGetValue(key, out var value);
            return value;
        }

        /// <summary>
        /// Removes the attribute with the specified key.
        /// </summary>
        /// <param name="key">The attribute key.</param>
        /// <returns>True if the attribute was successfully removed; otherwise, false.</returns>
        public bool Remove(string key)
        {
            return _attributes.Remove(key);
        }

        /// <summary>
        /// Gets the collection of all the attributes.
        /// </summary>
        public IEnumerable<KeyValuePair<string, object>> AllAttributes
        {
            get { return _attributes; }
        }
    }
}
