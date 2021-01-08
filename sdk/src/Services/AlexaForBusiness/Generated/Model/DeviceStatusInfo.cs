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
    /// Detailed information about a device's status.
    /// </summary>
    public partial class DeviceStatusInfo
    {
        private ConnectionStatus _connectionStatus;
        private DateTime? _connectionStatusUpdatedTime;
        private List<DeviceStatusDetail> _deviceStatusDetails = new List<DeviceStatusDetail>();

        /// <summary>
        /// Gets and sets the property ConnectionStatus. 
        /// <para>
        /// The latest available information about the connection status of a device. 
        /// </para>
        /// </summary>
        public ConnectionStatus ConnectionStatus
        {
            get { return this._connectionStatus; }
            set { this._connectionStatus = value; }
        }

        // Check to see if ConnectionStatus property is set
        internal bool IsSetConnectionStatus()
        {
            return this._connectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionStatusUpdatedTime. 
        /// <para>
        /// The time (in epoch) when the device connection status changed.
        /// </para>
        /// </summary>
        public DateTime ConnectionStatusUpdatedTime
        {
            get { return this._connectionStatusUpdatedTime.GetValueOrDefault(); }
            set { this._connectionStatusUpdatedTime = value; }
        }

        // Check to see if ConnectionStatusUpdatedTime property is set
        internal bool IsSetConnectionStatusUpdatedTime()
        {
            return this._connectionStatusUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceStatusDetails. 
        /// <para>
        /// One or more device status detail descriptions.
        /// </para>
        /// </summary>
        public List<DeviceStatusDetail> DeviceStatusDetails
        {
            get { return this._deviceStatusDetails; }
            set { this._deviceStatusDetails = value; }
        }

        // Check to see if DeviceStatusDetails property is set
        internal bool IsSetDeviceStatusDetails()
        {
            return this._deviceStatusDetails != null && this._deviceStatusDetails.Count > 0; 
        }

    }
}