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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The returned scheduled action object.
    /// </summary>
    public partial class ScheduledActionResponse
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The end time in UTC when the schedule is no longer active. After this time, the scheduled
        /// action does not trigger.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property NextInvocations. 
        /// <para>
        /// An array of timestamps of when the next scheduled actions will trigger.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> NextInvocations { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the NextInvocations property is set.
        /// </summary>
        internal bool IsSetNextInvocations() => this.NextInvocations != null && (this.NextInvocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role to assume to run the scheduled action. This IAM role must
        /// have permission to run the Amazon Redshift Serverless API operation in the scheduled
        /// action. This IAM role must allow the Amazon Redshift scheduler to schedule creating
        /// snapshots. (Principal scheduler.redshift.amazonaws.com) to assume permissions on your
        /// behalf. For more information about the IAM role to use with the Amazon Redshift scheduler,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html">Using
        /// Identity-Based Policies for Amazon Redshift</a> in the Amazon Redshift Management
        /// Guide
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule for a one-time (at timestamp format) or recurring (cron format) scheduled
        /// action. Schedule invocations must be separated by at least one hour. Times are in
        /// UTC.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Format of at timestamp is <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2016-03-04T17:27:00</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Format of cron expression is <c>(Minutes Hours Day-of-month Month Day-of-week Year)</c>.
        /// For example, <c>"(0 10 ? * MON *)"</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html#CronExpressions">Cron
        /// Expressions</a> in the <i>Amazon CloudWatch Events User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionDescription. 
        /// <para>
        /// The description of the scheduled action.
        /// </para>
        /// </summary>
        public string ScheduledActionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionDescription property is set.
        /// </summary>
        internal bool IsSetScheduledActionDescription() => this.ScheduledActionDescription != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 60)]
        public string ScheduledActionName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionName property is set.
        /// </summary>
        internal bool IsSetScheduledActionName() => this.ScheduledActionName != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionUuid. 
        /// <para>
        /// The uuid of the scheduled action.
        /// </para>
        /// </summary>
        public string ScheduledActionUuid { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionUuid property is set.
        /// </summary>
        internal bool IsSetScheduledActionUuid() => this.ScheduledActionUuid != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time in UTC when the schedule is active. Before this time, the scheduled
        /// action does not trigger.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the scheduled action.
        /// </para>
        /// </summary>
        public State State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TargetAction.
        /// </summary>
        public TargetAction TargetAction { get; set; }

        /// <summary>
        /// Checks to see if the TargetAction property is set.
        /// </summary>
        internal bool IsSetTargetAction() => this.TargetAction != null;
    }
}
