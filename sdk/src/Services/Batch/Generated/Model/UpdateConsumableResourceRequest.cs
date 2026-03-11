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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConsumableResource operation.
    /// Updates a consumable resource.
    /// </summary>
    public partial class UpdateConsumableResourceRequest : AmazonBatchRequest
    {
        private string _clientToken;
        private string _consumableResource;
        private string _operation;
        private long? _quantity;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// If this parameter is specified and two update requests with identical payloads and
        /// <c>clientToken</c>s are received, these requests are considered the same request.
        /// Both requests will succeed, but the update will only happen once. A <c>clientToken</c>
        /// is valid for 8 hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumableResource. 
        /// <para>
        /// The name or ARN of the consumable resource to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResource
        {
            get { return this._consumableResource; }
            set { this._consumableResource = value; }
        }

        // Check to see if ConsumableResource property is set
        internal bool IsSetConsumableResource()
        {
            return this._consumableResource != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// Indicates how the quantity of the consumable resource will be updated. Must be one
        /// of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SET</c> 
        /// </para>
        ///  
        /// <para>
        /// Sets the quantity of the resource to the value specified by the <c>quantity</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADD</c> 
        /// </para>
        ///  
        /// <para>
        /// Increases the quantity of the resource by the value specified by the <c>quantity</c>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REMOVE</c> 
        /// </para>
        ///  
        /// <para>
        /// Reduces the quantity of the resource by the value specified by the <c>quantity</c>
        /// parameter.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The change in the total quantity of the consumable resource. The <c>operation</c>
        /// parameter determines whether the value specified here will be the new total quantity,
        /// or the amount by which the total quantity will be increased or reduced. Must be a
        /// non-negative value.
        /// </para>
        /// </summary>
        public long? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}