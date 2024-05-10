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
    /// The message in the downlink queue.
    /// </summary>
    public partial class DownlinkQueueMessage
    {
        private LoRaWANSendDataToDevice _loRaWAN;
        private string _messageId;
        private string _receivedAt;
        private int? _transmitMode;

        /// <summary>
        /// Gets and sets the property LoRaWAN.
        /// </summary>
        public LoRaWANSendDataToDevice LoRaWAN
        {
            get { return this._loRaWAN; }
            set { this._loRaWAN = value; }
        }

        // Check to see if LoRaWAN property is set
        internal bool IsSetLoRaWAN()
        {
            return this._loRaWAN != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        ///  The message ID assigned by IoT Wireless to each downlink message, which helps identify
        /// the message.
        /// </para>
        /// </summary>
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

        /// <summary>
        /// Gets and sets the property ReceivedAt. 
        /// <para>
        /// The time at which Iot Wireless received the downlink message.
        /// </para>
        /// </summary>
        public string ReceivedAt
        {
            get { return this._receivedAt; }
            set { this._receivedAt = value; }
        }

        // Check to see if ReceivedAt property is set
        internal bool IsSetReceivedAt()
        {
            return this._receivedAt != null;
        }

        /// <summary>
        /// Gets and sets the property TransmitMode. 
        /// <para>
        /// The transmit mode to use for sending data to the wireless device. This can be <c>0</c>
        /// for UM (unacknowledge mode) or <c>1</c> for AM (acknowledge mode).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public int? TransmitMode
        {
            get { return this._transmitMode; }
            set { this._transmitMode = value; }
        }

        // Check to see if TransmitMode property is set
        internal bool IsSetTransmitMode()
        {
            return this._transmitMode.HasValue; 
        }

    }
}