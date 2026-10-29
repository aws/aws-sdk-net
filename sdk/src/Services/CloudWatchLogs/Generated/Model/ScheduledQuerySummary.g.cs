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
    /// Summary information about a scheduled query, including basic configuration and execution
    /// status.
    /// </summary>
    public partial class ScheduledQuerySummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the scheduled query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationConfiguration. 
        /// <para>
        /// Configuration for where query results are delivered.
        /// </para>
        /// </summary>
        public DestinationConfiguration DestinationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DestinationConfiguration property is set.
        /// </summary>
        internal bool IsSetDestinationConfiguration() => this.DestinationConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastExecutionStatus. 
        /// <para>
        /// The status of the most recent execution.
        /// </para>
        /// </summary>
        public ExecutionStatus LastExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionStatus property is set.
        /// </summary>
        internal bool IsSetLastExecutionStatus() => this.LastExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property LastTriggeredTime. 
        /// <para>
        /// The timestamp when the scheduled query was last executed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastTriggeredTime { get; set; }

        /// <summary>
        /// Checks to see if the LastTriggeredTime property is set.
        /// </summary>
        internal bool IsSetLastTriggeredTime() => this.LastTriggeredTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the scheduled query was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The cron expression that defines when the scheduled query runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleType. 
        /// <para>
        /// The schedule type of the scheduled query. Valid values are <c>CUSTOMER_MANAGED</c>
        /// and <c>AWS_MANAGED</c>.
        /// </para>
        /// </summary>
        public ScheduleType ScheduleType { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleType property is set.
        /// </summary>
        internal bool IsSetScheduleType() => this.ScheduleType != null;

        /// <summary>
        /// Gets and sets the property ScheduledQueryArn. 
        /// <para>
        /// The ARN of the scheduled query.
        /// </para>
        /// </summary>
        public string ScheduledQueryArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledQueryArn property is set.
        /// </summary>
        internal bool IsSetScheduledQueryArn() => this.ScheduledQueryArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the scheduled query.
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
        /// The timezone used for evaluating the schedule expression.
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
