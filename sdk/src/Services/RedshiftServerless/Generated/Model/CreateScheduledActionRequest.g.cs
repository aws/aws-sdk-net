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
    /// Container for the parameters to the CreateScheduledAction operation. Creates a scheduled
    /// action. A scheduled action contains a schedule and an Amazon Redshift API action.
    /// For example, you can create a schedule of when to run the <c>CreateSnapshot</c> API
    /// operation.
    /// </summary>
    public partial class CreateScheduledActionRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Indicates whether the schedule is enabled. If false, the scheduled action does not
        /// trigger. For more information about <c>state</c> of the scheduled action, see <a href="https://docs.aws.amazon.com/redshift-serverless/latest/APIReference/API_ScheduledAction.html">ScheduledAction</a>.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time in UTC when the schedule is no longer active. After this time, the scheduled
        /// action does not trigger.
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
        /// The name of the namespace for which to create a scheduled action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true, Min = 3, Max = 60)]
        public string ScheduledActionName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionName property is set.
        /// </summary>
        internal bool IsSetScheduledActionName() => this.ScheduledActionName != null;

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
        /// Gets and sets the property TargetAction.
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetAction TargetAction { get; set; }

        /// <summary>
        /// Checks to see if the TargetAction property is set.
        /// </summary>
        internal bool IsSetTargetAction() => this.TargetAction != null;
    }
}
