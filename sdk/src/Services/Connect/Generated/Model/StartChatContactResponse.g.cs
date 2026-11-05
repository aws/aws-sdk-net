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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the StartChatContact operation.
    /// </summary>
    public partial class StartChatContactResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConnectionCredentials. 
        /// <para>
        /// The connection credentials for the chat participant. Returned only when the request
        /// includes <c>CONNECTION_CREDENTIALS</c> in <c>ConnectionTypes</c>.
        /// </para>
        /// </summary>
        public ConnectionCredentials ConnectionCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionCredentials property is set.
        /// </summary>
        internal bool IsSetConnectionCredentials() => this.ConnectionCredentials != null;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of this contact within the Connect Customer instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContactId property is set.
        /// </summary>
        internal bool IsSetContactId() => this.ContactId != null;

        /// <summary>
        /// Gets and sets the property ContinuedFromContactId. 
        /// <para>
        /// The contactId from which a persistent chat session is started. This field is populated
        /// only for persistent chats.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContinuedFromContactId { get; set; }

        /// <summary>
        /// Checks to see if the ContinuedFromContactId property is set.
        /// </summary>
        internal bool IsSetContinuedFromContactId() => this.ContinuedFromContactId != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// The identifier for a chat participant. The participantId for a chat participant is
        /// the same throughout the chat lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property ParticipantToken. 
        /// <para>
        /// The token used by the chat participant to call <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>.
        /// The participant token is valid for the lifetime of a chat participant.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string ParticipantToken { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantToken property is set.
        /// </summary>
        internal bool IsSetParticipantToken() => this.ParticipantToken != null;

        /// <summary>
        /// Gets and sets the property StreamingId. 
        /// <para>
        /// The identifier of the streaming configuration enabled with the chat. Returned only
        /// when the request sets <c>ChatStreamingConfiguration</c>. Use this value to call <a
        /// href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StopContactStreaming.html">StopContactStreaming</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string StreamingId { get; set; }

        /// <summary>
        /// Checks to see if the StreamingId property is set.
        /// </summary>
        internal bool IsSetStreamingId() => this.StreamingId != null;

        /// <summary>
        /// Gets and sets the property Websocket. 
        /// <para>
        /// The websocket for the chat participant. Returned only when the request includes <c>WEBSOCKET</c>
        /// in <c>ConnectionTypes</c>.
        /// </para>
        /// </summary>
        public Websocket Websocket { get; set; }

        /// <summary>
        /// Checks to see if the Websocket property is set.
        /// </summary>
        internal bool IsSetWebsocket() => this.Websocket != null;
    }
}
