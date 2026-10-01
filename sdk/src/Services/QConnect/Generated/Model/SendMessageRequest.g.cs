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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessage operation. Submits a message to the
    /// Amazon Q in Connect session.
    /// </summary>
    public partial class SendMessageRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AiAgentId. 
        /// <para>
        /// The identifier of the AI Agent to use for processing the message.
        /// </para>
        /// </summary>
        public string AiAgentId { get; set; }

        /// <summary>
        /// Checks to see if the AiAgentId property is set.
        /// </summary>
        internal bool IsSetAiAgentId() => this.AiAgentId != null;

        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the AWS SDK populates this field.For more information
        /// about idempotency, see Making retries safe with idempotent APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_amazon-q-connect_SendMessage.html">SendMessage</a>
        /// request.
        /// </para>
        /// </summary>
        public MessageConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property ConversationContext. 
        /// <para>
        /// The conversation context before the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        public ConversationContext ConversationContext { get; set; }

        /// <summary>
        /// Checks to see if the ConversationContext property is set.
        /// </summary>
        internal bool IsSetConversationContext() => this.ConversationContext != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message data to submit to the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageInput Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Additional metadata for the message.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null && (this.Metadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrchestratorUseCase. 
        /// <para>
        /// The orchestrator use case for message processing.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string OrchestratorUseCase { get; set; }

        /// <summary>
        /// Checks to see if the OrchestratorUseCase property is set.
        /// </summary>
        internal bool IsSetOrchestratorUseCase() => this.OrchestratorUseCase != null;

        /// <summary>
        /// Gets and sets the property OriginRequestId. 
        /// <para>
        /// Request identifier from the origin system, used for end-to-end tracing across spans.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OriginRequestId { get; set; }

        /// <summary>
        /// Checks to see if the OriginRequestId property is set.
        /// </summary>
        internal bool IsSetOriginRequestId() => this.OriginRequestId != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The message type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MessageType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
