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
    /// Represents the output of a <c>GetItem</c> operation.
    /// </summary>
    public partial class GetItemResponse : AmazonWebServiceResponse
    {
        private ConsumedCapacity _consumedCapacity;
        private Dictionary<string, AttributeValue> _item = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property ConsumedCapacity. 
        /// <para>
        /// The capacity units consumed by the <c>GetItem</c> operation. The data returned includes
        /// the total provisioned throughput consumed, along with statistics for the table and
        /// any indexes involved in the operation. <c>ConsumedCapacity</c> is only returned if
        /// the <c>ReturnConsumedCapacity</c> parameter was specified. For more information, see
        /// <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/ProvisionedThroughput.html#ItemSizeCalculations.Reads">Provisioned
        /// Throughput</a> in the <i>Amazon DynamoDB Developer Guide</i>.
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
        /// Gets and sets the property Item. 
        /// <para>
        /// A map of attribute names to <c>AttributeValue</c> objects, as specified by <c>ProjectionExpression</c>.
        /// </para>
        /// </summary>
        public Dictionary<string, AttributeValue> Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        /// <summary>
        /// This property is set to true if the property <seealso cref="Item"/>
        /// is set; false otherwise.
        /// This property can be used to determine if the related property
        /// was returned by a service response or if the related property
        /// should be sent to the service during a service call.
        /// </summary>
        /// <returns>
        /// True if the related property was set or will be sent to a service; false otherwise.
        /// </returns>
        public bool IsItemSet
        {
            get
            {
                return Amazon.Util.Internal.InternalSDKUtils.GetIsSet(this._item);
            }
            set
            {
                Amazon.Util.Internal.InternalSDKUtils.SetIsSet(value, ref this._item);
            }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this.IsItemSet; 
        }

    }
}