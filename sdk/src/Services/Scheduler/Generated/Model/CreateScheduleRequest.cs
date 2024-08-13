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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
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
    /// Container for the parameters to the CreateSchedule operation.
    /// Creates the specified schedule.
    /// </summary>
    public partial class CreateScheduleRequest : AmazonSchedulerRequest
    {
        private ActionAfterCompletion _actionAfterCompletion;
        private string _clientToken;
        private string _description;
        private DateTime? _endDate;
        private FlexibleTimeWindow _flexibleTimeWindow;
        private string _groupName;
        private string _kmsKeyArn;
        private string _name;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private DateTime? _startDate;
        private ScheduleState _state;
        private Target _target;

        /// <summary>
        /// Gets and sets the property ActionAfterCompletion. 
        /// <para>
        /// Specifies the action that EventBridge Scheduler applies to the schedule after the
        /// schedule completes invoking the target.
        /// </para>
        /// </summary>
        public ActionAfterCompletion ActionAfterCompletion
        {
            get { return this._actionAfterCompletion; }
            set { this._actionAfterCompletion = value; }
        }

        // Check to see if ActionAfterCompletion property is set
        internal bool IsSetActionAfterCompletion()
        {
            return this._actionAfterCompletion != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, EventBridge Scheduler uses a randomly generated
        /// token for the request to ensure idempotency. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description you specify for the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date, in UTC, before which the schedule can invoke its target. Depending on the
        /// schedule's recurrence expression, invocations might stop on, or before, the <c>EndDate</c>
        /// you specify. EventBridge Scheduler ignores <c>EndDate</c> for one-time schedules.
        /// </para>
        /// </summary>
        public DateTime? EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FlexibleTimeWindow. 
        /// <para>
        /// Allows you to configure a time window during which EventBridge Scheduler invokes the
        /// schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlexibleTimeWindow FlexibleTimeWindow
        {
            get { return this._flexibleTimeWindow; }
            set { this._flexibleTimeWindow = value; }
        }

        // Check to see if FlexibleTimeWindow property is set
        internal bool IsSetFlexibleTimeWindow()
        {
            return this._flexibleTimeWindow != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the schedule group to associate with this schedule. If you omit this,
        /// the default schedule group is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the customer managed KMS key that EventBridge Scheduler
        /// will use to encrypt and decrypt your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the schedule that you are creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// The timezone in which the scheduling expression is evaluated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string ScheduleExpressionTimezone
        {
            get { return this._scheduleExpressionTimezone; }
            set { this._scheduleExpressionTimezone = value; }
        }

        // Check to see if ScheduleExpressionTimezone property is set
        internal bool IsSetScheduleExpressionTimezone()
        {
            return this._scheduleExpressionTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date, in UTC, after which the schedule can begin invoking its target. Depending
        /// on the schedule's recurrence expression, invocations might occur on, or after, the
        /// <c>StartDate</c> you specify. EventBridge Scheduler ignores <c>StartDate</c> for one-time
        /// schedules.
        /// </para>
        /// </summary>
        public DateTime? StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Specifies whether the schedule is enabled or disabled.
        /// </para>
        /// </summary>
        public ScheduleState State
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The schedule's target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Target Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}