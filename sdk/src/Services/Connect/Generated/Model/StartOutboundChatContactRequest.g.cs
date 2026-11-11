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
    /// Container for the parameters to the StartOutboundChatContact operation. Initiates
    /// a new outbound SMS or WhatsApp contact to a customer. Response of this API provides
    /// the <c>ContactId</c> of the outbound SMS or WhatsApp contact created. <para> <b>SourceEndpoint</b>
    /// only supports Endpoints with <c>CONNECT_PHONENUMBER_ARN</c> as Type and <b>DestinationEndpoint</b>
    /// only supports Endpoints with <c>TELEPHONE_NUMBER</c> as Type. <b>ContactFlowId</b>
    /// initiates the flow to manage the new contact created. </para> <para> This API can
    /// be used to initiate outbound SMS or WhatsApp contacts for an agent, or it can also
    /// deflect an ongoing contact to an outbound SMS or WhatsApp contact by using the <a
    /// href="https://docs.aws.amazon.com/connect/latest/APIReference/API_StartOutboundChatContact.html">StartOutboundChatContact</a>
    /// Flow Action. </para> <para> For more information about using SMS or WhatsApp in Connect
    /// Customer, see the following topics in the <i>Connect Customer Administrator Guide</i>:
    /// </para> <ul> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-sms-messaging.html">Set
    /// up SMS messaging</a> </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/adminguide/sms-number.html">Request
    /// an SMS-enabled phone number through Amazon Web Services End User Messaging SMS</a>
    /// </para> </li> <li> <para> <a href="https://docs.aws.amazon.com/connect/latest/adminguide/whatsapp-integration.html">Set
    /// up WhatsApp Business messaging</a> </para> </li> </ul>
    /// </summary>
    public partial class StartOutboundChatContactRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A custom key-value pair using an attribute map. The attributes are standard Connect
        /// Customer attributes, and can be accessed in flows just like any other contact attributes.
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
        /// Gets and sets the property ChatDurationInMinutes. 
        /// <para>
        /// The total duration of the newly started chat session. If not specified, the chat session
        /// duration defaults to 25 hour. The minimum configurable time is 60 minutes. The maximum
        /// configurable time is 10,080 minutes (7 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 10080)]
        public int? ChatDurationInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ChatDurationInMinutes property is set.
        /// </summary>
        internal bool IsSetChatDurationInMinutes() => this.ChatDurationInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>. The token is valid for 7 days after creation.
        /// If a contact is already started, the contact ID is returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow for the call. To see the ContactFlowId in the Connect Customer
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
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowId property is set.
        /// </summary>
        internal bool IsSetContactFlowId() => this.ContactFlowId != null;

        /// <summary>
        /// Gets and sets the property DestinationEndpoint.
        /// </summary>
        [AWSProperty(Required = true)]
        public Endpoint DestinationEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the DestinationEndpoint property is set.
        /// </summary>
        internal bool IsSetDestinationEndpoint() => this.DestinationEndpoint != null;

        /// <summary>
        /// Gets and sets the property InitialSystemMessage.
        /// </summary>
        public ChatMessage InitialSystemMessage { get; set; }

        /// <summary>
        /// Checks to see if the InitialSystemMessage property is set.
        /// </summary>
        internal bool IsSetInitialSystemMessage() => this.InitialSystemMessage != null;

        /// <summary>
        /// Gets and sets the property InitialTemplatedSystemMessage.
        /// </summary>
        public TemplatedMessageConfig InitialTemplatedSystemMessage { get; set; }

        /// <summary>
        /// Checks to see if the InitialTemplatedSystemMessage property is set.
        /// </summary>
        internal bool IsSetInitialTemplatedSystemMessage() => this.InitialTemplatedSystemMessage != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can find the instance ID in the
        /// Amazon Resource Name (ARN) of the instance.
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
        /// </summary>
        public ParticipantDetails ParticipantDetails { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantDetails property is set.
        /// </summary>
        internal bool IsSetParticipantDetails() => this.ParticipantDetails != null;

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The unique identifier for an Connect Customer contact. This identifier is related
        /// to the contact starting.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;

        /// <summary>
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments using
        /// an attribute map. The attributes are standard Connect Customer attributes. They can
        /// be accessed in flows.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Attribute keys can include only alphanumeric, <c>-</c>, and <c>_</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This field can be used to show channel subtype, such as <c>connect:SMS</c> and <c>connect:WhatsApp</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, SegmentAttributeValue> SegmentAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the SegmentAttributes property is set.
        /// </summary>
        internal bool IsSetSegmentAttributes() => this.SegmentAttributes != null && (this.SegmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceEndpoint.
        /// </summary>
        [AWSProperty(Required = true)]
        public Endpoint SourceEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SourceEndpoint property is set.
        /// </summary>
        internal bool IsSetSourceEndpoint() => this.SourceEndpoint != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedMessagingContentTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SupportedMessagingContentTypes property is set.
        /// </summary>
        internal bool IsSetSupportedMessagingContentTypes() => this.SupportedMessagingContentTypes != null && (this.SupportedMessagingContentTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
