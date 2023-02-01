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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Structure that describes scheduled query.
    /// </summary>
    public partial class ScheduledQueryDescription
    {
        private string _arn;
        private DateTime? _creationTime;
        private ErrorReportConfiguration _errorReportConfiguration;
        private string _kmsKeyId;
        private ScheduledQueryRunSummary _lastRunSummary;
        private string _name;
        private DateTime? _nextInvocationTime;
        private NotificationConfiguration _notificationConfiguration;
        private DateTime? _previousInvocationTime;
        private string _queryString;
        private List<ScheduledQueryRunSummary> _recentlyFailedRuns = new List<ScheduledQueryRunSummary>();
        private ScheduleConfiguration _scheduleConfiguration;
        private string _scheduledQueryExecutionRoleArn;
        private ScheduledQueryState _state;
        private TargetConfiguration _targetConfiguration;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Scheduled query ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the scheduled query.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Error-reporting configuration for the scheduled query.
        /// </para>
        /// </summary>
        public ErrorReportConfiguration ErrorReportConfiguration
        {
            get { return this._errorReportConfiguration; }
            set { this._errorReportConfiguration = value; }
        }

        // Check to see if ErrorReportConfiguration property is set
        internal bool IsSetErrorReportConfiguration()
        {
            return this._errorReportConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// A customer provided KMS key used to encrypt the scheduled query resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastRunSummary. 
        /// <para>
        /// Runtime summary for the last scheduled query run. 
        /// </para>
        /// </summary>
        public ScheduledQueryRunSummary LastRunSummary
        {
            get { return this._lastRunSummary; }
            set { this._lastRunSummary = value; }
        }

        // Check to see if LastRunSummary property is set
        internal bool IsSetLastRunSummary()
        {
            return this._lastRunSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property NextInvocationTime. 
        /// <para>
        /// The next time the scheduled query is scheduled to run.
        /// </para>
        /// </summary>
        public DateTime NextInvocationTime
        {
            get { return this._nextInvocationTime.GetValueOrDefault(); }
            set { this._nextInvocationTime = value; }
        }

        // Check to see if NextInvocationTime property is set
        internal bool IsSetNextInvocationTime()
        {
            return this._nextInvocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Notification configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NotificationConfiguration NotificationConfiguration
        {
            get { return this._notificationConfiguration; }
            set { this._notificationConfiguration = value; }
        }

        // Check to see if NotificationConfiguration property is set
        internal bool IsSetNotificationConfiguration()
        {
            return this._notificationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousInvocationTime. 
        /// <para>
        /// Last time the query was run.
        /// </para>
        /// </summary>
        public DateTime PreviousInvocationTime
        {
            get { return this._previousInvocationTime.GetValueOrDefault(); }
            set { this._previousInvocationTime = value; }
        }

        // Check to see if PreviousInvocationTime property is set
        internal bool IsSetPreviousInvocationTime()
        {
            return this._previousInvocationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query to be run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=262144)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property RecentlyFailedRuns. 
        /// <para>
        /// Runtime summary for the last five failed scheduled query runs.
        /// </para>
        /// </summary>
        public List<ScheduledQueryRunSummary> RecentlyFailedRuns
        {
            get { return this._recentlyFailedRuns; }
            set { this._recentlyFailedRuns = value; }
        }

        // Check to see if RecentlyFailedRuns property is set
        internal bool IsSetRecentlyFailedRuns()
        {
            return this._recentlyFailedRuns != null && this._recentlyFailedRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// Schedule configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleConfiguration ScheduleConfiguration
        {
            get { return this._scheduleConfiguration; }
            set { this._scheduleConfiguration = value; }
        }

        // Check to see if ScheduleConfiguration property is set
        internal bool IsSetScheduleConfiguration()
        {
            return this._scheduleConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduledQueryExecutionRoleArn. 
        /// <para>
        /// IAM role that Timestream uses to run the schedule query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ScheduledQueryExecutionRoleArn
        {
            get { return this._scheduledQueryExecutionRoleArn; }
            set { this._scheduledQueryExecutionRoleArn = value; }
        }

        // Check to see if ScheduledQueryExecutionRoleArn property is set
        internal bool IsSetScheduledQueryExecutionRoleArn()
        {
            return this._scheduledQueryExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduledQueryState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Scheduled query target store configuration.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

    }
}