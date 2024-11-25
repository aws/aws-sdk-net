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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Configures your DataSync task to run on a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/task-scheduling.html">schedule</a>
    /// (at a minimum interval of 1 hour).
    /// </summary>
    public partial class TaskSchedule
    {
        private string _scheduleExpression;
        private ScheduleStatus _status;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// Specifies your task schedule by using a cron or rate expression.
        /// </para>
        ///  
        /// <para>
        /// Use cron expressions for task schedules that run on a specific time and day. For example,
        /// the following cron expression creates a task schedule that runs at 8 AM on the first
        /// Wednesday of every month:
        /// </para>
        ///  
        /// <para>
        ///  <c>cron(0 8 * * 3#1)</c> 
        /// </para>
        ///  
        /// <para>
        /// Use rate expressions for task schedules that run on a regular interval. For example,
        /// the following rate expression creates a task schedule that runs every 12 hours:
        /// </para>
        ///  
        /// <para>
        ///  <c>rate(12 hours)</c> 
        /// </para>
        ///  
        /// <para>
        /// For information about cron and rate expression syntax, see the <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-scheduled-rule-pattern.html">
        /// <i>Amazon EventBridge User Guide</i> </a>.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether to enable or disable your task schedule. Your schedule is enabled
        /// by default, but there can be situations where you need to disable it. For example,
        /// you might need to pause a recurring transfer to fix an issue with your task or perform
        /// maintenance on your storage system.
        /// </para>
        ///  
        /// <para>
        /// DataSync might disable your schedule automatically if your task fails repeatedly with
        /// the same error. For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/API_TaskScheduleDetails.html">TaskScheduleDetails</a>.
        /// </para>
        /// </summary>
        public ScheduleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}