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
    /// Container for the parameters to the DeregisterWirelessDevice operation.
    /// Deregister a wireless device from AWS IoT Wireless.
    /// </summary>
    public partial class DeregisterWirelessDeviceRequest : AmazonIoTWirelessRequest
    {
        private string _identifier;
        private WirelessDeviceType _wirelessDeviceType;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the wireless device to deregister from AWS IoT Wireless.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// The type of wireless device to deregister from AWS IoT Wireless, which can be <code>LoRaWAN</code>
        /// or <code>Sidewalk</code>.
        /// </para>
        /// </summary>
        public WirelessDeviceType WirelessDeviceType
        {
            get { return this._wirelessDeviceType; }
            set { this._wirelessDeviceType = value; }
        }

        // Check to see if WirelessDeviceType property is set
        internal bool IsSetWirelessDeviceType()
        {
            return this._wirelessDeviceType != null;
        }

    }
}