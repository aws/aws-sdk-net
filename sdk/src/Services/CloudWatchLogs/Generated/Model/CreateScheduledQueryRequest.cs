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
    /// Creates a new Scheduled Query that runs CloudWatch Logs Insights queries on a schedule
    /// and delivers results to specified destinations.
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
        /// An optional description for the scheduled query to help identify its purpose.
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
        /// Configuration for destinations where the query results will be delivered after successful
        /// execution. You can configure delivery to S3 buckets or EventBridge event buses.
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
        /// The Amazon Resource Name (ARN) of the IAM role that CloudWatch Logs will assume to
        /// execute the scheduled query and deliver results to the specified destinations.
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
        /// The log group identifiers to query. You can specify log group names or log group ARNs.
        /// If querying log groups in a source account from a monitoring account, you must specify
        /// the ARN of the log group.
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
        /// A unique name for the scheduled query within the region for an AWS account. The name
        /// can contain letters, numbers, underscores, hyphens, forward slashes, periods, and
        /// hash symbols.
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
        /// The query language to use for the scheduled query. Valid values are LogsQL (CloudWatch
        /// Logs Insights query language), PPL (OpenSearch Service Piped Processing Language),
        /// and SQL (OpenSearch Service Structured Query Language).
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
        /// The CloudWatch Logs Insights query string to execute. This is the actual query that
        /// will be run against your log data on the specified schedule.
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
        /// The end time for the query schedule in Unix epoch time (seconds since January 1, 1970,
        /// 00:00:00 UTC). If not specified, the schedule runs indefinitely.
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
        /// A cron expression that defines when the scheduled query runs. The format is cron(fields)
        /// where fields consist of six space-separated values: minutes, hours, day_of_month,
        /// month, day_of_week, year.
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
        /// The start time for the query schedule in Unix epoch time (seconds since January 1,
        /// 1970, 00:00:00 UTC). If not specified, the schedule starts immediately.
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
        /// Time offset in seconds from the execution time for the start of the query time range.
        /// This defines the lookback period for the query (for example, 3600 for the last hour).
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
        /// The initial state of the scheduled query. Valid values are ENABLED (the query will
        /// run according to its schedule) and DISABLED (the query is paused and will not run).
        /// If not provided, defaults to ENABLED.
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
        /// An optional list of key-value pairs to associate with the resource.
        /// </para>
        ///  
        /// <para>
        /// For more information about tagging, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> 
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
        /// The timezone in which the schedule expression is evaluated. If not provided, defaults
        /// to UTC.
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