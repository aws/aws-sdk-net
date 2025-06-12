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

/*
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchWriteItem operation.
    /// The <c>BatchWriteItem</c> operation puts or deletes multiple items in one or more
    /// tables. A single call to <c>BatchWriteItem</c> can transmit up to 16MB of data over
    /// the network, consisting of up to 25 item put or delete operations. While individual
    /// items can be up to 400 KB once stored, it's important to note that an item's representation
    /// might be greater than 400KB while being sent in DynamoDB's JSON format for the API
    /// call. For more details on this distinction, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/HowItWorks.NamingRulesDataTypes.html">Naming
    /// Rules and Data Types</a>.
    /// 
    ///  <note> 
    /// <para>
    ///  <c>BatchWriteItem</c> cannot update items. If you perform a <c>BatchWriteItem</c>
    /// operation on an existing item, that item's values will be overwritten by the operation
    /// and it will appear like it was updated. To update items, we recommend you use the
    /// <c>UpdateItem</c> action.
    /// </para>
    ///  </note> 
    /// <para>
    /// The individual <c>PutItem</c> and <c>DeleteItem</c> operations specified in <c>BatchWriteItem</c>
    /// are atomic; however <c>BatchWriteItem</c> as a whole is not. If any requested operations
    /// fail because the table's provisioned throughput is exceeded or an internal processing
    /// failure occurs, the failed operations are returned in the <c>UnprocessedItems</c>
    /// response parameter. You can investigate and optionally resend the requests. Typically,
    /// you would call <c>BatchWriteItem</c> in a loop. Each iteration would check for unprocessed
    /// items and submit a new <c>BatchWriteItem</c> request with those unprocessed items
    /// until all items have been processed.
    /// </para>
    ///  
    /// <para>
    /// For tables and indexes with provisioned capacity, if none of the items can be processed
    /// due to insufficient provisioned throughput on all of the tables in the request, then
    /// <c>BatchWriteItem</c> returns a <c>ProvisionedThroughputExceededException</c>. For
    /// all tables and indexes, if none of the items can be processed due to other throttling
    /// scenarios (such as exceeding partition level limits), then <c>BatchWriteItem</c> returns
    /// a <c>ThrottlingException</c>.
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
    /// For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ErrorHandling.html#Programming.Errors.BatchOperations">Batch
    /// Operations and Error Handling</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// With <c>BatchWriteItem</c>, you can efficiently write or delete large amounts of data,
    /// such as from Amazon EMR, or copy data from another database into DynamoDB. In order
    /// to improve performance with these large-scale operations, <c>BatchWriteItem</c> does
    /// not behave in the same way as individual <c>PutItem</c> and <c>DeleteItem</c> calls
    /// would. For example, you cannot specify conditions on individual put and delete requests,
    /// and <c>BatchWriteItem</c> does not return deleted items in the response.
    /// </para>
    ///  
    /// <para>
    /// If you use a programming language that supports concurrency, you can use threads to
    /// write items in parallel. Your application must include the necessary logic to manage
    /// the threads. With languages that don't support threading, you must update or delete
    /// the specified items one at a time. In both situations, <c>BatchWriteItem</c> performs
    /// the specified put and delete operations in parallel, giving you the power of the thread
    /// pool approach without having to introduce complexity into your application.
    /// </para>
    ///  
    /// <para>
    /// Parallel processing reduces latency, but each specified put and delete request consumes
    /// the same number of write capacity units whether it is processed in parallel or not.
    /// Delete operations on nonexistent items consume one write capacity unit.
    /// </para>
    ///  
    /// <para>
    /// If one or more of the following is true, DynamoDB rejects the entire batch write operation:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// One or more tables specified in the <c>BatchWriteItem</c> request does not exist.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Primary key attributes specified on an item in the request do not match those in the
    /// corresponding table's primary key schema.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You try to perform multiple operations on the same item in the same <c>BatchWriteItem</c>
    /// request. For example, you cannot put and delete the same item in the same <c>BatchWriteItem</c>
    /// request. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Your request contains at least two items with identical hash and range keys (which
    /// essentially is two put operations). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There are more than 25 requests in the batch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any individual item in a batch exceeds 400 KB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The total request size exceeds 16 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any individual items with keys exceeding the key length limits. For a partition key,
    /// the limit is 2048 bytes and for a sort key, the limit is 1024 bytes.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BatchWriteItemRequest : AmazonDynamoDBRequest
    {
        private Dictionary<string, List<WriteRequest>> _requestItems = AWSConfigs.InitializeCollections ? new Dictionary<string, List<WriteRequest>>() : null;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnItemCollectionMetrics _returnItemCollectionMetrics;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public BatchWriteItemRequest() { }

        /// <summary>
        /// Instantiates BatchWriteItemRequest with the parameterized properties
        /// </summary>
        /// <param name="requestItems">A map of one or more table names or table ARNs and, for each table, a list of operations to be performed (<c>DeleteRequest</c> or <c>PutRequest</c>). Each element in the map consists of the following: <ul> <li>  <c>DeleteRequest</c> - Perform a <c>DeleteItem</c> operation on the specified item. The item to be deleted is identified by a <c>Key</c> subelement: <ul> <li>  <c>Key</c> - A map of primary key attribute values that uniquely identify the item. Each entry in this map consists of an attribute name and an attribute value. For each primary key, you must provide <i>all</i> of the key attributes. For example, with a simple primary key, you only need to provide a value for the partition key. For a composite primary key, you must provide values for <i>both</i> the partition key and the sort key. </li> </ul> </li> <li>  <c>PutRequest</c> - Perform a <c>PutItem</c> operation on the specified item. The item to be put is identified by an <c>Item</c> subelement: <ul> <li>  <c>Item</c> - A map of attributes and their values. Each entry in this map consists of an attribute name and an attribute value. Attribute values must not be null; string and binary type attributes must have lengths greater than zero; and set type attributes must not be empty. Requests that contain empty values are rejected with a <c>ValidationException</c> exception. If you specify any attributes that are part of an index key, then the data types for those attributes must match those of the schema in the table's attribute definition. </li> </ul> </li> </ul></param>
        public BatchWriteItemRequest(Dictionary<string, List<WriteRequest>> requestItems)
        {
            _requestItems = requestItems;
        }

        /// <summary>
        /// Gets and sets the property RequestItems. 
        /// <para>
        /// A map of one or more table names or table ARNs and, for each table, a list of operations
        /// to be performed (<c>DeleteRequest</c> or <c>PutRequest</c>). Each element in the map
        /// consists of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DeleteRequest</c> - Perform a <c>DeleteItem</c> operation on the specified item.
        /// The item to be deleted is identified by a <c>Key</c> subelement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key</c> - A map of primary key attribute values that uniquely identify the item.
        /// Each entry in this map consists of an attribute name and an attribute value. For each
        /// primary key, you must provide <i>all</i> of the key attributes. For example, with
        /// a simple primary key, you only need to provide a value for the partition key. For
        /// a composite primary key, you must provide values for <i>both</i> the partition key
        /// and the sort key.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>PutRequest</c> - Perform a <c>PutItem</c> operation on the specified item. The
        /// item to be put is identified by an <c>Item</c> subelement:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Item</c> - A map of attributes and their values. Each entry in this map consists
        /// of an attribute name and an attribute value. Attribute values must not be null; string
        /// and binary type attributes must have lengths greater than zero; and set type attributes
        /// must not be empty. Requests that contain empty values are rejected with a <c>ValidationException</c>
        /// exception.
        /// </para>
        ///  
        /// <para>
        /// If you specify any attributes that are part of an index key, then the data types for
        /// those attributes must match those of the schema in the table's attribute definition.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public Dictionary<string, List<WriteRequest>> RequestItems
        {
            get { return this._requestItems; }
            set { this._requestItems = value; }
        }

        // Check to see if RequestItems property is set
        internal bool IsSetRequestItems()
        {
            return this._requestItems != null && (this._requestItems.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property ReturnItemCollectionMetrics. 
        /// <para>
        /// Determines whether item collection metrics are returned. If set to <c>SIZE</c>, the
        /// response includes statistics about item collections, if any, that were modified during
        /// the operation are returned in the response. If set to <c>NONE</c> (the default), no
        /// statistics are returned.
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this._returnItemCollectionMetrics; }
            set { this._returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this._returnItemCollectionMetrics != null;
        }

    }
}