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
    /// Container for the parameters to the BatchAssociateClientDeviceWithCoreDevice operation.
    /// Associates a list of client devices with a core device. Use this API operation to
    /// specify which client devices can discover a core device through cloud discovery. With
    /// cloud discovery, client devices connect to IoT Greengrass to retrieve associated core
    /// devices' connectivity information and certificates. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/configure-cloud-discovery.html">Configure
    /// cloud discovery</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// 
    ///  <note> 
    /// <para>
    /// Client devices are local IoT devices that connect to and communicate with an IoT Greengrass
    /// core device over MQTT. You can connect client devices to a core device to sync MQTT
    /// messages and data to Amazon Web Services IoT Core and interact with client devices
    /// in Greengrass components. For more information, see <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/interact-with-local-iot-devices.html">Interact
    /// with local IoT devices</a> in the <i>IoT Greengrass V2 Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchAssociateClientDeviceWithCoreDeviceRequest : AmazonGreengrassV2Request
    {
        private string _coreDeviceThingName;
        private List<AssociateClientDeviceWithCoreDeviceEntry> _entries = AWSConfigs.InitializeCollections ? new List<AssociateClientDeviceWithCoreDeviceEntry>() : null;

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
        /// The list of client devices to associate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<AssociateClientDeviceWithCoreDeviceEntry> Entries
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