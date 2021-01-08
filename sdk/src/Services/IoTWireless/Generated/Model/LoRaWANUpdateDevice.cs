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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// LoRaWAN object for update functions.
    /// </summary>
    public partial class LoRaWANUpdateDevice
    {
        private string _deviceProfileId;
        private string _serviceProfileId;

        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// The ID of the device profile for the wireless device.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DeviceProfileId
        {
            get { return this._deviceProfileId; }
            set { this._deviceProfileId = value; }
        }

        // Check to see if DeviceProfileId property is set
        internal bool IsSetDeviceProfileId()
        {
            return this._deviceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceProfileId. 
        /// <para>
        /// The ID of the service profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ServiceProfileId
        {
            get { return this._serviceProfileId; }
            set { this._serviceProfileId = value; }
        }

        // Check to see if ServiceProfileId property is set
        internal bool IsSetServiceProfileId()
        {
            return this._serviceProfileId != null;
        }

    }
}