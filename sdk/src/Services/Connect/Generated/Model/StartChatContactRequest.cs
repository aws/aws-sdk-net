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
    /// Container for the parameters to the StartChatContact operation.
    /// Initiates a flow to start a new chat for the customer. Response of this API provides
    /// a token required to obtain credentials from the <a href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
    /// API in the Amazon Connect Participant Service.
    /// 
    ///  
    /// <para>
    /// When a new chat contact is successfully created, clients must subscribe to the participant’s
    /// connection for the created chat within 5 minutes. This is achieved by invoking <a
    /// href="https://docs.aws.amazon.com/connect-participant/latest/APIReference/API_CreateParticipantConnection.html">CreateParticipantConnection</a>
    /// with WEBSOCKET and CONNECTION_CREDENTIALS. 
    /// </para>
    ///  
    /// <para>
    /// A 429 error occurs in the following situations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// API rate limit is exceeded. API TPS throttling returns a <c>TooManyRequests</c> exception.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-service-limits.html">quota
    /// for concurrent active chats</a> is exceeded. Active chat throttling returns a <c>LimitExceededException</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you use the <c>ChatDurationInMinutes</c> parameter and receive a 400 error, your
    /// account may not support the ability to configure custom chat durations. For more information,
    /// contact Amazon Web Services Support. 
    /// </para>
    ///  
    /// <para>
    /// For more information about chat, see the following topics in the <i>Amazon Connect
    /// Administrator Guide</i>: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/web-and-mobile-chat.html">Concepts:
    /// Web and mobile messaging capabilities in Amazon Connect</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Amazon
    /// Connect Chat security best practices</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartChatContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _chatDurationInMinutes;
        private string _clientToken;
        private string _contactFlowId;
        private string _customerId;
        private ChatMessage _initialMessage;
        private string _instanceId;
        private ParticipantDetails _participantDetails;
        private PersistentChat _persistentChat;
        private string _relatedContactId;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private List<string> _supportedMessagingContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A custom key-value pair using an attribute map. The attributes are standard Amazon
        /// Connect attributes. They can be accessed in flows just like any other contact attributes.
        /// 
        /// </para>
        ///  
        /// <para>
        /// There can be up to 32,768 UTF-8 bytes across all key-value pairs per contact. Attribute
        /// keys can include only alphanumeric, dash, and underscore characters.
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
        /// Gets and sets the property ChatDurationInMinutes. 
        /// <para>
        /// The total duration of the newly started chat session. If not specified, the chat session
        /// duration defaults to 25 hour. The minimum configurable time is 60 minutes. The maximum
        /// configurable time is 10,080 minutes (7 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=10080)]
        public int? ChatDurationInMinutes
        {
            get { return this._chatDurationInMinutes; }
            set { this._chatDurationInMinutes = value; }
        }

        // Check to see if ChatDurationInMinutes property is set
        internal bool IsSetChatDurationInMinutes()
        {
            return this._chatDurationInMinutes.HasValue; 
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
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow for initiating the chat. To see the ContactFlowId in the
        /// Amazon Connect admin website, on the navigation menu go to <b>Routing</b>, <b>Flows</b>.
        /// Choose the flow. On the flow page, under the name of the flow, choose <b>Show additional
        /// flow information</b>. The ContactFlowId is the last part of the ARN, shown here in
        /// bold: 
        /// </para>
        ///  
        /// <para>
        /// arn:aws:connect:us-west-2:xxxxxxxxxxxx:instance/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/contact-flow/<b>846ec553-a005-41c0-8341-xxxxxxxxxxxx</b>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=500)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The customer's identification number. For example, the <c>CustomerId</c> may be a
        /// customer number from your CRM.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }

        // Check to see if CustomerId property is set
        internal bool IsSetCustomerId()
        {
            return this._customerId != null;
        }

        /// <summary>
        /// Gets and sets the property InitialMessage. 
        /// <para>
        /// The initial message to be sent to the newly created chat.
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
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
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
        /// Information identifying the participant.
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
        /// Enable persistent chats. For more information about enabling persistent chat, and
        /// for example use cases and how to configure for them, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html">Enable
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
        /// The unique identifier for an Amazon Connect contact. This identifier is related to
        /// the chat starting.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot provide data for both RelatedContactId and PersistentChat. 
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

        /// <summary>
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments using
        /// an attribute map. The attributes are standard Amazon Connect attributes. They can
        /// be accessed in flows.
        /// </para>
        ///  
        /// <para>
        /// Attribute keys can include only alphanumeric, -, and _.
        /// </para>
        ///  
        /// <para>
        /// This field can be used to show channel subtype, such as <c>connect:Guide</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The types <c>application/vnd.amazonaws.connect.message.interactive</c> and <c>application/vnd.amazonaws.connect.message.interactive.response</c>
        /// must be present in the SupportedMessagingContentTypes field of this API in order to
        /// set <c>SegmentAttributes</c> as {<c> "connect:Subtype": {"valueString" : "connect:Guide"
        /// }}</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> SegmentAttributes
        {
            get { return this._segmentAttributes; }
            set { this._segmentAttributes = value; }
        }

        // Check to see if SegmentAttributes property is set
        internal bool IsSetSegmentAttributes()
        {
            return this._segmentAttributes != null && (this._segmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SupportedMessagingContentTypes. 
        /// <para>
        /// The supported chat message content types. Supported types are <c>text/plain</c>, <c>text/markdown</c>,
        /// <c>application/json</c>, <c>application/vnd.amazonaws.connect.message.interactive</c>,
        /// and <c>application/vnd.amazonaws.connect.message.interactive.response</c>. 
        /// </para>
        ///  
        /// <para>
        /// Content types must always contain <c>text/plain</c>. You can then put any other supported
        /// type in the list. For example, all the following lists are valid because they contain
        /// <c>text/plain</c>: <c>[text/plain, text/markdown, application/json]</c>, <c>[text/markdown,
        /// text/plain]</c>, <c>[text/plain, application/json, application/vnd.amazonaws.connect.message.interactive.response]</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// The type <c>application/vnd.amazonaws.connect.message.interactive</c> is required
        /// to use the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/show-view-block.html">Show
        /// view</a> flow block.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedMessagingContentTypes
        {
            get { return this._supportedMessagingContentTypes; }
            set { this._supportedMessagingContentTypes = value; }
        }

        // Check to see if SupportedMessagingContentTypes property is set
        internal bool IsSetSupportedMessagingContentTypes()
        {
            return this._supportedMessagingContentTypes != null && (this._supportedMessagingContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}