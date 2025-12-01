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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessage operation.
    /// Submits a message to the Amazon Q in Connect session.
    /// </summary>
    public partial class SendMessageRequest : AmazonQConnectRequest
    {
        private string _aiAgentId;
        private string _assistantId;
        private string _clientToken;
        private MessageConfiguration _configuration;
        private ConversationContext _conversationContext;
        private MessageInput _message;
        private Dictionary<string, string> _metadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _orchestratorUseCase;
        private string _sessionId;
        private MessageType _type;

        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// The identifier of the AI Agent to use for processing the message.
        /// </para>
        /// </summary>
        public string AiAgentId
        {
            get { return this._aiAgentId; }
            set { this._aiAgentId = value; }
        }

        // Check to see if AiAgentId property is set
        internal bool IsSetAiAgentId()
        {
            return this._aiAgentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssistantId
        {
            get { return this._assistantId; }
            set { this._assistantId = value; }
        }

        // Check to see if AssistantId property is set
        internal bool IsSetAssistantId()
        {
            return this._assistantId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the AWS SDK populates this field.For more information
        /// about idempotency, see Making retries safe with idempotent APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_amazon-q-connect_SendMessage.html">SendMessage</a>
        /// request.
        /// </para>
        /// </summary>
        public MessageConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationContext. 
        /// <para>
        /// The conversation context before the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        public ConversationContext ConversationContext
        {
            get { return this._conversationContext; }
            set { this._conversationContext = value; }
        }

        // Check to see if ConversationContext property is set
        internal bool IsSetConversationContext()
        {
            return this._conversationContext != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message data to submit to the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageInput Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional metadata for the message.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrchestratorUseCase. 
        /// <para>
        /// The orchestrator use case for message processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string OrchestratorUseCase
        {
            get { return this._orchestratorUseCase; }
            set { this._orchestratorUseCase = value; }
        }

        // Check to see if OrchestratorUseCase property is set
        internal bool IsSetOrchestratorUseCase()
        {
            return this._orchestratorUseCase != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The message type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MessageType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}