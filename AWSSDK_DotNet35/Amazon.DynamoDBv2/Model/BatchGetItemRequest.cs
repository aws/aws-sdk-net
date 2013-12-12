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
    /// <para>The <i>BatchGetItem</i> operation returns the attributes of one or more items from one or more tables. You identify requested items by
    /// primary key.</para> <para>A single operation can retrieve up to 1 MB of data, which can comprise as many as 100 items. <i>BatchGetItem</i>
    /// will return a partial result if the response size limit is exceeded, the table's provisioned throughput is exceeded, or an internal
    /// processing failure occurs. If a partial result is returned, the operation returns a value for <i>UnprocessedKeys</i> . You can use this
    /// value to retry the operation starting with the next item to get.</para> <para>For example, if you ask to retrieve 100 items, but each
    /// individual item is 50 KB in size, the system returns 20 items (1 MB) and an appropriate <i>UnprocessedKeys</i> value so you can get the next
    /// page of results. If desired, your application can include its own logic to assemble the pages of results into one dataset.</para> <para>If
    /// no items can be processed because of insufficient provisioned throughput on each of the tables involved in the request, <i>BatchGetItem</i>
    /// throws <i>ProvisionedThroughputExceededException</i> . </para> <para>By default, <i>BatchGetItem</i> performs eventually consistent reads on
    /// every table in the request. If you want strongly consistent reads instead, you can set <i>ConsistentRead</i> to <c>true</c> for any or all
    /// tables.</para> <para>In order to minimize response latency, <i>BatchGetItem</i> fetches items in parallel.</para> <para>When designing your
    /// application, keep in mind that Amazon DynamoDB does not return attributes in any particular order. To help parse the response by item,
    /// include the primary key values for the items in your request in the <i>AttributesToGet</i> parameter.</para> <para>If a requested item does
    /// not exist, it is not returned in the result. Requests for nonexistent items consume the minimum read capacity units according to the type of
    /// read. For more information, see <a
    /// href="http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/WorkingWithDDTables.html#CapacityUnitCalculations" >Capacity Units
    /// Calculations</a> in the Amazon DynamoDB Developer Guide.</para>
    /// </summary>
    public partial class BatchGetItemRequest : AmazonDynamoDBv2Request
    {
        private Dictionary<string,KeysAndAttributes> requestItems = new Dictionary<string,KeysAndAttributes>();
        private ReturnConsumedCapacity returnConsumedCapacity;


        /// <summary>
        /// A map of one or more table names and, for each table, the corresponding primary keys for the items to retrieve. Each table name can be
        /// invoked only once. Each element in the map consists of the following: <ul> <li> <i>Keys</i> - An array of primary key attribute values that
        /// define specific items in the table. </li> <li> <i>AttributesToGet</i> - One or more attributes to be retrieved from the table or index. By
        /// default, all attributes are returned. If a specified attribute is not found, it does not appear in the result. </li> <li>
        /// <i>ConsistentRead</i> - If <c>true</c>, a strongly consistent read is used; if <c>false</c> (the default), an eventually consistent read is
        /// used. </li> </ul>
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

        // Check to see if RequestItems property is set
        internal bool IsSetRequestItems()
        {
            return this.requestItems != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, <i>ConsumedCapacity</i> is included in the response; if set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is
        /// not included.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INDEXES, TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

    }
}
    
