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

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// Structure that describes scheduled query.
    /// </summary>
    public partial class ScheduledQueryDescription
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Scheduled query ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the scheduled query.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorReportConfiguration. 
        /// <para>
        /// Error-reporting configuration for the scheduled query.
        /// </para>
        /// </summary>
        public ErrorReportConfiguration ErrorReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReportConfiguration property is set.
        /// </summary>
        internal bool IsSetErrorReportConfiguration() => this.ErrorReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// A customer provided KMS key used to encrypt the scheduled query resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastRunSummary. 
        /// <para>
        /// Runtime summary for the last scheduled query run. 
        /// </para>
        /// </summary>
        public ScheduledQueryRunSummary LastRunSummary { get; set; }

        /// <summary>
        /// Checks to see if the LastRunSummary property is set.
        /// </summary>
        internal bool IsSetLastRunSummary() => this.LastRunSummary != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the scheduled query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextInvocationTime. 
        /// <para>
        /// The next time the scheduled query is scheduled to run.
        /// </para>
        /// </summary>
        public DateTime? NextInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the NextInvocationTime property is set.
        /// </summary>
        internal bool IsSetNextInvocationTime() => this.NextInvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. 
        /// <para>
        /// Notification configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property PreviousInvocationTime. 
        /// <para>
        /// Last time the query was run.
        /// </para>
        /// </summary>
        public DateTime? PreviousInvocationTime { get; set; }

        /// <summary>
        /// Checks to see if the PreviousInvocationTime property is set.
        /// </summary>
        internal bool IsSetPreviousInvocationTime() => this.PreviousInvocationTime.HasValue;

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query to be run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 262144)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property RecentlyFailedRuns. 
        /// <para>
        /// Runtime summary for the last five failed scheduled query runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScheduledQueryRunSummary> RecentlyFailedRuns { get; set; } = AWSConfigs.InitializeCollections ? new List<ScheduledQueryRunSummary>() : null;

        /// <summary>
        /// Checks to see if the RecentlyFailedRuns property is set.
        /// </summary>
        internal bool IsSetRecentlyFailedRuns() => this.RecentlyFailedRuns != null && (this.RecentlyFailedRuns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// Schedule configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property ScheduledQueryExecutionRoleArn. 
        /// <para>
        /// IAM role that Timestream uses to run the schedule query.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ScheduledQueryExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledQueryExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetScheduledQueryExecutionRoleArn() => this.ScheduledQueryExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the scheduled query. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduledQueryState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetConfiguration. 
        /// <para>
        /// Scheduled query target store configuration.
        /// </para>
        /// </summary>
        public TargetConfiguration TargetConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TargetConfiguration property is set.
        /// </summary>
        internal bool IsSetTargetConfiguration() => this.TargetConfiguration != null;
    }
}
