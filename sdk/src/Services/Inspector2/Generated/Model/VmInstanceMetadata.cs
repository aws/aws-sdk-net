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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains metadata about a virtual machine (VM) instance associated with a covered
    /// resource.
    /// </summary>
    public partial class VmInstanceMetadata
    {
        private string _inventoryHash;
        private VmPlatform _platform;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _vmImageReference;

        /// <summary>
        /// Gets and sets the property InventoryHash. 
        /// <para>
        /// The inventory hash of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string InventoryHash
        {
            get { return this._inventoryHash; }
            set { this._inventoryHash = value; }
        }

        // Check to see if InventoryHash property is set
        internal bool IsSetInventoryHash()
        {
            return this._inventoryHash != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the VM instance.
        /// </para>
        /// </summary>
        public VmPlatform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VmImageReference. 
        /// <para>
        /// The image reference of the VM instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VmImageReference
        {
            get { return this._vmImageReference; }
            set { this._vmImageReference = value; }
        }

        // Check to see if VmImageReference property is set
        internal bool IsSetVmImageReference()
        {
            return this._vmImageReference != null;
        }

    }
}