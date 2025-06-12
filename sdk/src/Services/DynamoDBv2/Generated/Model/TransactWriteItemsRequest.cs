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
    /// Container for the parameters to the TransactWriteItems operation.
    /// <c>TransactWriteItems</c> is a synchronous write operation that groups up to 100
    /// action requests. These actions can target items in different tables, but not in different
    /// Amazon Web Services accounts or Regions, and no two actions can target the same item.
    /// For example, you cannot both <c>ConditionCheck</c> and <c>Update</c> the same item.
    /// The aggregate size of the items in the transaction cannot exceed 4 MB.
    /// 
    ///  
    /// <para>
    /// The actions are completed atomically so that either all of them succeed, or all of
    /// them fail. They are defined by the following objects:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Put</c>  —   Initiates a <c>PutItem</c> operation to write a new item. This structure
    /// specifies the primary key of the item to be written, the name of the table to write
    /// it in, an optional condition expression that must be satisfied for the write to succeed,
    /// a list of the item's attributes, and a field indicating whether to retrieve the item's
    /// attributes if the condition is not met.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Update</c>  —   Initiates an <c>UpdateItem</c> operation to update an existing
    /// item. This structure specifies the primary key of the item to be updated, the name
    /// of the table where it resides, an optional condition expression that must be satisfied
    /// for the update to succeed, an expression that defines one or more attributes to be
    /// updated, and a field indicating whether to retrieve the item's attributes if the condition
    /// is not met.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Delete</c>  —   Initiates a <c>DeleteItem</c> operation to delete an existing
    /// item. This structure specifies the primary key of the item to be deleted, the name
    /// of the table where it resides, an optional condition expression that must be satisfied
    /// for the deletion to succeed, and a field indicating whether to retrieve the item's
    /// attributes if the condition is not met.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ConditionCheck</c>  —   Applies a condition to an item that is not being modified
    /// by the transaction. This structure specifies the primary key of the item to be checked,
    /// the name of the table where it resides, a condition expression that must be satisfied
    /// for the transaction to succeed, and a field indicating whether to retrieve the item's
    /// attributes if the condition is not met.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// DynamoDB rejects the entire <c>TransactWriteItems</c> request if any of the following
    /// is true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A condition in one of the condition expressions is not met.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An ongoing operation is in the process of updating the same item.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There is insufficient provisioned capacity for the transaction to be completed.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An item size becomes too large (bigger than 400 KB), a local secondary index (LSI)
    /// becomes too large, or a similar validation error occurs because of changes made by
    /// the transaction.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The aggregate size of the items in the transaction exceeds 4 MB.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// There is a user error, such as an invalid data format.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class TransactWriteItemsRequest : AmazonDynamoDBRequest
    {
        private string _clientRequestToken;
        private ReturnConsumedCapacity _returnConsumedCapacity;
        private ReturnItemCollectionMetrics _returnItemCollectionMetrics;
        private List<TransactWriteItem> _transactItems = AWSConfigs.InitializeCollections ? new List<TransactWriteItem>() : null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Providing a <c>ClientRequestToken</c> makes the call to <c>TransactWriteItems</c>
        /// idempotent, meaning that multiple identical calls have the same effect as one single
        /// call.
        /// </para>
        ///  
        /// <para>
        /// Although multiple identical calls using the same client request token produce the
        /// same result on the server (no side effects), the responses to the calls might not
        /// be the same. If the <c>ReturnConsumedCapacity</c> parameter is set, then the initial
        /// <c>TransactWriteItems</c> call returns the amount of write capacity units consumed
        /// in making the changes. Subsequent <c>TransactWriteItems</c> calls with the same client
        /// token return the number of read capacity units consumed in reading the item.
        /// </para>
        ///  
        /// <para>
        /// A client request token is valid for 10 minutes after the first request that uses it
        /// is completed. After 10 minutes, any request with the same client token is treated
        /// as a new request. Do not resubmit the same request with the same client token for
        /// more than 10 minutes, or the result might not be idempotent.
        /// </para>
        ///  
        /// <para>
        /// If you submit a request with the same client token but a change in other parameters
        /// within the 10-minute idempotency window, DynamoDB returns an <c>IdempotentParameterMismatch</c>
        /// exception.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
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
        /// response includes statistics about item collections (if any), that were modified during
        /// the operation and are returned in the response. If set to <c>NONE</c> (the default),
        /// no statistics are returned. 
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

        /// <summary>
        /// Gets and sets the property TransactItems. 
        /// <para>
        /// An ordered array of up to 100 <c>TransactWriteItem</c> objects, each of which contains
        /// a <c>ConditionCheck</c>, <c>Put</c>, <c>Update</c>, or <c>Delete</c> object. These
        /// can operate on items in different tables, but the tables must reside in the same Amazon
        /// Web Services account and Region, and no two of them can operate on the same item.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<TransactWriteItem> TransactItems
        {
            get { return this._transactItems; }
            set { this._transactItems = value; }
        }

        // Check to see if TransactItems property is set
        internal bool IsSetTransactItems()
        {
            return this._transactItems != null && (this._transactItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}