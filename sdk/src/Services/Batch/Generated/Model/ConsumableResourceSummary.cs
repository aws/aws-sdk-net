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
    /// Current information about a consumable resource.
    /// </summary>
    public partial class ConsumableResourceSummary
    {
        private string _consumableResourceArn;
        private string _consumableResourceName;
        private long? _inUseQuantity;
        private string _resourceType;
        private long? _totalQuantity;

        /// <summary>
        /// Gets and sets the property ConsumableResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceArn
        {
            get { return this._consumableResourceArn; }
            set { this._consumableResourceArn = value; }
        }

        // Check to see if ConsumableResourceArn property is set
        internal bool IsSetConsumableResourceArn()
        {
            return this._consumableResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumableResourceName. 
        /// <para>
        /// The name of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceName
        {
            get { return this._consumableResourceName; }
            set { this._consumableResourceName = value; }
        }

        // Check to see if ConsumableResourceName property is set
        internal bool IsSetConsumableResourceName()
        {
            return this._consumableResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property InUseQuantity. 
        /// <para>
        /// The amount of the consumable resource that is currently in use.
        /// </para>
        /// </summary>
        public long? InUseQuantity
        {
            get { return this._inUseQuantity; }
            set { this._inUseQuantity = value; }
        }

        // Check to see if InUseQuantity property is set
        internal bool IsSetInUseQuantity()
        {
            return this._inUseQuantity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Indicates whether the resource is available to be re-used after a job completes. Can
        /// be one of: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>REPLENISHABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NON_REPLENISHABLE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property TotalQuantity. 
        /// <para>
        /// The total amount of the consumable resource that is available.
        /// </para>
        /// </summary>
        public long? TotalQuantity
        {
            get { return this._totalQuantity; }
            set { this._totalQuantity = value; }
        }

        // Check to see if TotalQuantity property is set
        internal bool IsSetTotalQuantity()
        {
            return this._totalQuantity.HasValue; 
        }

    }
}