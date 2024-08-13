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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
        private BatteryLevel _batteryLevel;
        private DeviceState _deviceState;
        private Event _event;
        private int? _rssi;

        /// <summary>
        /// Gets and sets the property BatteryLevel. 
        /// <para>
        /// Sidewalk device battery level.
        /// </para>
        /// </summary>
        public BatteryLevel BatteryLevel
        {
            get { return this._batteryLevel; }
            set { this._batteryLevel = value; }
        }

        // Check to see if BatteryLevel property is set
        internal bool IsSetBatteryLevel()
        {
            return this._batteryLevel != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceState. 
        /// <para>
        /// Device state defines the device status of sidewalk device.
        /// </para>
        /// </summary>
        public DeviceState DeviceState
        {
            get { return this._deviceState; }
            set { this._deviceState = value; }
        }

        // Check to see if DeviceState property is set
        internal bool IsSetDeviceState()
        {
            return this._deviceState != null;
        }

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// Sidewalk device status notification.
        /// </para>
        /// </summary>
        public Event Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property Rssi. 
        /// <para>
        /// The RSSI value.
        /// </para>
        /// </summary>
        public int? Rssi
        {
            get { return this._rssi; }
            set { this._rssi = value; }
        }

        // Check to see if Rssi property is set
        internal bool IsSetRssi()
        {
            return this._rssi.HasValue; 
        }

    }
}