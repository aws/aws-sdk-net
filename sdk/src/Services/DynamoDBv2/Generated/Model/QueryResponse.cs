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
    /// Represents the output of a <c>Query</c> operation.
    /// </summary>
    public partial class QueryResponse : AmazonWebServiceResponse
    {
        private ConsumedCapacity _consumedCapacity;
        private int? _count;
        private List<Dictionary<string, AttributeValue>> _items = AWSConfigs.InitializeCollections ? new List<Dictionary<string, AttributeValue>>() : null;
        private Dictionary<string, AttributeValue> _lastEvaluatedKey = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private int? _scannedCount;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the <c>Query</c> operation. The data returned includes
        /// the total provisioned throughput consumed, along with statistics for the table and
        /// any indexes involved in the operation. <c>ConsumedCapacity</c> is only returned if
        /// the <c>ReturnConsumedCapacity</c> parameter was specified. For more information, see
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/read-write-operations.html#read-operation-consumption">Capacity
        /// unit consumption for read operations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
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
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of items in the response.
        /// </para>
        ///  
        /// <para>
        /// If you used a <c>QueryFilter</c> in the request, then <c>Count</c> is the number of
        /// items returned after the filter was applied, and <c>ScannedCount</c> is the number
        /// of matching items before the filter was applied.
        /// </para>
        ///  
        /// <para>
        /// If you did not use a filter in the request, then <c>Count</c> and <c>ScannedCount</c>
        /// are the same.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// An array of item attributes that match the query criteria. Each element in this array
        /// consists of an attribute name and the value for that attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Dictionary<string, AttributeValue>> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastEvaluatedKey. 
        /// <para>
        /// The primary key of the item where the operation stopped, inclusive of the previous
        /// result set. Use this value to start a new operation, excluding this value in the new
        /// request.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedKey</c> is empty, then the "last page" of results has been processed
        /// and there is no more data to be retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedKey</c> is not empty, it does not necessarily mean that there is
        /// more data in the result set. The only way to know when you have reached the end of
        /// the result set is when <c>LastEvaluatedKey</c> is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> LastEvaluatedKey
        {
            get { return this._lastEvaluatedKey; }
            set { this._lastEvaluatedKey = value; }
        }

        // Check to see if LastEvaluatedKey property is set
        internal bool IsSetLastEvaluatedKey()
        {
            return this._lastEvaluatedKey != null && (this._lastEvaluatedKey.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScannedCount. 
        /// <para>
        /// The number of items evaluated, before any <c>QueryFilter</c> is applied. A high <c>ScannedCount</c>
        /// value with few, or no, <c>Count</c> results indicates an inefficient <c>Query</c>
        /// operation. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Scan.html#Scan.Count">Count
        /// and ScannedCount</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you did not use a filter in the request, then <c>ScannedCount</c> is the same as
        /// <c>Count</c>.
        /// </para>
        /// </summary>
        public int? ScannedCount
        {
            get { return this._scannedCount; }
            set { this._scannedCount = value; }
        }

        // Check to see if ScannedCount property is set
        internal bool IsSetScannedCount()
        {
            return this._scannedCount.HasValue; 
        }

    }
}