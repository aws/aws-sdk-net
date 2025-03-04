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
    /// Information about a consumable resource required to run a job.
    /// </summary>
    public partial class ConsumableResourceRequirement
    {
        private string _consumableResource;
        private long? _quantity;

        /// <summary>
        /// Gets and sets the property ConsumableResource. 
        /// <para>
        /// The name or ARN of the consumable resource.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The quantity of the consumable resource that is needed.
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