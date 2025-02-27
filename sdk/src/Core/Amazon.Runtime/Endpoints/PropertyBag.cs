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
using System.Text.Json;
using System.Xml.Linq;

namespace Amazon.Runtime.Endpoints
{
    /// <summary>
    /// 
    /// Property bag implementation.
    /// 
    /// Can store arbitrary data accessed by parameter/property name.
    /// Use [] indexer to store/retrieve data.
    /// e.g. bag["parameter"] = value;
    /// If property is not defined returns null.
    /// </summary>
    public class PropertyBag : IPropertyBag
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>(); 
        public object this[string propertyName]
        {
            get 
            {
                object result;
                if (properties.TryGetValue(propertyName, out result))
                {
                    return result;
                }
                return null;
            }
            set 
            { 
                properties[propertyName] = value; 
            }
        }

        /// <summary>
        /// Creates PropertyBag based object tree from JsonElement.
        /// </summary>
        internal static PropertyBag FromJsonElement(JsonElement jsonData)
        {
            var result = new PropertyBag();
            foreach (JsonProperty property in jsonData.EnumerateObject())
            {
                result[property.Name] = ElementToValue(property.Value);
            }

            return result;
        }

        /// <summary>
        /// Return a value from a JsonElement node.
        /// Node value can be simple/final i.e. String, Int etc.
        /// or it can be complex i.e. Object, Array
        /// Translates Object json element to PropertyBag.
        /// Translates Array json element to List.
        /// </summary>
        private static object ElementToValue(JsonElement element)
        {
            return element.ValueKind switch
            {
                JsonValueKind.String => element.GetString(),
                JsonValueKind.Number => element.TryGetInt32(out var intValue) ? intValue :
                                        element.TryGetInt64(out var longValue) ? longValue :
                                        element.TryGetUInt32(out var uintValue) ? uintValue :
                                        element.TryGetUInt64(out var ulongValue) ? ulongValue :
                                        element.GetDouble(),
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                JsonValueKind.Object => FromJsonElement(element),
                JsonValueKind.Array => ParseJsonArray(element),
                _ => throw new ArgumentException("Unsupported JSON value type."),
            };
        }
        /// <summary>
        /// Converts a JsonElement array into a list of objects.
        /// </summary>
        private static List<object> ParseJsonArray(JsonElement element)
        {
            var list = new List<object>();
            foreach (var item in element.EnumerateArray())
            {
                list.Add(ElementToValue(item));
            }
            return list;
        }
    }
}
