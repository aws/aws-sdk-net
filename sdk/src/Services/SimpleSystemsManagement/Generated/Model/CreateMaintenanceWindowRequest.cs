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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMaintenanceWindow operation.
    /// Creates a new maintenance window.
    /// 
    ///  <note> 
    /// <para>
    /// The value you specify for <code>Duration</code> determines the specific end time for
    /// the maintenance window based on the time it begins. No maintenance window tasks are
    /// permitted to start after the resulting endtime minus the number of hours you specify
    /// for <code>Cutoff</code>. For example, if the maintenance window starts at 3 PM, the
    /// duration is three hours, and the value you specify for <code>Cutoff</code> is one
    /// hour, no maintenance window tasks can start after 5 PM.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _allowUnassociatedTargets;
        private string _clientToken;
        private int? _cutoff;
        private string _description;
        private int? _duration;
        private string _endDate;
        private string _name;
        private string _schedule;
        private int? _scheduleOffset;
        private string _scheduleTimezone;
        private string _startDate;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property AllowUnassociatedTargets. 
        /// <para>
        /// Enables a maintenance window task to run on managed nodes, even if you haven't registered
        /// those nodes as targets. If enabled, then you must specify the unregistered managed
        /// nodes (by node ID) when you register a task with the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// If you don't enable this option, then you must specify previously-registered targets
        /// when you register a task with the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool AllowUnassociatedTargets
        {
            get { return this._allowUnassociatedTargets.GetValueOrDefault(); }
            set { this._allowUnassociatedTargets = value; }
        }

        // Check to see if AllowUnassociatedTargets property is set
        internal bool IsSetAllowUnassociatedTargets()
        {
            return this._allowUnassociatedTargets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
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
        /// Gets and sets the property Cutoff. 
        /// <para>
        /// The number of hours before the end of the maintenance window that Amazon Web Services
        /// Systems Manager stops scheduling new tasks for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=23)]
        public int Cutoff
        {
            get { return this._cutoff.GetValueOrDefault(); }
            set { this._cutoff = value; }
        }

        // Check to see if Cutoff property is set
        internal bool IsSetCutoff()
        {
            return this._cutoff.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the maintenance window. We recommend specifying a description
        /// to help you organize your maintenance windows. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the maintenance window in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=24)]
        public int Duration
        {
            get { return this._duration.GetValueOrDefault(); }
            set { this._duration = value; }
        }

        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this._duration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, for when you want the maintenance
        /// window to become inactive. <code>EndDate</code> allows you to set a date and time
        /// in the future when the maintenance window will no longer run.
        /// </para>
        /// </summary>
        public string EndDate
        {
            get { return this._endDate; }
            set { this._endDate = value; }
        }

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this._endDate != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the maintenance window in the form of a cron or rate expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// The number of days to wait after the date and time specified by a cron expression
        /// before running the maintenance window.
        /// </para>
        ///  
        /// <para>
        /// For example, the following cron expression schedules a maintenance window to run on
        /// the third Tuesday of every month at 11:30 PM.
        /// </para>
        ///  
        /// <para>
        ///  <code>cron(30 23 ? * TUE#3 *)</code> 
        /// </para>
        ///  
        /// <para>
        /// If the schedule offset is <code>2</code>, the maintenance window won't run until two
        /// days later.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int ScheduleOffset
        {
            get { return this._scheduleOffset.GetValueOrDefault(); }
            set { this._scheduleOffset = value; }
        }

        // Check to see if ScheduleOffset property is set
        internal bool IsSetScheduleOffset()
        {
            return this._scheduleOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleTimezone. 
        /// <para>
        /// The time zone that the scheduled maintenance window executions are based on, in Internet
        /// Assigned Numbers Authority (IANA) format. For example: "America/Los_Angeles", "UTC",
        /// or "Asia/Seoul". For more information, see the <a href="https://www.iana.org/time-zones">Time
        /// Zone Database</a> on the IANA website.
        /// </para>
        /// </summary>
        public string ScheduleTimezone
        {
            get { return this._scheduleTimezone; }
            set { this._scheduleTimezone = value; }
        }

        // Check to see if ScheduleTimezone property is set
        internal bool IsSetScheduleTimezone()
        {
            return this._scheduleTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, for when you want the maintenance
        /// window to become active. <code>StartDate</code> allows you to delay activation of
        /// the maintenance window until the specified future date.
        /// </para>
        /// </summary>
        public string StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Optional metadata that you assign to a resource. Tags enable you to categorize a resource
        /// in different ways, such as by purpose, owner, or environment. For example, you might
        /// want to tag a maintenance window to identify the type of tasks it will run, the types
        /// of targets, and the environment it will run in. In this case, you could specify the
        /// following key-value pairs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Key=TaskType,Value=AgentUpdate</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=OS,Value=Windows</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key=Environment,Value=Production</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing maintenance window, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=1000)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}