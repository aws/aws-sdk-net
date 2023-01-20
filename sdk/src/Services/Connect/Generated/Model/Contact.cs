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
        private DateTime? _lastUpdateTimestamp;
        private string _name;
        private string _previousContactId;
        private QueueInfo _queueInfo;
        private string _relatedContactId;
        private DateTime? _scheduledTimestamp;

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
        [AWSProperty(Min=0, Max=4096)]
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
        /// The date and time this contact was initiated, in UTC time. For <code>INBOUND</code>,
        /// this is when the contact arrived. For <code>OUTBOUND</code>, this is when the agent
        /// began dialing. For <code>CALLBACK</code>, this is when the callback contact was created.
        /// For <code>TRANSFER</code> and <code>QUEUE_TRANSFER</code>, this is when the transfer
        /// was initiated. For <code>API</code>, this is when the request arrived.
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
        [AWSProperty(Min=0, Max=512)]
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

    }
}