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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about a contact.
    /// </summary>
    public partial class Contact
    {
        private AgentInfo _agentInfo;
        private string _arn;
        private Channel _channel;
        private string _description;
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
        private QueueInfo _queueInfo;
        private long? _queuePriority;
        private int? _queueTimeAdjustmentSeconds;
        private string _relatedContactId;
        private DateTime? _scheduledTimestamp;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _totalPauseCount;
        private int? _totalPauseDurationInSeconds;
        private WisdomInfo _wisdomInfo;

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
        /// Gets and sets the property DisconnectTimestamp. 
        /// <para>
        /// The timestamp when the customer endpoint disconnected from Amazon Connect.
        /// </para>
        /// </summary>
        public DateTime DisconnectTimestamp
        {
            get { return this._disconnectTimestamp.GetValueOrDefault(); }
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
        public DateTime InitiationTimestamp
        {
            get { return this._initiationTimestamp.GetValueOrDefault(); }
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
        public DateTime LastPausedTimestamp
        {
            get { return this._lastPausedTimestamp.GetValueOrDefault(); }
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
        public DateTime LastResumedTimestamp
        {
            get { return this._lastResumedTimestamp.GetValueOrDefault(); }
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
        public DateTime LastUpdateTimestamp
        {
            get { return this._lastUpdateTimestamp.GetValueOrDefault(); }
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
        [AWSProperty(Sensitive=true, Min=0, Max=512)]
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
        public long QueuePriority
        {
            get { return this._queuePriority.GetValueOrDefault(); }
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
        public int QueueTimeAdjustmentSeconds
        {
            get { return this._queueTimeAdjustmentSeconds.GetValueOrDefault(); }
            set { this._queueTimeAdjustmentSeconds = value; }
        }

        // Check to see if QueueTimeAdjustmentSeconds property is set
        internal bool IsSetQueueTimeAdjustmentSeconds()
        {
            return this._queueTimeAdjustmentSeconds.HasValue; 
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
        /// Gets and sets the property ScheduledTimestamp. 
        /// <para>
        /// The timestamp, in Unix epoch time format, at which to start running the inbound flow.
        /// 
        /// </para>
        /// </summary>
        public DateTime ScheduledTimestamp
        {
            get { return this._scheduledTimestamp.GetValueOrDefault(); }
            set { this._scheduledTimestamp = value; }
        }

        // Check to see if ScheduledTimestamp property is set
        internal bool IsSetScheduledTimestamp()
        {
            return this._scheduledTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the contact. This contains both Amazon Web Services generated
        /// and user-defined tags.
        /// </para>
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
        public int TotalPauseCount
        {
            get { return this._totalPauseCount.GetValueOrDefault(); }
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
        public int TotalPauseDurationInSeconds
        {
            get { return this._totalPauseDurationInSeconds.GetValueOrDefault(); }
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