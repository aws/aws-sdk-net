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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Details of the input device.
    /// </summary>
    public partial class InputDeviceSummary
    {
        private string _arn;
        private InputDeviceConnectionState _connectionState;
        private DeviceSettingsSyncState _deviceSettingsSyncState;
        private DeviceUpdateStatus _deviceUpdateStatus;
        private InputDeviceHdSettings _hdDeviceSettings;
        private string _id;
        private string _macAddress;
        private string _name;
        private InputDeviceNetworkSettings _networkSettings;
        private string _serialNumber;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private InputDeviceType _type;
        private InputDeviceUhdSettings _uhdDeviceSettings;

        /// <summary>
        /// Gets and sets the property Arn. The unique ARN of the input device.
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState. The state of the connection between the
        /// input device and AWS.
        /// </summary>
        public InputDeviceConnectionState ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceSettingsSyncState. The status of the action to synchronize
        /// the device configuration. If you change the configuration of the input device (for
        /// example, the maximum bitrate), MediaLive sends the new data to the device. The device
        /// might not update itself immediately. SYNCED means the device has updated its configuration.
        /// SYNCING means that it has not updated its configuration.
        /// </summary>
        public DeviceSettingsSyncState DeviceSettingsSyncState
        {
            get { return this._deviceSettingsSyncState; }
            set { this._deviceSettingsSyncState = value; }
        }

        // Check to see if DeviceSettingsSyncState property is set
        internal bool IsSetDeviceSettingsSyncState()
        {
            return this._deviceSettingsSyncState != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceUpdateStatus. The status of software on the input
        /// device.
        /// </summary>
        public DeviceUpdateStatus DeviceUpdateStatus
        {
            get { return this._deviceUpdateStatus; }
            set { this._deviceUpdateStatus = value; }
        }

        // Check to see if DeviceUpdateStatus property is set
        internal bool IsSetDeviceUpdateStatus()
        {
            return this._deviceUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property HdDeviceSettings. Settings that describe an input device
        /// that is type HD.
        /// </summary>
        public InputDeviceHdSettings HdDeviceSettings
        {
            get { return this._hdDeviceSettings; }
            set { this._hdDeviceSettings = value; }
        }

        // Check to see if HdDeviceSettings property is set
        internal bool IsSetHdDeviceSettings()
        {
            return this._hdDeviceSettings != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The unique ID of the input device.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property MacAddress. The network MAC address of the input device.
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
        /// Gets and sets the property Name. A name that you specify for the input device.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkSettings. Network settings for the input device.
        /// </summary>
        public InputDeviceNetworkSettings NetworkSettings
        {
            get { return this._networkSettings; }
            set { this._networkSettings = value; }
        }

        // Check to see if NetworkSettings property is set
        internal bool IsSetNetworkSettings()
        {
            return this._networkSettings != null;
        }

        /// <summary>
        /// Gets and sets the property SerialNumber. The unique serial number of the input device.
        /// </summary>
        public string SerialNumber
        {
            get { return this._serialNumber; }
            set { this._serialNumber = value; }
        }

        // Check to see if SerialNumber property is set
        internal bool IsSetSerialNumber()
        {
            return this._serialNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. The type of the input device.
        /// </summary>
        public InputDeviceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UhdDeviceSettings. Settings that describe an input device
        /// that is type UHD.
        /// </summary>
        public InputDeviceUhdSettings UhdDeviceSettings
        {
            get { return this._uhdDeviceSettings; }
            set { this._uhdDeviceSettings = value; }
        }

        // Check to see if UhdDeviceSettings property is set
        internal bool IsSetUhdDeviceSettings()
        {
            return this._uhdDeviceSettings != null;
        }

    }
}