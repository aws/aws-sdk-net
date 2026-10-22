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

namespace Amazon.Scheduler.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSchedule operation. Creates the specified
    /// schedule.
    /// </summary>
    public partial class CreateScheduleRequest : AmazonSchedulerRequest
    {
        /// <summary>
        /// Gets and sets the property ActionAfterCompletion. 
        /// <para>
        /// Specifies the action that EventBridge Scheduler applies to the schedule after the
        /// schedule completes invoking the target.
        /// </para>
        /// </summary>
        public ActionAfterCompletion ActionAfterCompletion { get; set; }

        /// <summary>
        /// Checks to see if the ActionAfterCompletion property is set.
        /// </summary>
        internal bool IsSetActionAfterCompletion() => this.ActionAfterCompletion != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, EventBridge Scheduler uses a randomly generated
        /// token for the request to ensure idempotency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description you specify for the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date, in UTC, before which the schedule can invoke its target. Depending on the
        /// schedule's recurrence expression, invocations might stop on, or before, the <c>EndDate</c>
        /// you specify. EventBridge Scheduler ignores <c>EndDate</c> for one-time schedules.
        /// </para>
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate.HasValue;

        /// <summary>
        /// Gets and sets the property FlexibleTimeWindow. 
        /// <para>
        /// Allows you to configure a time window during which EventBridge Scheduler invokes the
        /// schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlexibleTimeWindow FlexibleTimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the FlexibleTimeWindow property is set.
        /// </summary>
        internal bool IsSetFlexibleTimeWindow() => this.FlexibleTimeWindow != null;

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the schedule group to associate with this schedule. If you omit this,
        /// the default schedule group is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string GroupName { get; set; }

        /// <summary>
        /// Checks to see if the GroupName property is set.
        /// </summary>
        internal bool IsSetGroupName() => this.GroupName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer managed KMS key that EventBridge Scheduler
        /// will use to encrypt and decrypt your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule that you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        ///  The expression that defines when the schedule runs. The following formats are supported.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>at</c> expression - <c>at(yyyy-mm-ddThh:mm:ss)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rate</c> expression - <c>rate(value unit)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cron</c> expression - <c>cron(fields)</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  You can use <c>at</c> expressions to create one-time schedules that invoke a target
        /// once, at the time and in the time zone, that you specify. You can use <c>rate</c>
        /// and <c>cron</c> expressions to create recurring schedules. Rate-based schedules are
        /// useful when you want to invoke a target at regular intervals, such as every 15 minutes
        /// or every five days. Cron-based schedules are useful when you want to invoke a target
        /// periodically at a specific time, such as at 8:00 am (UTC+0) every 1st day of the month.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A <c>cron</c> expression consists of six fields separated by white spaces: <c>(minutes
        /// hours day_of_month month day_of_week year)</c>. 
        /// </para>
        ///  
        /// <para>
        ///  A <c>rate</c> expression consists of a <i>value</i> as a positive integer, and a
        /// <i>unit</i> with the following options: <c>minute</c> | <c>minutes</c> | <c>hour</c>
        /// | <c>hours</c> | <c>day</c> | <c>days</c> 
        /// </para>
        ///  
        /// <para>
        ///  For more information and examples, see <a href="https://docs.aws.amazon.com/scheduler/latest/UserGuide/schedule-types.html">Schedule
        /// types on EventBridge Scheduler</a> in the <i>EventBridge Scheduler User Guide</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// The timezone in which the scheduling expression is evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ScheduleExpressionTimezone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpressionTimezone property is set.
        /// </summary>
        internal bool IsSetScheduleExpressionTimezone() => this.ScheduleExpressionTimezone != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date, in UTC, after which the schedule can begin invoking its target. Depending
        /// on the schedule's recurrence expression, invocations might occur on, or after, the
        /// <c>StartDate</c> you specify. EventBridge Scheduler ignores <c>StartDate</c> for one-time
        /// schedules.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Specifies whether the schedule is enabled or disabled.
        /// </para>
        /// </summary>
        public ScheduleState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The schedule's target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Target Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
