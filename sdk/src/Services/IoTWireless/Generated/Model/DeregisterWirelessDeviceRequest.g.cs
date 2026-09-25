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
    /// Container for the parameters to the DeregisterWirelessDevice operation. Deregister
    /// a wireless device from AWS IoT Wireless.
    /// </summary>
    public partial class DeregisterWirelessDeviceRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the wireless device to deregister from AWS IoT Wireless.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// The type of wireless device to deregister from AWS IoT Wireless, which can be <c>LoRaWAN</c>
        /// or <c>Sidewalk</c>.
        /// </para>
        /// </summary>
        public WirelessDeviceType WirelessDeviceType { get; set; }

        /// <summary>
        /// Checks to see if the WirelessDeviceType property is set.
        /// </summary>
        internal bool IsSetWirelessDeviceType() => this.WirelessDeviceType != null;
    }
}
