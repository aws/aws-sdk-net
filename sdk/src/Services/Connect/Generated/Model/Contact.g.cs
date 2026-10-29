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
    /// Contains information about a contact.
    /// </summary>
    public partial class Contact
    {
        /// <summary>
        /// Gets and sets the property AdditionalEmailRecipients. 
        /// <para>
        /// List of additional email addresses for an email contact.
        /// </para>
        /// </summary>
        public AdditionalEmailRecipients AdditionalEmailRecipients { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalEmailRecipients property is set.
        /// </summary>
        internal bool IsSetAdditionalEmailRecipients() => this.AdditionalEmailRecipients != null;

        /// <summary>
        /// Gets and sets the property AgentInfo. 
        /// <para>
        /// Information about the agent who accepted the contact.
        /// </para>
        /// </summary>
        public AgentInfo AgentInfo { get; set; }

        /// <summary>
        /// Checks to see if the AgentInfo property is set.
        /// </summary>
        internal bool IsSetAgentInfo() => this.AgentInfo != null;

        /// <summary>
        /// Gets and sets the property AnsweringMachineDetectionStatus. 
        /// <para>
        /// Indicates how an <a href="https://docs.aws.amazon.com/connect/latest/adminguide/how-to-create-campaigns.html">outbound
        /// campaign</a> call is actually disposed if the contact is connected to Connect Customer.
        /// </para>
        /// </summary>
        public AnsweringMachineDetectionStatus AnsweringMachineDetectionStatus { get; set; }

        /// <summary>
        /// Checks to see if the AnsweringMachineDetectionStatus property is set.
        /// </summary>
        internal bool IsSetAnsweringMachineDetectionStatus() => this.AnsweringMachineDetectionStatus != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the contact.
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
        /// Gets and sets the property Campaign.
        /// </summary>
        public Campaign Campaign { get; set; }

        /// <summary>
        /// Checks to see if the Campaign property is set.
        /// </summary>
        internal bool IsSetCampaign() => this.Campaign != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// How the contact reached your contact center.
        /// </para>
        /// </summary>
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property ChatMetrics. 
        /// <para>
        /// Information about how agent, bot, and customer interact in a chat contact.
        /// </para>
        /// </summary>
        public ChatMetrics ChatMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ChatMetrics property is set.
        /// </summary>
        internal bool IsSetChatMetrics() => this.ChatMetrics != null;

        /// <summary>
        /// Gets and sets the property ConnectedToSystemTimestamp. 
        /// <para>
        /// The timestamp when customer endpoint connected to Connect Customer.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToSystemTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedToSystemTimestamp property is set.
        /// </summary>
        internal bool IsSetConnectedToSystemTimestamp() => this.ConnectedToSystemTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ContactAssociationId. 
        /// <para>
        /// This is the root contactId which is used as a unique identifier for all subsequent
        /// contacts in a contact tree.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ContactAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ContactAssociationId property is set.
        /// </summary>
        internal bool IsSetContactAssociationId() => this.ContactAssociationId != null;

        /// <summary>
        /// Gets and sets the property ContactDetails. 
        /// <para>
        /// A map of string key/value pairs that contain user-defined attributes which are lightly
        /// typed within the contact. This object is used only for task contacts.
        /// </para>
        /// </summary>
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Checks to see if the ContactDetails property is set.
        /// </summary>
        internal bool IsSetContactDetails() => this.ContactDetails != null;

        /// <summary>
        /// Gets and sets the property ContactEvaluations. 
        /// <para>
        /// Information about the contact evaluations where the key is the FormId, which is a
        /// unique identifier for the form.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ContactEvaluation> ContactEvaluations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ContactEvaluation>() : null;

        /// <summary>
        /// Checks to see if the ContactEvaluations property is set.
        /// </summary>
        internal bool IsSetContactEvaluations() => this.ContactEvaluations != null && (this.ContactEvaluations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Information about the Customer on the contact.
        /// </para>
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Checks to see if the Customer property is set.
        /// </summary>
        internal bool IsSetCustomer() => this.Customer != null;

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The customer or external third party participant endpoint.
        /// </para>
        /// </summary>
        public EndpointInfo CustomerEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the CustomerEndpoint property is set.
        /// </summary>
        internal bool IsSetCustomerEndpoint() => this.CustomerEndpoint != null;

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The customer's identification number. For example, the <c>CustomerId</c> may be a
        /// customer number from your CRM. You can create a Lambda function to pull the unique
        /// customer ID of the caller from your CRM system. If you enable Connect Customer Voice
        /// ID capability, this attribute is populated with the <c>CustomerSpeakerId</c> of the
        /// caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerId property is set.
        /// </summary>
        internal bool IsSetCustomerId() => this.CustomerId != null;

        /// <summary>
        /// Gets and sets the property CustomerVoiceActivity. 
        /// <para>
        /// Information about customer’s voice activity.
        /// </para>
        /// </summary>
        public CustomerVoiceActivity CustomerVoiceActivity { get; set; }

        /// <summary>
        /// Checks to see if the CustomerVoiceActivity property is set.
        /// </summary>
        internal bool IsSetCustomerVoiceActivity() => this.CustomerVoiceActivity != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisconnectDetails. 
        /// <para>
        /// Information about the call disconnect experience.
        /// </para>
        /// </summary>
        public DisconnectDetails DisconnectDetails { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectDetails property is set.
        /// </summary>
        internal bool IsSetDisconnectDetails() => this.DisconnectDetails != null;

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The disconnect reason for the contact. For a list and description of all the possible
        /// disconnect reasons by channel, see DisconnectReason under <a href="https://docs.aws.amazon.com/connect/latest/adminguide/ctr-data-model.html#ctr-ContactTraceRecord">ContactTraceRecord</a>
        /// in the <i>Connect Customer Administrator Guide</i>. 
        /// </para>
        /// </summary>
        public string DisconnectReason { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectReason property is set.
        /// </summary>
        internal bool IsSetDisconnectReason() => this.DisconnectReason != null;

        /// <summary>
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The date and time that the customer endpoint disconnected from the current contact,
        /// in UTC time. In transfer scenarios, the DisconnectTimestamp of the previous contact
        /// indicates the date and time when that contact ended.
        /// </para>
        /// </summary>
        public DateTime? DisconnectTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DisconnectTimestamp property is set.
        /// </summary>
        internal bool IsSetDisconnectTimestamp() => this.DisconnectTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalResiliencyMetadata. 
        /// <para>
        /// Information about the global resiliency configuration for the contact, including traffic
        /// distribution details.
        /// </para>
        /// </summary>
        public GlobalResiliencyMetadata GlobalResiliencyMetadata { get; set; }

        /// <summary>
        /// Checks to see if the GlobalResiliencyMetadata property is set.
        /// </summary>
        internal bool IsSetGlobalResiliencyMetadata() => this.GlobalResiliencyMetadata != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// If this contact is related to other contacts, this is the ID of the initial contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string InitialContactId { get; set; }

        /// <summary>
        /// Checks to see if the InitialContactId property is set.
        /// </summary>
        internal bool IsSetInitialContactId() => this.InitialContactId != null;

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod { get; set; }

        /// <summary>
        /// Checks to see if the InitiationMethod property is set.
        /// </summary>
        internal bool IsSetInitiationMethod() => this.InitiationMethod != null;

        /// <summary>
        /// Gets and sets the property InitiationTimestamp. 
        /// <para>
        /// The date and time this contact was initiated, in UTC time. For <c>INBOUND</c>, this
        /// is when the contact arrived. For <c>OUTBOUND</c>, this is when the agent began dialing.
        /// For <c>CALLBACK</c>, this is when the callback contact was created. For <c>TRANSFER</c>
        /// and <c>QUEUE_TRANSFER</c>, this is when the transfer was initiated. For <c>API</c>,
        /// this is when the request arrived. For <c>EXTERNAL_OUTBOUND</c>, this is when the agent
        /// started dialing the external participant. For <c>MONITOR</c>, this is when the supervisor
        /// started listening to a contact.
        /// </para>
        /// </summary>
        public DateTime? InitiationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the InitiationTimestamp property is set.
        /// </summary>
        internal bool IsSetInitiationTimestamp() => this.InitiationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastPausedTimestamp. 
        /// <para>
        /// The timestamp when the contact was last paused.
        /// </para>
        /// </summary>
        public DateTime? LastPausedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastPausedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastPausedTimestamp() => this.LastPausedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastResumedTimestamp. 
        /// <para>
        /// The timestamp when the contact was last resumed.
        /// </para>
        /// </summary>
        public DateTime? LastResumedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastResumedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastResumedTimestamp() => this.LastResumedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The timestamp when contact was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextContacts. 
        /// <para>
        ///  List of next contact entries for the contact. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 24)]
        public List<NextContactEntry> NextContacts { get; set; } = AWSConfigs.InitializeCollections ? new List<NextContactEntry>() : null;

        /// <summary>
        /// Checks to see if the NextContacts property is set.
        /// </summary>
        internal bool IsSetNextContacts() => this.NextContacts != null && (this.NextContacts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OutboundStrategy. 
        /// <para>
        /// Information about the outbound strategy.
        /// </para>
        /// </summary>
        public OutboundStrategy OutboundStrategy { get; set; }

        /// <summary>
        /// Checks to see if the OutboundStrategy property is set.
        /// </summary>
        internal bool IsSetOutboundStrategy() => this.OutboundStrategy != null;

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// If this contact is not the first contact, this is the ID of the previous contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PreviousContactId { get; set; }

        /// <summary>
        /// Checks to see if the PreviousContactId property is set.
        /// </summary>
        internal bool IsSetPreviousContactId() => this.PreviousContactId != null;

        /// <summary>
        /// Gets and sets the property QualityMetrics. 
        /// <para>
        /// Information about the quality of the participant's media connection.
        /// </para>
        /// </summary>
        public QualityMetrics QualityMetrics { get; set; }

        /// <summary>
        /// Checks to see if the QualityMetrics property is set.
        /// </summary>
        internal bool IsSetQualityMetrics() => this.QualityMetrics != null;

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// If this contact was queued, this contains information about the queue. 
        /// </para>
        /// </summary>
        public QueueInfo QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property QueuePriority. 
        /// <para>
        /// An integer that represents the queue priority to be applied to the contact (lower
        /// priorities are routed preferentially). Cannot be specified if the QueueTimeAdjustmentSeconds
        /// is specified. Must be statically defined, must be larger than zero, and a valid integer
        /// value. Default Value is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 9223372036854775807)]
        public long? QueuePriority { get; set; }

        /// <summary>
        /// Checks to see if the QueuePriority property is set.
        /// </summary>
        internal bool IsSetQueuePriority() => this.QueuePriority.HasValue;

        /// <summary>
        /// Gets and sets the property QueueTimeAdjustmentSeconds. 
        /// <para>
        /// An integer that represents the queue time adjust to be applied to the contact, in
        /// seconds (longer / larger queue time are routed preferentially). Cannot be specified
        /// if the QueuePriority is specified. Must be statically defined and a valid integer
        /// value.
        /// </para>
        /// </summary>
        public int? QueueTimeAdjustmentSeconds { get; set; }

        /// <summary>
        /// Checks to see if the QueueTimeAdjustmentSeconds property is set.
        /// </summary>
        internal bool IsSetQueueTimeAdjustmentSeconds() => this.QueueTimeAdjustmentSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Recordings. 
        /// <para>
        /// If recording was enabled, this is information about the recordings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordingInfo> Recordings { get; set; } = AWSConfigs.InitializeCollections ? new List<RecordingInfo>() : null;

        /// <summary>
        /// Checks to see if the Recordings property is set.
        /// </summary>
        internal bool IsSetRecordings() => this.Recordings != null && (this.Recordings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId that is <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html#relatedcontactid">related</a>
        /// to this contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string RelatedContactId { get; set; }

        /// <summary>
        /// Checks to see if the RelatedContactId property is set.
        /// </summary>
        internal bool IsSetRelatedContactId() => this.RelatedContactId != null;

        /// <summary>
        /// Gets and sets the property RingStartTimestamp. 
        /// <para>
        /// The timestamp when ringing started for a campaign call.
        /// </para>
        /// </summary>
        public DateTime? RingStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RingStartTimestamp property is set.
        /// </summary>
        internal bool IsSetRingStartTimestamp() => this.RingStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// Latest routing criteria on the contact.
        /// </para>
        /// </summary>
        public RoutingCriteria RoutingCriteria { get; set; }

        /// <summary>
        /// Checks to see if the RoutingCriteria property is set.
        /// </summary>
        internal bool IsSetRoutingCriteria() => this.RoutingCriteria != null;

        /// <summary>
        /// Gets and sets the property ScheduledTimestamp. 
        /// <para>
        /// The timestamp, in Unix epoch time format, at which to start running the inbound flow.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ScheduledTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledTimestamp property is set.
        /// </summary>
        internal bool IsSetScheduledTimestamp() => this.ScheduledTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments using
        /// an attribute map. The attributes are standard Connect Customer attributes and can
        /// be accessed in flows. Attribute keys can include only alphanumeric, -, and _ characters.
        /// This field can be used to show channel subtype. For example, <c>connect:Guide</c>
        /// or <c>connect:SMS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, SegmentAttributeValue> SegmentAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;

        /// <summary>
        /// Checks to see if the SegmentAttributes property is set.
        /// </summary>
        internal bool IsSetSegmentAttributes() => this.SegmentAttributes != null && (this.SegmentAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// The system endpoint. For <c>INBOUND</c>, this is the phone number or email address
        /// that the customer dialed. For <c>OUTBOUND</c> and <c>EXTERNAL_OUTBOUND</c>, this is
        /// the outbound caller ID number assigned to the outbound queue that is used to dial
        /// the customer. For callback, this shows up as Softphone for calls handled by agents
        /// with softphone.
        /// </para>
        /// </summary>
        public EndpointInfo SystemEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the SystemEndpoint property is set.
        /// </summary>
        internal bool IsSetSystemEndpoint() => this.SystemEndpoint != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the contact. This contains both Amazon Web Services generated
        /// and user-defined tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskTemplateInfo. 
        /// <para>
        /// If this contact was created using a task template, this contains information about
        /// the task template.
        /// </para>
        /// </summary>
        public TaskTemplateInfoV2 TaskTemplateInfo { get; set; }

        /// <summary>
        /// Checks to see if the TaskTemplateInfo property is set.
        /// </summary>
        internal bool IsSetTaskTemplateInfo() => this.TaskTemplateInfo != null;

        /// <summary>
        /// Gets and sets the property TotalPauseCount. 
        /// <para>
        /// Total pause count for a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? TotalPauseCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalPauseCount property is set.
        /// </summary>
        internal bool IsSetTotalPauseCount() => this.TotalPauseCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalPauseDurationInSeconds. 
        /// <para>
        /// Total pause duration for a contact in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? TotalPauseDurationInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TotalPauseDurationInSeconds property is set.
        /// </summary>
        internal bool IsSetTotalPauseDurationInSeconds() => this.TotalPauseDurationInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property WisdomInfo. 
        /// <para>
        /// Information about Connect Customer Wisdom.
        /// </para>
        /// </summary>
        public WisdomInfo WisdomInfo { get; set; }

        /// <summary>
        /// Checks to see if the WisdomInfo property is set.
        /// </summary>
        internal bool IsSetWisdomInfo() => this.WisdomInfo != null;
    }
}
