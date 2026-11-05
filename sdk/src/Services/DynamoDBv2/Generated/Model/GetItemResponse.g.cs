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
    /// This is the response object from the GetItem operation.
    /// </summary>
    public partial class GetItemResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the <c>GetItem</c> operation. The data returned includes
        /// the total provisioned throughput consumed, along with statistics for the table and
        /// any indexes involved in the operation. <c>ConsumedCapacity</c> is only returned if
        /// the <c>ReturnConsumedCapacity</c> parameter was specified. For more information, see
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/read-write-operations.html#read-operation-consumption">Capacity
        /// unit consumption for read operations</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ConsumedCapacity ConsumedCapacity { get; set; }

        /// <summary>
        /// Checks to see if the ConsumedCapacity property is set.
        /// </summary>
        internal bool IsSetConsumedCapacity() => this.ConsumedCapacity != null;

        private Dictionary<string, AttributeValue> _Item = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property Item. 
        /// <para>
        /// A map of attribute names to <c>AttributeValue</c> objects, as specified by <c>ProjectionExpression</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, AttributeValue> Item { get => this._Item; set => this._Item = value; }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Item"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// <para>
        /// If this property is set to false the property <seealso cref="Item"/> will be reset to null.
        /// </para>
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsItemSet
        {
            get => Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._Item);
            set => Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._Item);
        }

        /// <summary>
        /// Checks to see if the Item property is set.
        /// </summary>
        internal bool IsSetItem() => this.IsItemSet;
    }
}
