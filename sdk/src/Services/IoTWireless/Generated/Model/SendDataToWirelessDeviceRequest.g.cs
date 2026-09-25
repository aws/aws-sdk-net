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
    /// Container for the parameters to the SendDataToWirelessDevice operation. Sends a decrypted
    /// application data frame to a device.
    /// </summary>
    public partial class SendDataToWirelessDeviceRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the wireless device to receive the data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PayloadData.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string PayloadData { get; set; }

        /// <summary>
        /// Checks to see if the PayloadData property is set.
        /// </summary>
        internal bool IsSetPayloadData() => this.PayloadData != null;

        /// <summary>
        /// Gets and sets the property TransmitMode. 
        /// <para>
        /// The transmit mode to use to send data to the wireless device. Can be: <c>0</c> for
        /// UM (unacknowledge mode) or <c>1</c> for AM (acknowledge mode).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1)]
        public int? TransmitMode { get; set; }

        /// <summary>
        /// Checks to see if the TransmitMode property is set.
        /// </summary>
        internal bool IsSetTransmitMode() => this.TransmitMode.HasValue;

        /// <summary>
        /// Gets and sets the property WirelessMetadata. 
        /// <para>
        /// Metadata about the message request.
        /// </para>
        /// </summary>
        public WirelessMetadata WirelessMetadata { get; set; }

        /// <summary>
        /// Checks to see if the WirelessMetadata property is set.
        /// </summary>
        internal bool IsSetWirelessMetadata() => this.WirelessMetadata != null;
    }
}
