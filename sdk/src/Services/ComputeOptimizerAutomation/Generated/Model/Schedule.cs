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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Configuration for scheduling when automation rules should execute, including timing
    /// and execution windows.
    /// </summary>
    public partial class Schedule
    {
        private int? _executionWindowInMinutes;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;

        /// <summary>
        /// Gets and sets the property ExecutionWindowInMinutes. 
        /// <para>
        /// The time window in minutes during which the automation rule can start implementing
        /// recommended actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=1440)]
        public int ExecutionWindowInMinutes
        {
            get { return this._executionWindowInMinutes.GetValueOrDefault(); }
            set { this._executionWindowInMinutes = value; }
        }

        // Check to see if ExecutionWindowInMinutes property is set
        internal bool IsSetExecutionWindowInMinutes()
        {
            return this._executionWindowInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// The expression that defines when the schedule runs. <c>cron</c> expression is supported.
        /// A <c>cron</c> expression consists of six fields separated by white spaces: (<c>minutes</c>
        /// <c>hours</c> <c>day_of_month</c> <c>month</c> <c>day_of_week</c> <c>year</c>)
        /// </para>
        ///  <note> 
        /// <para>
        /// You can schedule rules to run at most once per day. Your cron expression must use
        /// specific values (not wildcards) for the minutes and hours fields. For example: (<c>30
        /// 12 * * *</c>) runs daily at 12:30 PM UTC.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// The timezone to use when interpreting the schedule expression.
        /// </para>
        /// </summary>
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

    }
}