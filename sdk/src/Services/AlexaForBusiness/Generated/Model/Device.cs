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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// A device with attributes.
    /// </summary>
    public partial class Device
    {
        private string _deviceArn;
        private string _deviceName;
        private string _deviceSerialNumber;
        private DeviceStatus _deviceStatus;
        private DeviceStatusInfo _deviceStatusInfo;
        private string _deviceType;
        private string _macAddress;
        private DeviceNetworkProfileInfo _networkProfileInfo;
        private string _roomArn;
        private string _softwareVersion;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of a device.
        /// </para>
        /// </summary>
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The name of a device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=100)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSerialNumber. 
        /// <para>
        /// The serial number of a device.
        /// </para>
        /// </summary>
        public string DeviceSerialNumber
        {
            get { return this._deviceSerialNumber; }
            set { this._deviceSerialNumber = value; }
        }

        // Check to see if DeviceSerialNumber property is set
        internal bool IsSetDeviceSerialNumber()
        {
            return this._deviceSerialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceStatus. 
        /// <para>
        /// The status of a device. If the status is not READY, check the DeviceStatusInfo value
        /// for details.
        /// </para>
        /// </summary>
        public DeviceStatus DeviceStatus
        {
            get { return this._deviceStatus; }
            set { this._deviceStatus = value; }
        }

        // Check to see if DeviceStatus property is set
        internal bool IsSetDeviceStatus()
        {
            return this._deviceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceStatusInfo. 
        /// <para>
        /// Detailed information about a device's status.
        /// </para>
        /// </summary>
        public DeviceStatusInfo DeviceStatusInfo
        {
            get { return this._deviceStatusInfo; }
            set { this._deviceStatusInfo = value; }
        }

        // Check to see if DeviceStatusInfo property is set
        internal bool IsSetDeviceStatusInfo()
        {
            return this._deviceStatusInfo != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceType. 
        /// <para>
        /// The type of a device.
        /// </para>
        /// </summary>
        public string DeviceType
        {
            get { return this._deviceType; }
            set { this._deviceType = value; }
        }

        // Check to see if DeviceType property is set
        internal bool IsSetDeviceType()
        {
            return this._deviceType != null;
        }

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of a device.
        /// </para>
        /// </summary>
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkProfileInfo. 
        /// <para>
        /// Detailed information about a device's network profile.
        /// </para>
        /// </summary>
        public DeviceNetworkProfileInfo NetworkProfileInfo
        {
            get { return this._networkProfileInfo; }
            set { this._networkProfileInfo = value; }
        }

        // Check to see if NetworkProfileInfo property is set
        internal bool IsSetNetworkProfileInfo()
        {
            return this._networkProfileInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RoomArn. 
        /// <para>
        /// The room ARN of a device.
        /// </para>
        /// </summary>
        public string RoomArn
        {
            get { return this._roomArn; }
            set { this._roomArn = value; }
        }

        // Check to see if RoomArn property is set
        internal bool IsSetRoomArn()
        {
            return this._roomArn != null;
        }

        /// <summary>
        /// Gets and sets the property SoftwareVersion. 
        /// <para>
        /// The software version of a device.
        /// </para>
        /// </summary>
        public string SoftwareVersion
        {
            get { return this._softwareVersion; }
            set { this._softwareVersion = value; }
        }

        // Check to see if SoftwareVersion property is set
        internal bool IsSetSoftwareVersion()
        {
            return this._softwareVersion != null;
        }

    }
}