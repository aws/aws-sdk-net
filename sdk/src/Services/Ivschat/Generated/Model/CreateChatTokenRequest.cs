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

namespace Amazon.Ivschat.Model
{
    /// <summary>
    /// Container for the parameters to the CreateChatToken operation.
    /// Creates an encrypted token that is used by a chat participant to establish an individual
    /// WebSocket chat connection to a room. When the token is used to connect to chat, the
    /// connection is valid for the session duration specified in the request. The token becomes
    /// invalid at the token-expiration timestamp included in the response.
    /// 
    ///  
    /// <para>
    /// Use the <code>capabilities</code> field to permit an end user to send messages or
    /// moderate a room.
    /// </para>
    ///  
    /// <para>
    /// The <code>attributes</code> field securely attaches structured data to the chat session;
    /// the data is included within each message sent by the end user and received by other
    /// participants in the room. Common use cases for attributes include passing end-user
    /// profile data like an icon, display name, colors, badges, and other display features.
    /// </para>
    ///  
    /// <para>
    /// Encryption keys are owned by Amazon IVS Chat and never used directly by your application.
    /// </para>
    /// </summary>
    public partial class CreateChatTokenRequest : AmazonIvschatRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private List<string> _capabilities = new List<string>();
        private string _roomIdentifier;
        private int? _sessionDurationInMinutes;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to encode into the token and attach to a chat session.
        /// Map keys and values can contain UTF-8 encoded text. The maximum length of this field
        /// is 1 KB total.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Capabilities. 
        /// <para>
        /// Set of capabilities that the user is allowed to perform in the room. Default: None
        /// (the capability to view messages is implicitly included in all requests).
        /// </para>
        /// </summary>
        public List<string> Capabilities
        {
            get { return this._capabilities; }
            set { this._capabilities = value; }
        }

        // Check to see if Capabilities property is set
        internal bool IsSetCapabilities()
        {
            return this._capabilities != null && this._capabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoomIdentifier. 
        /// <para>
        /// Identifier of the room that the client is trying to access. Currently this must be
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

        /// <summary>
        /// Gets and sets the property SessionDurationInMinutes. 
        /// <para>
        /// Session duration (in minutes), after which the session expires. Default: 60 (1 hour).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=180)]
        public int SessionDurationInMinutes
        {
            get { return this._sessionDurationInMinutes.GetValueOrDefault(); }
            set { this._sessionDurationInMinutes = value; }
        }

        // Check to see if SessionDurationInMinutes property is set
        internal bool IsSetSessionDurationInMinutes()
        {
            return this._sessionDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Application-provided ID that uniquely identifies the user associated with this token.
        /// This can be any UTF-8 encoded text.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}