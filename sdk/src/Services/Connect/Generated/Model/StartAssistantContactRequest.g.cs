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
    /// Container for the parameters to the StartAssistantContact operation. Starts a chat
    /// contact with an AI agent. <para> Use the returned <c>ParticipantToken</c> with the
    /// <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
    /// operation. </para> <para> For more information about chat, see the following topics
    /// in the <i>Connect Customer Administrator Guide</i>: </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/adminguide/web-and-mobile-chat.html">Concepts:
    /// Web and mobile messaging capabilities in Connect Customer</a> </para> </li> <li> <para>
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a> </para> </li> </ul>
    /// </summary>
    public partial class StartAssistantContactRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AiAgent. 
        /// <para>
        /// The AI agent configuration for this contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AiAgentInput AiAgent { get; set; }

        /// <summary>
        /// Checks to see if the AiAgent property is set.
        /// </summary>
        internal bool IsSetAiAgent() => this.AiAgent != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A map of key-value pairs to associate with the contact. We make these attributes available
        /// to flows as standard contact attributes.
        /// </para>
        ///  
        /// <para>
        /// You can provide up to 32,768 UTF-8 bytes across all key-value pairs for each contact.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InitialMessage. 
        /// <para>
        /// The initial message to send to the newly created chat.
        /// </para>
        /// </summary>
        public ChatMessage InitialMessage { get; set; }

        /// <summary>
        /// Checks to see if the InitialMessage property is set.
        /// </summary>
        internal bool IsSetInitialMessage() => this.InitialMessage != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ParticipantDetails. 
        /// <para>
        /// The display name and other details that identify the chat participant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ParticipantDetails ParticipantDetails { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantDetails property is set.
        /// </summary>
        internal bool IsSetParticipantDetails() => this.ParticipantDetails != null;

        /// <summary>
        /// Gets and sets the property PersistentChat. 
        /// <para>
        /// The configuration that enables persistent chat. For more information about persistent
        /// chat and its use cases, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
        /// persistent chat</a>.
        /// </para>
        /// </summary>
        public PersistentChat PersistentChat { get; set; }

        /// <summary>
        /// Checks to see if the PersistentChat property is set.
        /// </summary>
        internal bool IsSetPersistentChat() => this.PersistentChat != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;
    }
}
