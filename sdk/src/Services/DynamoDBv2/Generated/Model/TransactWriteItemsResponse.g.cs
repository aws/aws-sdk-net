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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// This is the response object from the TransactWriteItems operation.
    /// </summary>
    public partial class TransactWriteItemsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the entire <c>TransactWriteItems</c> operation. The
        /// values of the list are ordered according to the ordering of the <c>TransactItems</c>
        /// request parameter. 
        /// </para>
        ///  
        /// <para>
        /// If the table has vector indexes, each element also includes a <c>VectorIndexes</c>
        /// field with <c>VectorWriteRequestBytes</c> consumed for each affected vector index.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConsumedCapacity> ConsumedCapacity { get; set; } = AWSConfigs.InitializeCollections ? new List<ConsumedCapacity>() : null;

        /// <summary>
        /// Checks to see if the ConsumedCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedCapacity() => this.ConsumedCapacity != null && (this.ConsumedCapacity.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ItemCollectionMetrics. 
        /// <para>
        /// A list of tables that were processed by <c>TransactWriteItems</c> and, for each table,
        /// information about any item collections that were affected by individual <c>UpdateItem</c>,
        /// <c>PutItem</c>, or <c>DeleteItem</c> operations. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<ItemCollectionMetrics>> ItemCollectionMetrics { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ItemCollectionMetrics>>() : null;

        /// <summary>
        /// Checks to see if the ItemCollectionMetrics property is set.
        /// </summary>
        internal bool IsSetItemCollectionMetrics() => this.ItemCollectionMetrics != null && (this.ItemCollectionMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
