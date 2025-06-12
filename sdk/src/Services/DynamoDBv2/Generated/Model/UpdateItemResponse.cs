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
    /// Represents the output of an <c>UpdateItem</c> operation.
    /// </summary>
    public partial class UpdateItemResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, AttributeValue> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private ConsumedCapacity _consumedCapacity;
        private ItemCollectionMetrics _itemCollectionMetrics;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of attribute values as they appear before or after the <c>UpdateItem</c> operation,
        /// as determined by the <c>ReturnValues</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// The <c>Attributes</c> map is only present if the update was successful and <c>ReturnValues</c>
        /// was specified as something other than <c>NONE</c> in the request. Each element represents
        /// one attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the <c>UpdateItem</c> operation. The data returned
        /// includes the total provisioned throughput consumed, along with statistics for the
        /// table and any indexes involved in the operation. <c>ConsumedCapacity</c> is only returned
        /// if the <c>ReturnConsumedCapacity</c> parameter was specified. For more information,
        /// see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/read-write-operations.html#write-operation-consumption">Capacity
        /// unity consumption for write operations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ConsumedCapacity ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCollectionMetrics. 
        /// <para>
        /// Information about item collections, if any, that were affected by the <c>UpdateItem</c>
        /// operation. <c>ItemCollectionMetrics</c> is only returned if the <c>ReturnItemCollectionMetrics</c>
        /// parameter was specified. If the table does not have any local secondary indexes, this
        /// information is not returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Each <c>ItemCollectionMetrics</c> element consists of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ItemCollectionKey</c> - The partition key value of the item collection. This is
        /// the same as the partition key value of the item itself.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SizeEstimateRangeGB</c> - An estimate of item collection size, in gigabytes. This
        /// value is a two-element array containing a lower bound and an upper bound for the estimate.
        /// The estimate includes the size of all the items in the table, plus the size of all
        /// attributes projected into all of the local secondary indexes on that table. Use this
        /// estimate to measure whether a local secondary index is approaching its size limit.
        /// </para>
        ///  
        /// <para>
        /// The estimate is subject to change over time; therefore, do not rely on the precision
        /// or accuracy of the estimate.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ItemCollectionMetrics ItemCollectionMetrics
        {
            get { return this._itemCollectionMetrics; }
            set { this._itemCollectionMetrics = value; }
        }

        // Check to see if ItemCollectionMetrics property is set
        internal bool IsSetItemCollectionMetrics()
        {
            return this._itemCollectionMetrics != null;
        }

    }
}