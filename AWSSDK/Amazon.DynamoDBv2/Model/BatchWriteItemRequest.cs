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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchWriteItem operation.
    /// <para>This operation enables you to put or delete several items across multiple tables in a single API call. </para> <para>To upload one
    /// item, you can use the <i>PutItem</i> API and to delete one item, you can use the <i>DeleteItem</i> API. However, when you want to upload or
    /// delete large amounts of data, such as uploading large amounts of data from Amazon Elastic MapReduce (EMR) or migrate data from another
    /// database into Amazon DynamoDB, this API offers an efficient alternative. </para> <para>If you use a programming language that supports
    /// concurrency, such as Java, you can use threads to upload items in parallel. This adds complexity in your application to handle the threads.
    /// With other languages that don't support threading, such as PHP, you must upload or delete items one at a time. In both situations, the
    /// <i>BatchWriteItem</i> API provides an alternative where the API performs the specified put and delete operations in parallel, giving you the
    /// power of the thread pool approach without having to introduce complexity in your application. </para> <para>Note that each individual put
    /// and delete specified in a <i>BatchWriteItem</i> operation costs the same in terms of consumed capacity units, however, the API performs the
    /// specified operations in parallel giving you lower latency. Delete operations on non-existent items consume 1 write capacity unit.</para>
    /// <para>When using this API, note the following limitations:</para>
    /// <ul>
    /// <li> <para> <i>Maximum operations in a single request-</i> You can specify a total of up to 25 put or delete operations; however, the total
    /// request size cannot exceed 1 MB (the HTTP payload). </para> </li>
    /// <li> <para>You can use the <i>BatchWriteItem</i> operation only to put and delete items. You cannot use it to update existing items.</para>
    /// </li>
    /// <li> <para> <i>Not an atomic operation-</i> The individual <i>PutItem</i> and <i>DeleteItem</i> operations specified in
    /// <i>BatchWriteItem</i> are atomic; however <i>BatchWriteItem</i> as a whole is a "best-effort" operation and not an atomic operation. That
    /// is, in a <i>BatchWriteItem</i> request, some operations might succeed and others might fail. The failed operations are returned in
    /// <i>UnprocessedItems</i> in the response. Some of these failures might be because you exceeded the provisioned throughput configured for the
    /// table or a transient failure such as a network error. You can investigate and optionally resend the requests. Typically, you call
    /// <i>BatchWriteItem</i> in a loop and in each iteration check for unprocessed items, and submit a new <i>BatchWriteItem</i> request with those
    /// unprocessed items. </para> </li>
    /// <li> <para> <i>Does not return any items-</i> The <i>BatchWriteItem</i> is designed for uploading large amounts of data efficiently. It
    /// does not provide some of the sophistication offered by APIs such as <i>PutItem</i> and <i>DeleteItem</i> . For example, the
    /// <i>DeleteItem</i> API supports <i>ReturnValues</i> in the request body to request the deleted item in the response. The
    /// <i>BatchWriteItem</i> operation does not return any items in the response.</para> </li>
    /// <li> <para>Unlike the <i>PutItem</i> and <i>DeleteItem</i> APIs, <i>BatchWriteItem</i> does not allow you to specify conditions on
    /// individual write requests in the operation.</para> </li>
    /// <li> <para>Attribute values must not be null; string and binary type attributes must have lengths greater than zero; and set type
    /// attributes must not be empty. Requests that have empty values will be rejected with a <i>ValidationException</i> .</para> </li>
    /// 
    /// </ul>
    /// <para>Amazon DynamoDB rejects the entire batch write operation if any one of the following is true:
    /// <ul>
    /// <li> <para>If one or more tables specified in the <i>BatchWriteItem</i> request does not exist.</para> </li>
    /// <li> <para>If primary key attributes specified on an item in the request does not match the corresponding table's primary key
    /// schema.</para> </li>
    /// <li> <para>If you try to perform multiple operations on the same item in the same <i>BatchWriteItem</i> request. For example, you cannot
    /// put and delete the same item in the same <i>BatchWriteItem</i> request. </para> </li>
    /// <li> <para>If the total request size exceeds the 1 MB request size (the HTTP payload) limit.</para> </li>
    /// <li> <para>If any individual item in a batch exceeds the 64 KB item size limit.</para> </li>
    /// 
    /// </ul>
    /// </para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchWriteItem"/>
    public class BatchWriteItemRequest : AmazonWebServiceRequest
    {
        private Dictionary<string,List<WriteRequest>> requestItems = new Dictionary<string,List<WriteRequest>>();
        private string returnConsumedCapacity;
        private string returnItemCollectionMetrics;

        /// <summary>
        /// A map of one or more table names and, for each table, a list of operations to perform (<i>DeleteRequest</i> or <i>PutRequest</i>). <ul> <li>
        /// <i>DeleteRequest</i>-Perform a <i>DeleteItem</i> operation on the specified item. The item to be deleted is identified by: <ul> <li>
        /// <i>Key</i>-A map of primary key attribute values that uniquely identify the item. Each entry in this map consists of an attribute name and
        /// an attribute value. </li> </ul> </li> <li> <i>PutRequest</i>-Perform a <i>PutItem</i> operation on the specified item. The item to be
        /// updated is identified by: <ul> <li><i>Item</i>-A map of attributes and their values. Each entry in this map consists of an attribute name
        /// and an attribute value. If you specify any attributes that are part of an index key, then the data types for those attributes must match
        /// those of the schema in the table's attribute definition.</li> </ul> </li> </ul>
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
        public Dictionary<string,List<WriteRequest>> RequestItems
        {
            get { return this.requestItems; }
            set { this.requestItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the RequestItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the RequestItems dictionary.</param>
        /// <returns>this instance</returns>
        public BatchWriteItemRequest WithRequestItems(params KeyValuePair<string, List<WriteRequest>>[] pairs)
        {
            foreach (KeyValuePair<string, List<WriteRequest>> pair in pairs)
            {
                this.RequestItems[pair.Key] = pair.Value;
            }

            return this;
        }

        // Check to see if RequestItems property is set
        internal bool IsSetRequestItems()
        {
            return this.requestItems != null;
        }

        /// <summary>
        /// Determines whether to include consumed capacity information in the output. If this is set to <c>TOTAL</c>, then this information is shown in
        /// the output; otherwise, the consumed capacity information is not shown.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        /// <summary>
        /// Sets the ReturnConsumedCapacity property
        /// </summary>
        /// <param name="returnConsumedCapacity">The value to set for the ReturnConsumedCapacity property </param>
        /// <returns>this instance</returns>
        public BatchWriteItemRequest WithReturnConsumedCapacity(string returnConsumedCapacity)
        {
            this.returnConsumedCapacity = returnConsumedCapacity;
            return this;
        }
            

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// Indicates whether to return statistics about item collections, if any, that were modified during the operation. The default for
        /// <i>ReturnItemCollectionMetrics</i> is <c>NONE</c>, meaning that no statistics will be returned. To obtain the statistics, set
        /// <i>ReturnItemCollectionMetrics</i> to <c>SIZE</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SIZE, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ReturnItemCollectionMetrics
        {
            get { return this.returnItemCollectionMetrics; }
            set { this.returnItemCollectionMetrics = value; }
        }

        /// <summary>
        /// Sets the ReturnItemCollectionMetrics property
        /// </summary>
        /// <param name="returnItemCollectionMetrics">The value to set for the ReturnItemCollectionMetrics property </param>
        /// <returns>this instance</returns>
        public BatchWriteItemRequest WithReturnItemCollectionMetrics(string returnItemCollectionMetrics)
        {
            this.returnItemCollectionMetrics = returnItemCollectionMetrics;
            return this;
        }
            

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this.returnItemCollectionMetrics != null;
        }
    }
}
    
