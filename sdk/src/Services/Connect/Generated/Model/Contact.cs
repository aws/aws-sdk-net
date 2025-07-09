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
    /// Contains information about a contact.
    /// </summary>
    public partial class Contact
    {
        private AdditionalEmailRecipients _additionalEmailRecipients;
        private AgentInfo _agentInfo;
        private AnsweringMachineDetectionStatus _answeringMachineDetectionStatus;
        private string _arn;
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Campaign _campaign;
        private Channel _channel;
        private ChatMetrics _chatMetrics;
        private DateTime? _connectedToSystemTimestamp;
        private string _contactAssociationId;
        private ContactDetails _contactDetails;
        private Dictionary<string, ContactEvaluation> _contactEvaluations = AWSConfigs.InitializeCollections ? new Dictionary<string, ContactEvaluation>() : null;
        private Customer _customer;
        private EndpointInfo _customerEndpoint;
        private string _customerId;
        private CustomerVoiceActivity _customerVoiceActivity;
        private string _description;
        private DisconnectDetails _disconnectDetails;
        private string _disconnectReason;
        private DateTime? _disconnectTimestamp;
        private string _id;
        private string _initialContactId;
        private ContactInitiationMethod _initiationMethod;
        private DateTime? _initiationTimestamp;
        private DateTime? _lastPausedTimestamp;
        private DateTime? _lastResumedTimestamp;
        private DateTime? _lastUpdateTimestamp;
        private string _name;
        private string _previousContactId;
        private QualityMetrics _qualityMetrics;
        private QueueInfo _queueInfo;
        private long? _queuePriority;
        private int? _queueTimeAdjustmentSeconds;
        private List<RecordingInfo> _recordings = AWSConfigs.InitializeCollections ? new List<RecordingInfo>() : null;
        private string _relatedContactId;
        private RoutingCriteria _routingCriteria;
        private DateTime? _scheduledTimestamp;
        private Dictionary<string, SegmentAttributeValue> _segmentAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, SegmentAttributeValue>() : null;
        private EndpointInfo _systemEndpoint;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _totalPauseCount;
        private int? _totalPauseDurationInSeconds;
        private WisdomInfo _wisdomInfo;

        /// <summary>
        /// Gets and sets the property AdditionalEmailRecipients. 
        /// <para>
        /// List of additional email addresses for an email contact.
        /// </para>
        /// </summary>
        public AdditionalEmailRecipients AdditionalEmailRecipients
        {
            get { return this._additionalEmailRecipients; }
            set { this._additionalEmailRecipients = value; }
        }

        // Check to see if AdditionalEmailRecipients property is set
        internal bool IsSetAdditionalEmailRecipients()
        {
            return this._additionalEmailRecipients != null;
        }

        /// <summary>
        /// Gets and sets the property AgentInfo. 
        /// <para>
        /// Information about the agent who accepted the contact.
        /// </para>
        /// </summary>
        public AgentInfo AgentInfo
        {
            get { return this._agentInfo; }
            set { this._agentInfo = value; }
        }

        // Check to see if AgentInfo property is set
        internal bool IsSetAgentInfo()
        {
            return this._agentInfo != null;
        }

        /// <summary>
        /// Gets and sets the property AnsweringMachineDetectionStatus. 
        /// <para>
        /// Indicates how an <a href="https://docs.aws.amazon.com/connect/latest/adminguide/how-to-create-campaigns.html">outbound
        /// campaign</a> call is actually disposed if the contact is connected to Amazon Connect.
        /// </para>
        /// </summary>
        public AnsweringMachineDetectionStatus AnsweringMachineDetectionStatus
        {
            get { return this._answeringMachineDetectionStatus; }
            set { this._answeringMachineDetectionStatus = value; }
        }

        // Check to see if AnsweringMachineDetectionStatus property is set
        internal bool IsSetAnsweringMachineDetectionStatus()
        {
            return this._answeringMachineDetectionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the contact.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes of the contact.
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
        /// Gets and sets the property Campaign.
        /// </summary>
        public Campaign Campaign
        {
            get { return this._campaign; }
            set { this._campaign = value; }
        }

        // Check to see if Campaign property is set
        internal bool IsSetCampaign()
        {
            return this._campaign != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// How the contact reached your contact center.
        /// </para>
        /// </summary>
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property ChatMetrics. 
        /// <para>
        /// Information about how agent, bot, and customer interact in a chat contact.
        /// </para>
        /// </summary>
        public ChatMetrics ChatMetrics
        {
            get { return this._chatMetrics; }
            set { this._chatMetrics = value; }
        }

        // Check to see if ChatMetrics property is set
        internal bool IsSetChatMetrics()
        {
            return this._chatMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedToSystemTimestamp. 
        /// <para>
        /// The timestamp when customer endpoint connected to Amazon Connect.
        /// </para>
        /// </summary>
        public DateTime? ConnectedToSystemTimestamp
        {
            get { return this._connectedToSystemTimestamp; }
            set { this._connectedToSystemTimestamp = value; }
        }

        // Check to see if ConnectedToSystemTimestamp property is set
        internal bool IsSetConnectedToSystemTimestamp()
        {
            return this._connectedToSystemTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContactAssociationId. 
        /// <para>
        /// This is the root contactId which is used as a unique identifier for all subsequent
        /// contacts in a contact tree.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ContactAssociationId
        {
            get { return this._contactAssociationId; }
            set { this._contactAssociationId = value; }
        }

        // Check to see if ContactAssociationId property is set
        internal bool IsSetContactAssociationId()
        {
            return this._contactAssociationId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactDetails. 
        /// <para>
        /// A map of string key/value pairs that contain user-defined attributes which are lightly
        /// typed within the contact. This object is used only for task contacts.
        /// </para>
        /// </summary>
        public ContactDetails ContactDetails
        {
            get { return this._contactDetails; }
            set { this._contactDetails = value; }
        }

        // Check to see if ContactDetails property is set
        internal bool IsSetContactDetails()
        {
            return this._contactDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ContactEvaluations. 
        /// <para>
        /// Information about the contact evaluations where the key is the FormId, which is a
        /// unique identifier for the form.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ContactEvaluation> ContactEvaluations
        {
            get { return this._contactEvaluations; }
            set { this._contactEvaluations = value; }
        }

        // Check to see if ContactEvaluations property is set
        internal bool IsSetContactEvaluations()
        {
            return this._contactEvaluations != null && (this._contactEvaluations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Customer. 
        /// <para>
        /// Information about the Customer on the contact.
        /// </para>
        /// </summary>
        public Customer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerEndpoint. 
        /// <para>
        /// The customer or external third party participant endpoint.
        /// </para>
        /// </summary>
        public EndpointInfo CustomerEndpoint
        {
            get { return this._customerEndpoint; }
            set { this._customerEndpoint = value; }
        }

        // Check to see if CustomerEndpoint property is set
        internal bool IsSetCustomerEndpoint()
        {
            return this._customerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerId. 
        /// <para>
        /// The customer's identification number. For example, the <c>CustomerId</c> may be a
        /// customer number from your CRM. You can create a Lambda function to pull the unique
        /// customer ID of the caller from your CRM system. If you enable Amazon Connect Voice
        /// ID capability, this attribute is populated with the <c>CustomerSpeakerId</c> of the
        /// caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property CustomerVoiceActivity. 
        /// <para>
        /// Information about customer’s voice activity.
        /// </para>
        /// </summary>
        public CustomerVoiceActivity CustomerVoiceActivity
        {
            get { return this._customerVoiceActivity; }
            set { this._customerVoiceActivity = value; }
        }

        // Check to see if CustomerVoiceActivity property is set
        internal bool IsSetCustomerVoiceActivity()
        {
            return this._customerVoiceActivity != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=4096)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectDetails. 
        /// <para>
        /// Information about the call disconnect experience.
        /// </para>
        /// </summary>
        public DisconnectDetails DisconnectDetails
        {
            get { return this._disconnectDetails; }
            set { this._disconnectDetails = value; }
        }

        // Check to see if DisconnectDetails property is set
        internal bool IsSetDisconnectDetails()
        {
            return this._disconnectDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectReason. 
        /// <para>
        /// The disconnect reason for the contact.
        /// </para>
        /// </summary>
        public string DisconnectReason
        {
            get { return this._disconnectReason; }
            set { this._disconnectReason = value; }
        }

        // Check to see if DisconnectReason property is set
        internal bool IsSetDisconnectReason()
        {
            return this._disconnectReason != null;
        }

        /// <summary>
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The date and time that the customer endpoint disconnected from the current contact,
        /// in UTC time. In transfer scenarios, the DisconnectTimestamp of the previous contact
        /// indicates the date and time when that contact ended.
        /// </para>
        /// </summary>
        public DateTime? DisconnectTimestamp
        {
            get { return this._disconnectTimestamp; }
            set { this._disconnectTimestamp = value; }
        }

        // Check to see if DisconnectTimestamp property is set
        internal bool IsSetDisconnectTimestamp()
        {
            return this._disconnectTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// If this contact is related to other contacts, this is the ID of the initial contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property InitiationMethod. 
        /// <para>
        /// Indicates how the contact was initiated.
        /// </para>
        /// </summary>
        public ContactInitiationMethod InitiationMethod
        {
            get { return this._initiationMethod; }
            set { this._initiationMethod = value; }
        }

        // Check to see if InitiationMethod property is set
        internal bool IsSetInitiationMethod()
        {
            return this._initiationMethod != null;
        }

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
        public DateTime? InitiationTimestamp
        {
            get { return this._initiationTimestamp; }
            set { this._initiationTimestamp = value; }
        }

        // Check to see if InitiationTimestamp property is set
        internal bool IsSetInitiationTimestamp()
        {
            return this._initiationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastPausedTimestamp. 
        /// <para>
        /// The timestamp when the contact was last paused.
        /// </para>
        /// </summary>
        public DateTime? LastPausedTimestamp
        {
            get { return this._lastPausedTimestamp; }
            set { this._lastPausedTimestamp = value; }
        }

        // Check to see if LastPausedTimestamp property is set
        internal bool IsSetLastPausedTimestamp()
        {
            return this._lastPausedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastResumedTimestamp. 
        /// <para>
        /// The timestamp when the contact was last resumed.
        /// </para>
        /// </summary>
        public DateTime? LastResumedTimestamp
        {
            get { return this._lastResumedTimestamp; }
            set { this._lastResumedTimestamp = value; }
        }

        // Check to see if LastResumedTimestamp property is set
        internal bool IsSetLastResumedTimestamp()
        {
            return this._lastResumedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The timestamp when contact was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp; }
            set { this._lastUpdateTimestamp = value; }
        }

        // Check to see if LastUpdateTimestamp property is set
        internal bool IsSetLastUpdateTimestamp()
        {
            return this._lastUpdateTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousContactId. 
        /// <para>
        /// If this contact is not the first contact, this is the ID of the previous contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PreviousContactId
        {
            get { return this._previousContactId; }
            set { this._previousContactId = value; }
        }

        // Check to see if PreviousContactId property is set
        internal bool IsSetPreviousContactId()
        {
            return this._previousContactId != null;
        }

        /// <summary>
        /// Gets and sets the property QualityMetrics. 
        /// <para>
        /// Information about the quality of the participant's media connection.
        /// </para>
        /// </summary>
        public QualityMetrics QualityMetrics
        {
            get { return this._qualityMetrics; }
            set { this._qualityMetrics = value; }
        }

        // Check to see if QualityMetrics property is set
        internal bool IsSetQualityMetrics()
        {
            return this._qualityMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property QueueInfo. 
        /// <para>
        /// If this contact was queued, this contains information about the queue. 
        /// </para>
        /// </summary>
        public QueueInfo QueueInfo
        {
            get { return this._queueInfo; }
            set { this._queueInfo = value; }
        }

        // Check to see if QueueInfo property is set
        internal bool IsSetQueueInfo()
        {
            return this._queueInfo != null;
        }

        /// <summary>
        /// Gets and sets the property QueuePriority. 
        /// <para>
        /// An integer that represents the queue priority to be applied to the contact (lower
        /// priorities are routed preferentially). Cannot be specified if the QueueTimeAdjustmentSeconds
        /// is specified. Must be statically defined, must be larger than zero, and a valid integer
        /// value. Default Value is 5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9223372036854775807)]
        public long? QueuePriority
        {
            get { return this._queuePriority; }
            set { this._queuePriority = value; }
        }

        // Check to see if QueuePriority property is set
        internal bool IsSetQueuePriority()
        {
            return this._queuePriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueTimeAdjustmentSeconds. 
        /// <para>
        /// An integer that represents the queue time adjust to be applied to the contact, in
        /// seconds (longer / larger queue time are routed preferentially). Cannot be specified
        /// if the QueuePriority is specified. Must be statically defined and a valid integer
        /// value.
        /// </para>
        /// </summary>
        public int? QueueTimeAdjustmentSeconds
        {
            get { return this._queueTimeAdjustmentSeconds; }
            set { this._queueTimeAdjustmentSeconds = value; }
        }

        // Check to see if QueueTimeAdjustmentSeconds property is set
        internal bool IsSetQueueTimeAdjustmentSeconds()
        {
            return this._queueTimeAdjustmentSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recordings. 
        /// <para>
        /// If recording was enabled, this is information about the recordings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RecordingInfo> Recordings
        {
            get { return this._recordings; }
            set { this._recordings = value; }
        }

        // Check to see if Recordings property is set
        internal bool IsSetRecordings()
        {
            return this._recordings != null && (this._recordings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedContactId. 
        /// <para>
        /// The contactId that is <a href="https://docs.aws.amazon.com/connect/latest/adminguide/chat-persistence.html#relatedcontactid">related</a>
        /// to this contact.
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
        /// Gets and sets the property RoutingCriteria. 
        /// <para>
        /// Latest routing criteria on the contact.
        /// </para>
        /// </summary>
        public RoutingCriteria RoutingCriteria
        {
            get { return this._routingCriteria; }
            set { this._routingCriteria = value; }
        }

        // Check to see if RoutingCriteria property is set
        internal bool IsSetRoutingCriteria()
        {
            return this._routingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledTimestamp. 
        /// <para>
        /// The timestamp, in Unix epoch time format, at which to start running the inbound flow.
        /// 
        /// </para>
        /// </summary>
        public DateTime? ScheduledTimestamp
        {
            get { return this._scheduledTimestamp; }
            set { this._scheduledTimestamp = value; }
        }

        // Check to see if ScheduledTimestamp property is set
        internal bool IsSetScheduledTimestamp()
        {
            return this._scheduledTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SegmentAttributes. 
        /// <para>
        /// A set of system defined key-value pairs stored on individual contact segments using
        /// an attribute map. The attributes are standard Amazon Connect attributes and can be
        /// accessed in flows. Attribute keys can include only alphanumeric, -, and _ characters.
        /// This field can be used to show channel subtype. For example, <c>connect:Guide</c>
        /// or <c>connect:SMS</c>.
        /// </para>
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
        /// Gets and sets the property SystemEndpoint. 
        /// <para>
        /// The system endpoint. For <c>INBOUND</c>, this is the phone number or email address
        /// that the customer dialed. For <c>OUTBOUND</c> and <c>EXTERNAL_OUTBOUND</c>, this is
        /// the outbound caller ID number assigned to the outbound queue that is used to dial
        /// the customer. For callback, this shows up as Softphone for calls handled by agents
        /// with softphone.
        /// </para>
        /// </summary>
        public EndpointInfo SystemEndpoint
        {
            get { return this._systemEndpoint; }
            set { this._systemEndpoint = value; }
        }

        // Check to see if SystemEndpoint property is set
        internal bool IsSetSystemEndpoint()
        {
            return this._systemEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the contact. This contains both Amazon Web Services generated
        /// and user-defined tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalPauseCount. 
        /// <para>
        /// Total pause count for a contact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int? TotalPauseCount
        {
            get { return this._totalPauseCount; }
            set { this._totalPauseCount = value; }
        }

        // Check to see if TotalPauseCount property is set
        internal bool IsSetTotalPauseCount()
        {
            return this._totalPauseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalPauseDurationInSeconds. 
        /// <para>
        /// Total pause duration for a contact in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TotalPauseDurationInSeconds
        {
            get { return this._totalPauseDurationInSeconds; }
            set { this._totalPauseDurationInSeconds = value; }
        }

        // Check to see if TotalPauseDurationInSeconds property is set
        internal bool IsSetTotalPauseDurationInSeconds()
        {
            return this._totalPauseDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WisdomInfo. 
        /// <para>
        /// Information about Amazon Connect Wisdom.
        /// </para>
        /// </summary>
        public WisdomInfo WisdomInfo
        {
            get { return this._wisdomInfo; }
            set { this._wisdomInfo = value; }
        }

        // Check to see if WisdomInfo property is set
        internal bool IsSetWisdomInfo()
        {
            return this._wisdomInfo != null;
        }

    }
}