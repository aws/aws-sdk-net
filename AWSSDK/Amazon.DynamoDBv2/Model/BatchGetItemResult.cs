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
    /// <para>Represents the output of a <i>BatchGetItem</i> operation.</para>
    /// </summary>
    public class BatchGetItemResult
    {
        
        private Dictionary<string,List<Dictionary<string,AttributeValue>>> responses = new Dictionary<string,List<Dictionary<string,AttributeValue>>>();
        private Dictionary<string,KeysAndAttributes> unprocessedKeys = new Dictionary<string,KeysAndAttributes>();
        private List<ConsumedCapacity> consumedCapacity = new List<ConsumedCapacity>();

        /// <summary>
        /// A map of table name to a list of items. Each object in <i>Responses</i>consists of a table name, along with a map of attribute data
        /// consisting of the data type and attribute value.
        ///  
        /// </summary>
        public Dictionary<string,List<Dictionary<string,AttributeValue>>> Responses
        {
            get { return this.responses; }
            set { this.responses = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the Responses dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the Responses dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchGetItemResult WithResponses(params KeyValuePair<string, List<Dictionary<string,AttributeValue>>>[] pairs)
        {
            foreach (KeyValuePair<string, List<Dictionary<string,AttributeValue>>> pair in pairs)
            {
                this.Responses[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if Responses property is set
        internal bool IsSetResponses()
        {
            return this.responses != null;
        }

        /// <summary>
        /// A map of tables and their respective keys that were not processed with the current response. The <i>UnprocessedKeys</i> value is in the same
        /// form as <i>RequestItems</i>, so the value can be provided directly to a subsequent <i>BatchGetItem</i> operation. For more information, see
        /// <i>RequestItems</i> in the Request Parameters section. Each element consists of: <ul> <li> <i>Keys</i> - An array of primary key attribute
        /// values that define specific items in the table. </li> <li> <li> <i>AttributesToGet</i> - One or more attributes to be retrieved from the
        /// table or index. By default, all attributes are returned. If a specified attribute is not found, it does not appear in the result. </li> If
        /// you are querying an index and request only attributes that are projected into that index, the operation will read only the index and not the
        /// table. If any of the requested attributes are not projected into the index, Amazon DynamoDB will need to fetch each matching item from the
        /// table. This extra fetching incurs additional throughput cost and latency. </li> <li> <i>ConsistentRead</i> - The consistency of a read
        /// operation. If set to <c>true</c>, then a strongly consistent read is used; otherwise, an eventually consistent read is used. </li> </ul>
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
        public Dictionary<string,KeysAndAttributes> UnprocessedKeys
        {
            get { return this.unprocessedKeys; }
            set { this.unprocessedKeys = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the UnprocessedKeys dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the UnprocessedKeys dictionary.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchGetItemResult WithUnprocessedKeys(params KeyValuePair<string, KeysAndAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, KeysAndAttributes> pair in pairs)
            {
                this.UnprocessedKeys[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if UnprocessedKeys property is set
        internal bool IsSetUnprocessedKeys()
        {
            return this.unprocessedKeys != null;
        }

        /// <summary>
        /// The write capacity units consumed by the operation. Each element consists of: <ul> <li> <i>TableName</i> - The table that consumed the
        /// provisioned throughput. </li> <li> <i>CapacityUnits</i> - The total number of capacity units consumed. </li> </ul>
        ///  
        /// </summary>
        public List<ConsumedCapacity> ConsumedCapacity
        {
            get { return this.consumedCapacity; }
            set { this.consumedCapacity = value; }
        }
        /// <summary>
        /// Adds elements to the ConsumedCapacity collection
        /// </summary>
        /// <param name="consumedCapacity">The values to add to the ConsumedCapacity collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchGetItemResult WithConsumedCapacity(params ConsumedCapacity[] consumedCapacity)
        {
            foreach (ConsumedCapacity element in consumedCapacity)
            {
                this.consumedCapacity.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ConsumedCapacity collection
        /// </summary>
        /// <param name="consumedCapacity">The values to add to the ConsumedCapacity collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BatchGetItemResult WithConsumedCapacity(IEnumerable<ConsumedCapacity> consumedCapacity)
        {
            foreach (ConsumedCapacity element in consumedCapacity)
            {
                this.consumedCapacity.Add(element);
            }

            return this;
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this.consumedCapacity.Count > 0;
        }
    }
}
