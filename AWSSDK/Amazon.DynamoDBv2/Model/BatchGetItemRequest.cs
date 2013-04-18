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
    /// Container for the parameters to the BatchGetItem operation.
    /// <para>The <i>BatchGetItem</i> operation returns the attributes for multiple items from multiple tables using their primary keys. The maximum
    /// number of items that can be retrieved for a single operation is 100. Also, the number of items retrieved is constrained by a 1 MB size
    /// limit. If the response size limit is exceeded or a partial result is returned because the table’s provisioned throughput is exceeded, or
    /// because of an internal processing failure, Amazon DynamoDB returns an <i>UnprocessedKeys</i> value so you can retry the operation starting
    /// with the next item to get. Amazon DynamoDB automatically adjusts the number of items returned per page to enforce this limit. For example,
    /// even if you ask to retrieve 100 items, but each individual item is 50 KB in size, the system returns 20 items and an appropriate
    /// <i>UnprocessedKeys</i> value so you can get the next page of results. If desired, your application can include its own logic to assemble the
    /// pages of results into one set.</para> <para>If no items could be processed because of insufficient provisioned throughput on each of the
    /// tables involved in the request, Amazon DynamoDB returns a <i>ProvisionedThroughputExceededException</i> . </para> <para><b>NOTE:</b> By
    /// default, BatchGetItem performs eventually consistent reads on every table in the request. You can set ConsistentRead to true, on a per-table
    /// basis, if you want consistent reads instead. BatchGetItem fetches items in parallel to minimize response latencies. When designing your
    /// application, keep in mind that Amazon DynamoDB does not guarantee how attributes are ordered in the returned response. Include the primary
    /// key values in the AttributesToGet for the items in your request to help parse the response by item. If the requested items do not exist,
    /// nothing is returned in the response for those items. Requests for non-existent items consume the minimum read capacity units according to
    /// the type of read. For more information, see Capacity Units Calculations of the Amazon DynamoDB Developer Guide. </para>
    /// </summary>
    /// <seealso cref="Amazon.DynamoDBv2.AmazonDynamoDB.BatchGetItem"/>
    public class BatchGetItemRequest : AmazonWebServiceRequest
    {
        private Dictionary<string,KeysAndAttributes> requestItems = new Dictionary<string,KeysAndAttributes>();
        private string returnConsumedCapacity;

        /// <summary>
        /// A map of one or more table names and, for each table, the corresponding primary keys for the items to retrieve. While requesting items, each
        /// table name can be invoked only once per operation. Each <i>KeysAndAttributes</i> element consists of: <ul> <li> <i>Keys</i>-An array of
        /// primary key attribute values that define the items and the attributes associated with the items. </li> <li> <i>AttributesToGet</i>-One or
        /// more attributes to retrieve from the table or index. If <i>AttributesToGet</i> is not specified, then all attributes will be returned. If
        /// any of the specified attributes are not found, they will not appear in the result. </li> <li> <i>ConsistentRead</i>-The consistency of a
        /// read operation. If set to <c>true</c>, then a strongly consistent read is used; otherwise, an eventually consistent read is used. </li>
        /// </ul>
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
        public Dictionary<string,KeysAndAttributes> RequestItems
        {
            get { return this.requestItems; }
            set { this.requestItems = value; }
        }

        /// <summary>
        /// Adds the KeyValuePairs to the RequestItems dictionary.
        /// </summary>
        /// <param name="pairs">The pairs to be added to the RequestItems dictionary.</param>
        /// <returns>this instance</returns>
        public BatchGetItemRequest WithRequestItems(params KeyValuePair<string, KeysAndAttributes>[] pairs)
        {
            foreach (KeyValuePair<string, KeysAndAttributes> pair in pairs)
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
        public BatchGetItemRequest WithReturnConsumedCapacity(string returnConsumedCapacity)
        {
            this.returnConsumedCapacity = returnConsumedCapacity;
            return this;
        }
            

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }
    }
}
    
