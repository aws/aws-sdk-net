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
    /// This is the response object from the TransactGetItems operation.
    /// </summary>
    public partial class TransactGetItemsResponse : AmazonWebServiceResponse
    {
        private List<ConsumedCapacity> _consumedCapacity = AWSConfigs.InitializeCollections ? new List<ConsumedCapacity>() : null;
        private List<ItemResponse> _responses = AWSConfigs.InitializeCollections ? new List<ItemResponse>() : null;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// If the <i>ReturnConsumedCapacity</i> value was <c>TOTAL</c>, this is an array of <c>ConsumedCapacity</c>
        /// objects, one for each table addressed by <c>TransactGetItem</c> objects in the <i>TransactItems</i>
        /// parameter. These <c>ConsumedCapacity</c> objects report the read-capacity units consumed
        /// by the <c>TransactGetItems</c> call in that table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConsumedCapacity> ConsumedCapacity
        {
            get { return this._consumedCapacity; }
            set { this._consumedCapacity = value; }
        }

        // Check to see if ConsumedCapacity property is set
        internal bool IsSetConsumedCapacity()
        {
            return this._consumedCapacity != null && (this._consumedCapacity.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Responses. 
        /// <para>
        /// An ordered array of up to 100 <c>ItemResponse</c> objects, each of which corresponds
        /// to the <c>TransactGetItem</c> object in the same position in the <i>TransactItems</i>
        /// array. Each <c>ItemResponse</c> object contains a Map of the name-value pairs that
        /// are the projected attributes of the requested item.
        /// </para>
        ///  
        /// <para>
        /// If a requested item could not be retrieved, the corresponding <c>ItemResponse</c>
        /// object is Null, or if the requested item has no projected attributes, the corresponding
        /// <c>ItemResponse</c> object is an empty Map. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<ItemResponse> Responses
        {
            get { return this._responses; }
            set { this._responses = value; }
        }

        // Check to see if Responses property is set
        internal bool IsSetResponses()
        {
            return this._responses != null && (this._responses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}