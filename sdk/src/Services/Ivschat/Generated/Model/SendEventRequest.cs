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
 * Do not modify this file. This file is generated from the ivschat-2020-07-14.normal.json service model.
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
namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Container for the parameters to the SendEvent operation.
    /// Sends an event to a room. Use this within your application’s business logic to send
    /// events to clients of a room; e.g., to notify clients to change the way the chat UI
    /// is rendered.
    /// </summary>
    public partial class SendEventRequest : AmazonIvschatRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _eventName;
        private string _roomIdentifier;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-defined metadata to attach to the event sent to clients. The maximum length
        /// of the metadata is 1 KB total.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// Application-defined name of the event to send to clients.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property RoomIdentifier. 
        /// <para>
        /// Identifier of the room to which the event will be sent. Currently this must be an
        /// ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RoomIdentifier
        {
            get { return this._roomIdentifier; }
            set { this._roomIdentifier = value; }
        }

        // Check to see if RoomIdentifier property is set
        internal bool IsSetRoomIdentifier()
        {
            return this._roomIdentifier != null;
        }

    }
}