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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// MetaData for Sidewalk device.
    /// </summary>
    public partial class SidewalkDeviceMetadata
    {
        /// <summary>
        /// Gets and sets the property BatteryLevel. 
        /// <para>
        /// Sidewalk device battery level.
        /// </para>
        /// </summary>
        public BatteryLevel BatteryLevel { get; set; }

        /// <summary>
        /// Checks to see if the BatteryLevel property is set.
        /// </summary>
        internal bool IsSetBatteryLevel() => this.BatteryLevel != null;

        /// <summary>
        /// Gets and sets the property DeviceState. 
        /// <para>
        /// Device state defines the device status of sidewalk device.
        /// </para>
        /// </summary>
        public DeviceState DeviceState { get; set; }

        /// <summary>
        /// Checks to see if the DeviceState property is set.
        /// </summary>
        internal bool IsSetDeviceState() => this.DeviceState != null;

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// Sidewalk device status notification.
        /// </para>
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Checks to see if the Event property is set.
        /// </summary>
        internal bool IsSetEvent() => this.Event != null;

        /// <summary>
        /// Gets and sets the property Rssi. 
        /// <para>
        /// The RSSI value.
        /// </para>
        /// </summary>
        public int? Rssi { get; set; }

        /// <summary>
        /// Checks to see if the Rssi property is set.
        /// </summary>
        internal bool IsSetRssi() => this.Rssi.HasValue;
    }
}
