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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Summary information about a scheduled query, including basic configuration and execution
    /// status.
    /// </summary>
    public partial class ScheduledQuerySummary
    {
        private long? _creationTime;
        private DestinationConfiguration _destinationConfiguration;
        private ExecutionStatus _lastExecutionStatus;
        private long? _lastTriggeredTime;
        private long? _lastUpdatedTime;
        private string _name;
        private string _scheduledQueryArn;
        private string _scheduleExpression;
        private ScheduledQueryState _state;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the scheduled query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long CreationTime
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
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// Configuration for where query results are delivered.
        /// </para>
        /// </summary>
        public DestinationConfiguration DestinationConfiguration
        {
            get { return this._destinationConfiguration; }
            set { this._destinationConfiguration = value; }
        }

        // Check to see if DestinationConfiguration property is set
        internal bool IsSetDestinationConfiguration()
        {
            return this._destinationConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionStatus. 
        /// <para>
        /// The status of the most recent execution.
        /// </para>
        /// </summary>
        public ExecutionStatus LastExecutionStatus
        {
            get { return this._lastExecutionStatus; }
            set { this._lastExecutionStatus = value; }
        }

        // Check to see if LastExecutionStatus property is set
        internal bool IsSetLastExecutionStatus()
        {
            return this._lastExecutionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastTriggeredTime. 
        /// <para>
        /// The timestamp when the scheduled query was last executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LastTriggeredTime
        {
            get { return this._lastTriggeredTime.GetValueOrDefault(); }
            set { this._lastTriggeredTime = value; }
        }

        // Check to see if LastTriggeredTime property is set
        internal bool IsSetLastTriggeredTime()
        {
            return this._lastTriggeredTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the scheduled query was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ScheduledQueryArn. 
        /// <para>
        /// The ARN of the scheduled query.
        /// </para>
        /// </summary>
        public string ScheduledQueryArn
        {
            get { return this._scheduledQueryArn; }
            set { this._scheduledQueryArn = value; }
        }

        // Check to see if ScheduledQueryArn property is set
        internal bool IsSetScheduledQueryArn()
        {
            return this._scheduledQueryArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron expression that defines when the scheduled query runs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the scheduled query.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone used for evaluating the schedule expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Timezone
        {
            get { return this._timezone; }
            set { this._timezone = value; }
        }

        // Check to see if Timezone property is set
        internal bool IsSetTimezone()
        {
            return this._timezone != null;
        }

    }
}