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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// Container for the parameters to the StartAssistantContact operation.
    /// Starts a chat contact with an AI agent.
    /// 
    ///  
    /// <para>
    /// Use the returned <c>ParticipantToken</c> to call the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
    /// API.
    /// </para>
    ///  
    /// <para>
    /// For more information about chat, see the following topics in the <i>Connect Customer
    /// Administrator Guide</i>: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/web-and-mobile-chat.html">Concepts:
    /// Web and mobile messaging capabilities in Connect Customer</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartAssistantContactRequest : AmazonConnectRequest
    {
        private AiAgentInput _aiAgent;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _clientToken;
        private ChatMessage _initialMessage;
        private string _instanceId;
        private ParticipantDetails _participantDetails;
        private PersistentChat _persistentChat;
        private string _relatedContactId;

        /// <summary>
        /// Gets and sets the property AiAgent. 
        /// <para>
        /// The AI agent that participates in the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AiAgentInput AiAgent
        {
            get { return this._aiAgent; }
            set { this._aiAgent = value; }
        }

        // Check to see if AiAgent property is set
        internal bool IsSetAiAgent()
        {
            return this._aiAgent != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of key-value pairs to associate with the contact. Amazon Connect makes these
        /// attributes available to flows as standard contact attributes.
        /// </para>
        ///  
        /// <para>
        /// You can provide up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can contain only alphanumeric characters, dashes, and underscores.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InitialMessage. 
        /// <para>
        /// The initial message to send to the newly created chat.
        /// </para>
        /// </summary>
        public ChatMessage InitialMessage
        {
            get { return this._initialMessage; }
            set { this._initialMessage = value; }
        }

        // Check to see if InitialMessage property is set
        internal bool IsSetInitialMessage()
        {
            return this._initialMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ParticipantDetails. 
        /// <para>
        /// The display name and other details that identify the chat participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ParticipantDetails ParticipantDetails
        {
            get { return this._participantDetails; }
            set { this._participantDetails = value; }
        }

        // Check to see if ParticipantDetails property is set
        internal bool IsSetParticipantDetails()
        {
            return this._participantDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PersistentChat. 
        /// <para>
        /// The configuration that enables persistent chat. For more information about persistent
        /// chat and its use cases, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>.
        /// </para>
        /// </summary>
        public PersistentChat PersistentChat
        {
            get { return this._persistentChat; }
            set { this._persistentChat = value; }
        }

        // Check to see if PersistentChat property is set
        internal bool IsSetPersistentChat()
        {
            return this._persistentChat != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The identifier of an Connect Customer contact related to the new assistant contact.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot provide both <c>RelatedContactId</c> and <c>PersistentChat</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string RelatedContactId
        {
            get { return this._relatedContactId; }
            set { this._relatedContactId = value; }
        }

        // Check to see if RelatedContactId property is set
        internal bool IsSetRelatedContactId()
        {
            return this._relatedContactId != null;
        }

    }
}