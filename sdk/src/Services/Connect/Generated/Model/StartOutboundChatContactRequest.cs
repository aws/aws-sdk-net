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
    /// Container for the parameters to the StartOutboundChatContact operation.
    /// Initiates a new outbound SMS contact to a customer. Response of this API provides
    /// the <c>ContactId</c> of the outbound SMS contact created.
    /// 
    ///  
    /// <para>
    ///  <b>SourceEndpoint</b> only supports Endpoints with <c>CONNECT_PHONENUMBER_ARN</c>
    /// as Type and <b>DestinationEndpoint</b> only supports Endpoints with <c>TELEPHONE_NUMBER</c>
    /// as Type. <b>ContactFlowId</b> initiates the flow to manage the new SMS contact created.
    /// </para>
    ///  
    /// <para>
    /// This API can be used to initiate outbound SMS contacts for an agent, or it can also
    /// deflect an ongoing contact to an outbound SMS contact by using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartOutboundChatContact.html">StartOutboundChatContact</a>
    /// Flow Action.
    /// </para>
    ///  
    /// <para>
    /// For more information about using SMS in Amazon Connect, see the following topics in
    /// the <i>Amazon Connect Administrator Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-sms-messaging.html">Set
    /// up SMS messaging</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/connect/latest/adminguide/sms-number.html">Request
    /// an SMS-enabled phone number through AWS End User Messaging SMS</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartOutboundChatContactRequest : AmazonConnectRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _chatDurationInMinutes;
        private string _clientToken;
        private string _contactFlowId;
        private Endpoint _destinationEndpoint;
        private ChatMessage _initialSystemMessage;
        private string _instanceId;
        private ParticipantDetails _participantDetails;
        private string _relatedContactId;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private Endpoint _sourceEndpoint;
        private List<string> _supportedMessagingContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A custom key-value pair using an attribute map. The attributes are standard Amazon
        /// Connect attributes, and can be accessed in flows just like any other contact attributes.
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
        /// the request. If not provided, the AWS SDK populates this field. For more information
        /// about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>. The token is valid for 7 days after creation.
        /// If a contact is already started, the contact ID is returned.
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
        /// The identifier of the flow for the call. To see the ContactFlowId in the Amazon Connect
        /// console user interface, on the navigation menu go to <b>Routing, Contact Flows</b>.
        /// Choose the flow. On the flow page, under the name of the flow, choose <b>Show additional
        /// flow information</b>. The ContactFlowId is the last part of the ARN, shown here in
        /// bold:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// arn:aws:connect:us-west-2:xxxxxxxxxxxx:instance/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/contact-flow/<b>123ec456-a007-89c0-1234-xxxxxxxxxxxx</b>
        /// 
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property DestinationEndpoint.
        /// </summary>
        [AWSProperty(Required=true)]
        public Endpoint DestinationEndpoint
        {
            get { return this._destinationEndpoint; }
            set { this._destinationEndpoint = value; }
        }

        // Check to see if DestinationEndpoint property is set
        internal bool IsSetDestinationEndpoint()
        {
            return this._destinationEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property InitialSystemMessage.
        /// </summary>
        public ChatMessage InitialSystemMessage
        {
            get { return this._initialSystemMessage; }
            set { this._initialSystemMessage = value; }
        }

        // Check to see if InitialSystemMessage property is set
        internal bool IsSetInitialSystemMessage()
        {
            return this._initialSystemMessage != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance.
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
        /// </summary>
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
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The unique identifier for an Amazon Connect contact. This identifier is related to
        /// the contact starting.
        /// </para>
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
        ///  <ul> <li> 
        /// <para>
        /// Attribute keys can include only alphanumeric, <c>-</c>, and <c>_</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This field can be used to show channel subtype, such as <c>connect:Guide</c> and <c>connect:SMS</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SourceEndpoint.
        /// </summary>
        [AWSProperty(Required=true)]
        public Endpoint SourceEndpoint
        {
            get { return this._sourceEndpoint; }
            set { this._sourceEndpoint = value; }
        }

        // Check to see if SourceEndpoint property is set
        internal bool IsSetSourceEndpoint()
        {
            return this._sourceEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedMessagingContentTypes. 
        /// <para>
        /// The supported chat message content types. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>text/plain</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>text/markdown</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/json, application/vnd.amazonaws.connect.message.interactive</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>application/vnd.amazonaws.connect.message.interactive.response</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Content types must always contain <c>text/plain</c>. You can then put any other supported
        /// type in the list. For example, all the following lists are valid because they contain
        /// <c>text/plain</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>[text/plain, text/markdown, application/json]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>[text/markdown, text/plain]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>[text/plain, application/json, application/vnd.amazonaws.connect.message.interactive.response]</c>
        /// 
        /// </para>
        ///  </li> </ul>
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