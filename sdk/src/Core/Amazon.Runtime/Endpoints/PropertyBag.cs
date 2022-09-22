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
using ThirdParty.Json.LitJson;

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
        /// Creates PropertyBag based object tree from JsonData
        /// </summary>
        internal static PropertyBag FromJsonData(JsonData jsonData)
        {
            var result = new PropertyBag();
            foreach (string name in jsonData.PropertyNames)
            {
                var node = jsonData[name];
                result[name] = NodeToValue(node);
            }
            return result;
        }

        /// <summary>
        /// Return a value from a JsonData node
        /// Node value can be simple/final i.e. String, Int etc.
        /// or it can be complex i.e. Object, Array
        /// Translates Object json node to PropertyBag
        /// Translates Array json node to List
        /// </summary>
        private static object NodeToValue(JsonData node)
        {
            if (node.IsString)
            {
                return (string)node;
            }
            if (node.IsBoolean)
            {
                return (bool)node;
            }
            if (node.IsInt)
            {
                return (int)node;
            }
            if (node.IsLong)
            {
                return (long)node;
            }
            if (node.IsDouble)
            {
                return (double)node;
            }
            if (node.IsUInt)
            {
                return (uint)node;
            }
            if (node.IsULong)
            {
                return (ulong)node;
            }
            if (node.IsObject)
            {
                return FromJsonData(node);
            }
            if (node.IsArray)
            {
                var list = new List<object>();
                foreach (JsonData item in node)
                {
                    list.Add(NodeToValue(item));
                }
                return list;
            }
            // we should never get here as we covered all JsonData possible types,
            // but we still need to satisfy compiler with
            // "all code paths must return a value"
            throw new ArgumentException("Unsupported node type.");
        }
    }
}
