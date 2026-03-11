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
 * Do not modify this file. This file is generated from the connectparticipant-2018-09-07.normal.json service model.
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
namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the CreateParticipantConnection operation.
    /// Creates the participant's connection. 
    /// 
    ///  
    /// <para>
    /// For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
    /// Connect Chat security best practices</a>. 
    /// </para>
    ///  
    /// <para>
    /// For WebRTC security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-webrtc-security">Amazon
    /// Connect WebRTC security best practices</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>ParticipantToken</c> is used for invoking this API instead of <c>ConnectionToken</c>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The participant token is valid for the lifetime of the participant – until they are
    /// part of a contact. For WebRTC participants, if they leave or are disconnected for
    /// 60 seconds, a new participant needs to be created using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_CreateParticipant.html">CreateParticipant</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    ///  <b>For <c>WEBSOCKET</c> Type</b>: 
    /// </para>
    ///  
    /// <para>
    /// The response URL for has a connect expiry timeout of 100s. Clients must manually connect
    /// to the returned websocket URL and subscribe to the desired topic. 
    /// </para>
    ///  
    /// <para>
    /// For chat, you need to publish the following on the established websocket connection:
    /// </para>
    ///  
    /// <para>
    ///  <c>{"topic":"aws/subscribe","content":{"topics":["aws/chat"]}}</c> 
    /// </para>
    ///  
    /// <para>
    /// Upon websocket URL expiry, as specified in the response ConnectionExpiry parameter,
    /// clients need to call this API again to obtain a new websocket URL and perform the
    /// same steps as before.
    /// </para>
    ///  
    /// <para>
    /// The expiry time for the connection token is different than the <c>ChatDurationInMinutes</c>.
    /// Expiry time for the connection token is 1 day.
    /// </para>
    ///  
    /// <para>
    ///  <b>For <c>WEBRTC_CONNECTION</c> Type</b>: 
    /// </para>
    ///  
    /// <para>
    /// The response includes connection data required for the client application to join
    /// the call using the Amazon Chime SDK client libraries. The WebRTCConnection response
    /// contains Meeting and Attendee information needed to establish the media connection.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The attendee join token in WebRTCConnection response is valid for the lifetime of
    /// the participant in the call. If a participant leaves or is disconnected for 60 seconds,
    /// their participant credentials will no longer be valid, and a new participant will
    /// need to be created to rejoin the call. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Message streaming support</b>: This API can also be used together with the <a
    /// href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartContactStreaming.html">StartContactStreaming</a>
    /// API to create a participant connection for chat contacts that are not using a websocket.
    /// For more information about message streaming, <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-message-streaming.html">Enable
    /// real-time chat message streaming</a> in the <i>Amazon Connect Administrator Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Multi-user web, in-app, video calling support</b>: 
    /// </para>
    ///  
    /// <para>
    /// For WebRTC calls, this API is used in conjunction with the CreateParticipant API to
    /// enable multi-party calling. The StartWebRTCContact API creates the initial contact
    /// and routes it to an agent, while CreateParticipant adds additional participants to
    /// the ongoing call. For more information about multi-party WebRTC calls, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-multiuser-inapp.html">Enable
    /// multi-user web, in-app, and video calling</a> in the <i>Amazon Connect Administrator
    /// Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Feature specifications</b>: For information about feature specifications, such
    /// as the allowed number of open websocket connections per participant or maximum number
    /// of WebRTC participants, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html#feature-limits">Feature
    /// specifications</a> in the <i>Amazon Connect Administrator Guide</i>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The Amazon Connect Participant Service APIs do not use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 authentication</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateParticipantConnectionRequest : AmazonConnectParticipantRequest
    {
        private bool? _connectParticipant;
        private string _participantToken;
        private List<string> _type = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConnectParticipant. 
        /// <para>
        /// Amazon Connect Participant is used to mark the participant as connected for customer
        /// participant in message streaming, as well as for agent or manager participant in non-streaming
        /// chats.
        /// </para>
        /// </summary>
        public bool? ConnectParticipant
        {
            get { return this._connectParticipant; }
            set { this._connectParticipant = value; }
        }

        // Check to see if ConnectParticipant property is set
        internal bool IsSetConnectParticipant()
        {
            return this._connectParticipant.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// This is a header parameter.
        /// </para>
        ///  
        /// <para>
        /// The ParticipantToken as obtained from <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartChatContact.html">StartChatContact</a>
        /// API response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ParticipantToken
        {
            get { return this._participantToken; }
            set { this._participantToken = value; }
        }

        // Check to see if ParticipantToken property is set
        internal bool IsSetParticipantToken()
        {
            return this._participantToken != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of connection information required. If you need <c>CONNECTION_CREDENTIALS</c>
        /// along with marking participant as connected, pass <c>CONNECTION_CREDENTIALS</c> in
        /// <c>Type</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null && (this._type.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}