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
    /// <para>Represents the output of a <i>BatchWriteItem</i> operation.</para>
    /// </summary>
    public class BatchWriteItemResult
    {
        
        private Dictionary<string,List<WriteRequest>> unprocessedItems = new Dictionary<string,List<WriteRequest>>();
        private Dictionary<string,List<ItemCollectionMetrics>> itemCollectionMetrics = new Dictionary<string,List<ItemCollectionMetrics>>();
        private List<ConsumedCapacity> consumedCapacity = new List<ConsumedCapacity>();

        /// <summary>
        /// A map of tables and requests against those tables that were not processed. The <i>UnprocessedKeys</i> value is in the same form as
        /// <i>RequestItems</i>, so you can provide this value directly to a subsequent <i>BatchGetItem</i> operation. For more information, see
        /// <i>RequestItems</i> in the Request Parameters section. Each <i>UnprocessedItems</i> entry consists of a table name and, for that table, a
        /// list of operations to perform (<i>DeleteRequest</i> or <i>PutRequest</i>). <ul> <li> <i>DeleteRequest</i> - Perform a <i>DeleteItem</i>
        /// operation on the specified item. The item to be deleted is identified by a <i>Key</i> subelement: <ul> <li> <i>Key</i> - A map of primary
        /// key attribute values that uniquely identify the item. Each entry in this map consists of an attribute name and an attribute value. </li>
        /// </ul> </li> <li> <i>PutRequest</i> - Perform a <i>PutItem</i> operation on the specified item. The item to be put is identified by an
        /// <i>Item</i> subelement: <ul> <li> <i>Item</i> - A map of attributes and their values. Each entry in this map consists of an attribute name
        /// and an attribute value. Attribute values must not be null; string and binary type attributes must have lengths greater than zero; and set
        /// type attributes must not be empty. Requests that contain empty values will be rejected with a <i>ValidationException</i>. If you specify any
        /// attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute
        /// definition.</li> </ul> </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 25</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public Dictionary<string,List<WriteRequest>> UnprocessedItems
        {
            get { return this.unprocessedItems; }
            set { this.unprocessedItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the UnprocessedItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the UnprocessedItems dictionary.</param>
        /// <returns>this instance</returns>
        public BatchWriteItemResult WithUnprocessedItems(params KeyValuePair<string, List<WriteRequest>>[] pairs)
        {
            foreach (KeyValuePair<string, List<WriteRequest>> pair in pairs)
            {
                this.UnprocessedItems[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if UnprocessedItems property is set
        internal bool IsSetUnprocessedItems()
        {
            return this.unprocessedItems != null;
        }

        /// <summary>
        /// A list of tables that were processed by <i>BatchWriteItem</i> and, for each table, information about any item collections that were affected
        /// by individual <i>DeleteItem</i> or <i>PutItem</i> operations. Each entry consists of the following subelements: <ul> <li>
        /// <i>ItemCollectionKey</i> - The hash key value of the item collection. This is the same as the hash key of the item. </li> <li>
        /// <i>SizeEstimateRange</i> - An estimate of item collection size, expressed in GB. This is a two-element array containing a lower bound and an
        /// upper bound for the estimate. The estimate includes the size of all the items in the table, plus the size of all attributes projected into
        /// all of the secondary indexes on the table. Use this estimate to measure whether a secondary index is approaching its size limit. The
        /// estimate is subject to change over time; therefore, do not rely on the precision or accuracy of the estimate. </li> </ul>
        ///  
        /// </summary>
        public Dictionary<string,List<ItemCollectionMetrics>> ItemCollectionMetrics
        {
            get { return this.itemCollectionMetrics; }
            set { this.itemCollectionMetrics = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the ItemCollectionMetrics dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the ItemCollectionMetrics dictionary.</param>
        /// <returns>this instance</returns>
        public BatchWriteItemResult WithItemCollectionMetrics(params KeyValuePair<string, List<ItemCollectionMetrics>>[] pairs)
        {
            foreach (KeyValuePair<string, List<ItemCollectionMetrics>> pair in pairs)
            {
                this.ItemCollectionMetrics[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if ItemCollectionMetrics property is set
        internal bool IsSetItemCollectionMetrics()
        {
            return this.itemCollectionMetrics != null;
        }

        /// <summary>
        /// The capacity units consumed by the operation. Each element consists of: <ul> <li> <i>TableName</i> - The table that consumed the provisioned
        /// throughput. </li> <li> <i>CapacityUnits</i> - The total number of capacity units consumed. </li> </ul>
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
        public BatchWriteItemResult WithConsumedCapacity(params ConsumedCapacity[] consumedCapacity)
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
        public BatchWriteItemResult WithConsumedCapacity(IEnumerable<ConsumedCapacity> consumedCapacity)
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
