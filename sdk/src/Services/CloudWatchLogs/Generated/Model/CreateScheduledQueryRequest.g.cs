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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the CreateScheduledQuery operation. Creates a scheduled
    /// query that runs CloudWatch Logs Insights queries at regular intervals. Scheduled queries
    /// enable proactive monitoring by automatically executing queries to detect patterns
    /// and anomalies in your log data. Query results can be delivered to Amazon S3 for analysis
    /// or further processing.
    /// </summary>
    public partial class CreateScheduledQueryRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the scheduled query to help identify its purpose and functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// Configuration for where to deliver query results. Supports Amazon S3 destinations
        /// for storing query output and lookup table destinations for automatically refreshing
        /// lookup tables with query results. You can configure one or both destination types.
        /// </para>
        /// </summary>
        public DestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property EndTimeOffset. 
        /// <para>
        /// The time offset in seconds that defines the end of the lookback period for the query.
        /// Together with <c>startTimeOffset</c>, this determines the time window relative to
        /// the execution time over which the query runs.
        /// </para>
        /// </summary>
        public long? EndTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the EndTimeOffset property is set.
        /// </summary>
        internal bool IsSetEndTimeOffset() => this.EndTimeOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The ARN of the IAM role that grants permissions to execute the query and deliver results
        /// to the specified destination. The role must have permissions to read from the specified
        /// log groups and write to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// An array of log group names or ARNs to query. You can specify between 1 and 50 log
        /// groups. Log groups can be identified by name or full ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<string> LogGroupIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LogGroupIdentifiers property is set.
        /// </summary>
        internal bool IsSetLogGroupIdentifiers() => this.LogGroupIdentifiers != null && (this.LogGroupIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled query. The name must be unique within your account and region.
        /// Length must be between 1 and 300 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// The query language to use for the scheduled query. Valid values are <c>CWLI</c>, <c>PPL</c>,
        /// and <c>SQL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryLanguage QueryLanguage { get; set; }

        /// <summary>
        /// Checks to see if the QueryLanguage property is set.
        /// </summary>
        internal bool IsSetQueryLanguage() => this.QueryLanguage != null;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to execute. This is the same query syntax used in CloudWatch Logs
        /// Insights. Maximum length is 10,000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 10000)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property ScheduleEndTime. 
        /// <para>
        /// The end time for the scheduled query in Unix epoch format. The query will stop executing
        /// after this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ScheduleEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleEndTime property is set.
        /// </summary>
        internal bool IsSetScheduleEndTime() => this.ScheduleEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A cron expression that defines when the scheduled query runs. The expression uses
        /// standard cron syntax and supports minute-level precision. Maximum length is 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleStartTime. 
        /// <para>
        /// The start time for the scheduled query in Unix epoch format. The query will not execute
        /// before this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ScheduleStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleStartTime property is set.
        /// </summary>
        internal bool IsSetScheduleStartTime() => this.ScheduleStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartTimeOffset. 
        /// <para>
        /// The time offset in seconds that defines the lookback period for the query. This determines
        /// how far back in time the query searches from the execution time.
        /// </para>
        /// </summary>
        public long? StartTimeOffset { get; set; }

        /// <summary>
        /// Checks to see if the StartTimeOffset property is set.
        /// </summary>
        internal bool IsSetStartTimeOffset() => this.StartTimeOffset.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The initial state of the scheduled query. Valid values are <c>ENABLED</c> and <c>DISABLED</c>.
        /// Default is <c>ENABLED</c>.
        /// </para>
        /// </summary>
        public ScheduledQueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs to associate with the scheduled query for resource management and
        /// cost allocation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The timezone for evaluating the schedule expression. This determines when the scheduled
        /// query executes relative to the specified timezone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;
    }
}
