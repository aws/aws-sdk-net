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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The record of the incident that's created when an incident occurs.
    /// </summary>
    public partial class IncidentRecord
    {
        private string _arn;
        private List<AutomationExecution> _automationExecutions = new List<AutomationExecution>();
        private ChatChannel _chatChannel;
        private DateTime? _creationTime;
        private string _dedupeString;
        private int? _impact;
        private IncidentRecordSource _incidentRecordSource;
        private string _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private List<NotificationTargetItem> _notificationTargets = new List<NotificationTargetItem>();
        private DateTime? _resolvedTime;
        private IncidentRecordStatus _status;
        private string _summary;
        private string _title;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the incident record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
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
        /// Gets and sets the property AutomationExecutions. 
        /// <para>
        /// The runbook, or automation document, that's run at the beginning of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<AutomationExecution> AutomationExecutions
        {
            get { return this._automationExecutions; }
            set { this._automationExecutions = value; }
        }

        // Check to see if AutomationExecutions property is set
        internal bool IsSetAutomationExecutions()
        {
            return this._automationExecutions != null && this._automationExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChatChannel. 
        /// <para>
        /// The chat channel used for collaboration during an incident.
        /// </para>
        /// </summary>
        public ChatChannel ChatChannel
        {
            get { return this._chatChannel; }
            set { this._chatChannel = value; }
        }

        // Check to see if ChatChannel property is set
        internal bool IsSetChatChannel()
        {
            return this._chatChannel != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that Incident Manager created the incident record.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DedupeString. 
        /// <para>
        /// The string Incident Manager uses to prevent duplicate incidents from being created
        /// by the same incident in the same account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string DedupeString
        {
            get { return this._dedupeString; }
            set { this._dedupeString = value; }
        }

        // Check to see if DedupeString property is set
        internal bool IsSetDedupeString()
        {
            return this._dedupeString != null;
        }

        /// <summary>
        /// Gets and sets the property Impact. 
        /// <para>
        /// The impact of the incident on customers and applications.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public int Impact
        {
            get { return this._impact.GetValueOrDefault(); }
            set { this._impact = value; }
        }

        // Check to see if Impact property is set
        internal bool IsSetImpact()
        {
            return this._impact.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncidentRecordSource. 
        /// <para>
        /// Details about the action that started the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentRecordSource IncidentRecordSource
        {
            get { return this._incidentRecordSource; }
            set { this._incidentRecordSource = value; }
        }

        // Check to see if IncidentRecordSource property is set
        internal bool IsSetIncidentRecordSource()
        {
            return this._incidentRecordSource != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who modified the incident most recently.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public string LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time at which the incident was most recently modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationTargets. 
        /// <para>
        /// The Amazon SNS targets that are notified when updates are made to an incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<NotificationTargetItem> NotificationTargets
        {
            get { return this._notificationTargets; }
            set { this._notificationTargets = value; }
        }

        // Check to see if NotificationTargets property is set
        internal bool IsSetNotificationTargets()
        {
            return this._notificationTargets != null && this._notificationTargets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResolvedTime. 
        /// <para>
        /// The time at which the incident was resolved. This appears as a timeline event.
        /// </para>
        /// </summary>
        public DateTime ResolvedTime
        {
            get { return this._resolvedTime.GetValueOrDefault(); }
            set { this._resolvedTime = value; }
        }

        // Check to see if ResolvedTime property is set
        internal bool IsSetResolvedTime()
        {
            return this._resolvedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IncidentRecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The summary of the incident. The summary is a brief synopsis of what occurred, what's
        /// currently happening, and context of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8000)]
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the incident.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}