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
    /// Container for the parameters to the UpdateScheduledQuery operation. Updates an existing
    /// scheduled query with new configuration. This operation uses PUT semantics, allowing
    /// modification of query parameters, schedule, and destinations.
    /// </summary>
    public partial class UpdateScheduledQueryRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An updated description for the scheduled query.
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
        /// The updated configuration for where to deliver query results.
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
        /// The updated time offset in seconds that defines the end of the lookback period for
        /// the query.
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
        /// The updated ARN of the IAM role that grants permissions to execute the query and deliver
        /// results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ARN or name of the scheduled query to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property LogGroupIdentifiers. 
        /// <para>
        /// The updated array of log group names or ARNs to query.
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
        /// Gets and sets the property QueryLanguage. 
        /// <para>
        /// The updated query language for the scheduled query.
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
        /// The updated query string to execute.
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
        /// The updated end time for the scheduled query in Unix epoch format.
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
        /// The updated cron expression that defines when the scheduled query runs.
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
        /// The updated start time for the scheduled query in Unix epoch format.
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
        /// The updated time offset in seconds that defines the lookback period for the query.
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
        /// The updated state of the scheduled query.
        /// </para>
        /// </summary>
        public ScheduledQueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The updated timezone for evaluating the schedule expression.
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
