/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// <para>Represents a set of primary keys and, for each key, the attributes to retrieve from the table.</para>
    /// </summary>
    public class KeysAndAttributes
    {
        
        private List<Dictionary<string,AttributeValue>> keys = new List<Dictionary<string,AttributeValue>>();
        private List<string> attributesToGet = new List<string>();
        private bool? consistentRead;

        /// <summary>
        /// Represents the primary key attribute values that define the items and the attributes associated with the items.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<Dictionary<string,AttributeValue>> Keys
        {
            get { return this.keys; }
            set { this.keys = value; }
        }
        /// <summary>
        /// Adds elements to the Keys collection
        /// </summary>
        /// <param name="keys">The values to add to the Keys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithKeys(params Dictionary<string,AttributeValue>[] keys)
        {
            foreach (Dictionary<string,AttributeValue> element in keys)
            {
                this.keys.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Keys collection
        /// </summary>
        /// <param name="keys">The values to add to the Keys collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithKeys(IEnumerable<Dictionary<string,AttributeValue>> keys)
        {
            foreach (Dictionary<string,AttributeValue> element in keys)
            {
                this.keys.Add(element);
            }

            return this;
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this.keys.Count > 0;
        }

        /// <summary>
        /// Represents one or more attributes to retrieve from the table or index. If no attribute names are specified then all attributes will be
        /// returned. If any of the specified attributes are not found, they will not appear in the result. If you are querying an index and request
        /// only attributes that are projected into that index, the operation will read only the index and not the table. If any of the requested
        /// attributes are not projected into the index, Amazon DynamoDB will need to fetch each matching item from the table. This extra fetching
        /// incurs additional throughput cost and latency.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this.attributesToGet; }
            set { this.attributesToGet = value; }
        }
        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithAttributesToGet(params string[] attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AttributesToGet collection
        /// </summary>
        /// <param name="attributesToGet">The values to add to the AttributesToGet collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithAttributesToGet(IEnumerable<string> attributesToGet)
        {
            foreach (string element in attributesToGet)
            {
                this.attributesToGet.Add(element);
            }

            return this;
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this.attributesToGet.Count > 0;
        }

        /// <summary>
        /// Represents the consistency of a read operation. If set to <c>true</c>, then a strongly consistent read is used; otherwise, an eventually
        /// consistent read is used.
        ///  
        /// </summary>
        public bool ConsistentRead
        {
            get { return this.consistentRead ?? default(bool); }
            set { this.consistentRead = value; }
        }

        /// <summary>
        /// Sets the ConsistentRead property
        /// </summary>
        /// <param name="consistentRead">The value to set for the ConsistentRead property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public KeysAndAttributes WithConsistentRead(bool consistentRead)
        {
            this.consistentRead = consistentRead;
            return this;
        }
            

        // Check to see if ConsistentRead property is set
        internal bool IsSetConsistentRead()
        {
            return this.consistentRead.HasValue;
        }
    }
}
