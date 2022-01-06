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
    /// Container for the parameters to the DeleteQueuedMessages operation.
    /// The operation to delete queued messages.
    /// </summary>
    public partial class DeleteQueuedMessagesRequest : AmazonIoTWirelessRequest
    {
        private string _id;
        private string _messageId;
        private WirelessDeviceType _wirelessDeviceType;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Id of a given wireless device which messages will be deleted 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property MessageId. 
        /// <para>
        /// if messageID=="*", the queue for a particular wireless deviceId will be purged, otherwise,
        /// the specific message with messageId will be deleted 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// The wireless device type, it is either Sidewalk or LoRaWAN. 
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