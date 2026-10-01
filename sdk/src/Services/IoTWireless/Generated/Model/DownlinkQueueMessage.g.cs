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
    /// The message in the downlink queue.
    /// </summary>
    public partial class DownlinkQueueMessage
    {
        /// <summary>
        /// Gets and sets the property LoRaWAN.
        /// </summary>
        public LoRaWANSendDataToDevice LoRaWAN { get; set; }

        /// <summary>
        /// Checks to see if the LoRaWAN property is set.
        /// </summary>
        internal bool IsSetLoRaWAN() => this.LoRaWAN != null;

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        ///  The message ID assigned by IoT Wireless to each downlink message, which helps identify
        /// the message.
        /// </para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property ReceivedAt. 
        /// <para>
        /// The time at which Iot Wireless received the downlink message.
        /// </para>
        /// </summary>
        public string ReceivedAt { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedAt property is set.
        /// </summary>
        internal bool IsSetReceivedAt() => this.ReceivedAt != null;

        /// <summary>
        /// Gets and sets the property TransmitMode. 
        /// <para>
        /// The transmit mode to use for sending data to the wireless device. This can be <c>0</c>
        /// for UM (unacknowledge mode) or <c>1</c> for AM (acknowledge mode).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public int? TransmitMode { get; set; }

        /// <summary>
        /// Checks to see if the TransmitMode property is set.
        /// </summary>
        internal bool IsSetTransmitMode() => this.TransmitMode.HasValue;
    }
}
