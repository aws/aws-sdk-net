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
    /// Container for the parameters to the CreateScheduledQuery operation.
    /// Creates a scheduled query that runs CloudWatch Logs Insights queries at regular intervals.
    /// Scheduled queries enable proactive monitoring by automatically executing queries to
    /// detect patterns and anomalies in your log data. Query results can be delivered to
    /// Amazon S3 for analysis or further processing.
    /// </summary>
    public partial class CreateScheduledQueryRequest : AmazonCloudWatchLogsRequest
    {
        private string _description;
        private DestinationConfiguration _destinationConfiguration;
        private string _executionRoleArn;
        private List<string> _logGroupIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private QueryLanguage _queryLanguage;
        private string _queryString;
        private long? _scheduleEndTime;
        private string _scheduleExpression;
        private long? _scheduleStartTime;
        private long? _startTimeOffset;
        private ScheduledQueryState _state;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timezone;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the scheduled query to help identify its purpose and functionality.
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
        /// Configuration for where to deliver query results. Currently supports Amazon S3 destinations
        /// for storing query output.
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
        /// The ARN of the IAM role that grants permissions to execute the query and deliver results
        /// to the specified destination. The role must have permissions to read from the specified
        /// log groups and write to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array of log group names or ARNs to query. You can specify between 1 and 50 log
        /// groups. Log groups can be identified by name or full ARN.
        /// </para>
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
        /// The name of the scheduled query. The name must be unique within your account and region.
        /// Valid characters are alphanumeric characters, hyphens, underscores, and periods. Length
        /// must be between 1 and 255 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The query language to use for the scheduled query. Valid values are <c>LogsQL</c>,
        /// <c>PPL</c>, and <c>SQL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The query string to execute. This is the same query syntax used in CloudWatch Logs
        /// Insights. Maximum length is 10,000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
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
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        /// The end time for the scheduled query in Unix epoch format. The query will stop executing
        /// after this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ScheduleEndTime
        {
            get { return this._scheduleEndTime.GetValueOrDefault(); }
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
        /// A cron expression that defines when the scheduled query runs. The expression uses
        /// standard cron syntax and supports minute-level precision. Maximum length is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// The start time for the scheduled query in Unix epoch format. The query will not execute
        /// before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long ScheduleStartTime
        {
            get { return this._scheduleStartTime.GetValueOrDefault(); }
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
        /// The time offset in seconds that defines the lookback period for the query. This determines
        /// how far back in time the query searches from the execution time.
        /// </para>
        /// </summary>
        public long StartTimeOffset
        {
            get { return this._startTimeOffset.GetValueOrDefault(); }
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
        /// The initial state of the scheduled query. Valid values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// Default is <c>ENABLED</c>.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the scheduled query for resource management and
        /// cost allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone for evaluating the schedule expression. This determines when the scheduled
        /// query executes relative to the specified timezone.
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