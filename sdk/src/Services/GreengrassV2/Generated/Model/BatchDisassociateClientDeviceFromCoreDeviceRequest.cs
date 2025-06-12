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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateClientDeviceFromCoreDevice operation.
    /// Disassociates a list of client devices from a core device. After you disassociate
    /// a client device from a core device, the client device won't be able to use cloud discovery
    /// to retrieve the core device's connectivity information and certificates.
    /// </summary>
    public partial class BatchDisassociateClientDeviceFromCoreDeviceRequest : AmazonGreengrassV2Request
    {
        private string _coreDeviceThingName;
        private List<DisassociateClientDeviceFromCoreDeviceEntry> _entries = AWSConfigs.InitializeCollections ? new List<DisassociateClientDeviceFromCoreDeviceEntry>() : null;

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CoreDeviceThingName
        {
            get { return this._coreDeviceThingName; }
            set { this._coreDeviceThingName = value; }
        }

        // Check to see if CoreDeviceThingName property is set
        internal bool IsSetCoreDeviceThingName()
        {
            return this._coreDeviceThingName != null;
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of client devices to disassociate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<DisassociateClientDeviceFromCoreDeviceEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}