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
    /// This is the response object from the GetScheduledQuery operation.
    /// </summary>
    public partial class GetScheduledQueryResponse : AmazonWebServiceResponse
    {
        private long? _creationTime;
        private string _description;
        private DestinationConfiguration _destinationConfiguration;
        private string _executionRoleArn;
        private ExecutionStatus _lastExecutionStatus;
        private long? _lastTriggeredTime;
        private long? _lastUpdatedTime;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private QueryLanguage _queryLanguage;
        private string _queryString;
        private string _scheduledQueryArn;
        private long? _scheduleEndTime;
        private string _scheduleExpression;
        private long? _scheduleStartTime;
        private long? _startTimeOffset;
        private ScheduledQueryState _state;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the scheduled query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role used to execute the query and deliver results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionStatus. 
        /// <para>
        /// The status of the most recent execution of the scheduled query.
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
        public long? LastTriggeredTime
        {
            get { return this._lastTriggeredTime; }
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
        public long? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// The log groups queried by the scheduled query.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> LogGroupIdentifiers
        {
            get { return this._logGroupIdentifiers; }
            set { this._logGroupIdentifiers = value; }
        }

        // Check to see if LogGroupIdentifiers property is set
        internal bool IsSetLogGroupIdentifiers()
        {
            return this._logGroupIdentifiers != null && (this._logGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// The query language used by the scheduled query.
        /// </para>
        /// </summary>
        public QueryLanguage QueryLanguage
        {
            get { return this._queryLanguage; }
            set { this._queryLanguage = value; }
        }

        // Check to see if QueryLanguage property is set
        internal bool IsSetQueryLanguage()
        {
            return this._queryLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string executed by the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
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
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        /// The end time for the scheduled query in Unix epoch format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ScheduleEndTime
        {
            get { return this._scheduleEndTime; }
            set { this._scheduleEndTime = value; }
        }

        // Check to see if ScheduleEndTime property is set
        internal bool IsSetScheduleEndTime()
        {
            return this._scheduleEndTime.HasValue; 
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
        /// Gets and sets the property ScheduleStartTime. 
        /// <para>
        /// The start time for the scheduled query in Unix epoch format.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ScheduleStartTime
        {
            get { return this._scheduleStartTime; }
            set { this._scheduleStartTime = value; }
        }

        // Check to see if ScheduleStartTime property is set
        internal bool IsSetScheduleStartTime()
        {
            return this._scheduleStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// The time offset in seconds that defines the lookback period for the query.
        /// </para>
        /// </summary>
        public long? StartTimeOffset
        {
            get { return this._startTimeOffset; }
            set { this._startTimeOffset = value; }
        }

        // Check to see if StartTimeOffset property is set
        internal bool IsSetStartTimeOffset()
        {
            return this._startTimeOffset.HasValue; 
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