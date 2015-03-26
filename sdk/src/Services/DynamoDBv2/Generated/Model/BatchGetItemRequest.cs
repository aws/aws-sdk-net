/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetItem operation.
    /// The <i>BatchGetItem</i> operation returns the attributes of one or more items from
    /// one or more tables. You identify requested items by primary key.
    /// 
    ///  
    /// <para>
    /// A single operation can retrieve up to 16 MB of data, which can contain as many as
    /// 100 items. <i>BatchGetItem</i> will return a partial result if the response size limit
    /// is exceeded, the table's provisioned throughput is exceeded, or an internal processing
    /// failure occurs. If a partial result is returned, the operation returns a value for
    /// <i>UnprocessedKeys</i>. You can use this value to retry the operation starting with
    /// the next item to get.
    /// </para>
    ///  
    /// <para>
    /// For example, if you ask to retrieve 100 items, but each individual item is 300 KB
    /// in size, the system returns 52 items (so as not to exceed the 16 MB limit). It also
    /// returns an appropriate <i>UnprocessedKeys</i> value so you can get the next page of
    /// results. If desired, your application can include its own logic to assemble the pages
    /// of results into one data set.
    /// </para>
    ///  
    /// <para>
    /// If <i>none</i> of the items can be processed due to insufficient provisioned throughput
    /// on all of the tables in the request, then <i>BatchGetItem</i> will return a <i>ProvisionedThroughputExceededException</i>.
    /// If <i>at least one</i> of the items is successfully processed, then <i>BatchGetItem</i>
    /// completes successfully, while returning the keys of the unread items in <i>UnprocessedKeys</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If DynamoDB returns any unprocessed items, you should retry the batch operation on
    /// those items. However, <i>we strongly recommend that you use an exponential backoff
    /// algorithm</i>. If you retry the batch operation immediately, the underlying read or
    /// write requests can still fail due to throttling on the individual tables. If you delay
    /// the batch operation using exponential backoff, the individual requests in the batch
    /// are much more likely to succeed.
    /// </para>
    ///  
    /// <para>
    /// For more information, go to <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#BatchOperations">Batch
    /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// By default, <i>BatchGetItem</i> performs eventually consistent reads on every table
    /// in the request. If you want strongly consistent reads instead, you can set <i>ConsistentRead</i>
    /// to <code>true</code> for any or all tables.
    /// </para>
    ///  
    /// <para>
    /// In order to minimize response latency, <i>BatchGetItem</i> retrieves items in parallel.
    /// </para>
    ///  
    /// <para>
    /// When designing your application, keep in mind that DynamoDB does not return attributes
    /// in any particular order. To help parse the response by item, include the primary key
    /// values for the items in your request in the <i>AttributesToGet</i> parameter.
    /// </para>
    ///  
    /// <para>
    /// If a requested item does not exist, it is not returned in the result. Requests for
    /// nonexistent items consume the minimum read capacity units according to the type of
    /// read. For more information, see <a href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithTables.html#CapacityUnitCalculations">Capacity
    /// Units Calculations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchGetItemRequest : AmazonDynamoDBRequest
    {
        private Dictionary<string, KeysAndAttributes> _requestItems = new Dictionary<string, KeysAndAttributes>();
        private ReturnConsumedCapacity _returnConsumedCapacity;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BatchGetItemRequest() { }

        /// <summary>
        /// Instantiates BatchGetItemRequest with the parameterized properties
        /// </summary>
        /// <param name="requestItems">A map of one or more table names and, for each table, the corresponding primary keys for the items to retrieve. Each table name can be invoked only once. Each element in the map consists of the following: <ul> <li> <i>Keys</i> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a hash type primary key, you only need to provide the hash attribute. For a hash-and-range type primary key, you must provide <i>both</i> the hash attribute and the range attribute. </li> <li> <i>AttributesToGet</i> - One or more attributes to be retrieved from the table. By default, all attributes are returned. If a specified attribute is not found, it does not appear in the result. Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption. DynamoDB determines capacity units consumed based on item size, not on the amount of data that is returned to an application. </li> <li> <i>ConsistentRead</i> - If <code>true</code>, a strongly consistent read is used; if <code>false</code> (the default), an eventually consistent read is used. </li> </ul></param>
        public BatchGetItemRequest(Dictionary<string, KeysAndAttributes> requestItems)
        {
            _requestItems = requestItems;
        }

        /// <summary>
        /// Instantiates BatchGetItemRequest with the parameterized properties
        /// </summary>
        /// <param name="requestItems">A map of one or more table names and, for each table, the corresponding primary keys for the items to retrieve. Each table name can be invoked only once. Each element in the map consists of the following: <ul> <li> <i>Keys</i> - An array of primary key attribute values that define specific items in the table. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a hash type primary key, you only need to provide the hash attribute. For a hash-and-range type primary key, you must provide <i>both</i> the hash attribute and the range attribute. </li> <li> <i>AttributesToGet</i> - One or more attributes to be retrieved from the table. By default, all attributes are returned. If a specified attribute is not found, it does not appear in the result. Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption. DynamoDB determines capacity units consumed based on item size, not on the amount of data that is returned to an application. </li> <li> <i>ConsistentRead</i> - If <code>true</code>, a strongly consistent read is used; if <code>false</code> (the default), an eventually consistent read is used. </li> </ul></param>
        /// <param name="returnConsumedCapacity">Sets the BatchGetItemRequest ReturnConsumedCapacity property</param>
        public BatchGetItemRequest(Dictionary<string, KeysAndAttributes> requestItems, ReturnConsumedCapacity returnConsumedCapacity)
        {
            _requestItems = requestItems;
            _returnConsumedCapacity = returnConsumedCapacity;
        }

        /// <summary>
        /// Gets and sets the property RequestItems. 
        /// <para>
        /// A map of one or more table names and, for each table, the corresponding primary keys
        /// for the items to retrieve. Each table name can be invoked only once.
        /// </para>
        ///  
        /// <para>
        /// Each element in the map consists of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <i>Keys</i> - An array of primary key attribute values that define specific items
        /// in the table. For each primary key, you must provide <i>all</i> of the key attributes.
        /// For example, with a hash type primary key, you only need to provide the hash attribute.
        /// For a hash-and-range type primary key, you must provide <i>both</i> the hash attribute
        /// and the range attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>AttributesToGet</i> - One or more attributes to be retrieved from the table. By
        /// default, all attributes are returned. If a specified attribute is not found, it does
        /// not appear in the result.
        /// </para>
        ///  
        /// <para>
        /// Note that <i>AttributesToGet</i> has no effect on provisioned throughput consumption.
        /// DynamoDB determines capacity units consumed based on item size, not on the amount
        /// of data that is returned to an application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <i>ConsistentRead</i> - If <code>true</code>, a strongly consistent read is used;
        /// if <code>false</code> (the default), an eventually consistent read is used.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, KeysAndAttributes> RequestItems
        {
            get { return this._requestItems; }
            set { this._requestItems = value; }
        }

        // Check to see if RequestItems property is set
        internal bool IsSetRequestItems()
        {
            return this._requestItems != null && this._requestItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReturnConsumedCapacity.
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this._returnConsumedCapacity; }
            set { this._returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this._returnConsumedCapacity != null;
        }

    }
}