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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the PutInventory operation.
    /// Bulk update custom inventory items on one more instance. The request adds an inventory
    /// item, if it doesn't already exist, or updates an inventory item, if it does exist.
    /// </summary>
    public partial class PutInventoryRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _instanceId;
        private List<InventoryItem> _items = new List<InventoryItem>();

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// An instance ID where you want to add or update inventory items.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// The inventory items that you want to add or update on instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<InventoryItem> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

    }
}