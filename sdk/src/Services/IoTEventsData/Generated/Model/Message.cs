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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Information about a message.
    /// </summary>
    public partial class Message
    {
        private string _inputName;
        private string _messageId;
        private MemoryStream _payload;

        /// <summary>
        /// Gets and sets the property InputName. 
        /// <para>
        /// The name of the input into which the message payload is transformed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string InputName
        {
            get { return this._inputName; }
            set { this._inputName = value; }
        }

        // Check to see if InputName property is set
        internal bool IsSetInputName()
        {
            return this._inputName != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The ID to assign to the message. Within each batch sent, each <code>"messageId"</code>
        /// must be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Payload. 
        /// <para>
        /// The payload of the message. This can be a JSON string or a Base-64-encoded string
        /// representing binary data (in which case you must decode it).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

    }
}