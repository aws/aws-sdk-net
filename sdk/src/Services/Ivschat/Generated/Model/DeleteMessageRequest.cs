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
    /// Container for the parameters to the DeleteMessage operation.
    /// Sends an event to a specific room which directs clients to delete a specific message;
    /// that is, unrender it from view and delete it from the client’s chat history. This
    /// event’s <c>EventName</c> is <c>aws:DELETE_MESSAGE</c>. This replicates the <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-deletemessage-publish.html">
    /// DeleteMessage</a> WebSocket operation in the Amazon IVS Chat Messaging API.
    /// </summary>
    public partial class DeleteMessageRequest : AmazonIvschatRequest
    {
        private string _id;
        private string _reason;
        private string _roomIdentifier;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID of the message to be deleted. This is the <c>Id</c> field in the received message
        /// (see <a href="https://docs.aws.amazon.com/ivs/latest/chatmsgapireference/actions-message-subscribe.html">
        /// Message (Subscribe)</a> in the Chat Messaging API).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// Reason for deleting the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property RoomIdentifier. 
        /// <para>
        /// Identifier of the room where the message should be deleted. Currently this must be
        /// an ARN. 
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