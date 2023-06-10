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
    /// Container for the parameters to the UpdateMaintenanceWindow operation.
    /// Updates an existing maintenance window. Only specified parameters are modified.
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
    public partial class UpdateMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private bool? _allowUnassociatedTargets;
        private int? _cutoff;
        private string _description;
        private int? _duration;
        private bool? _enabled;
        private string _endDate;
        private string _name;
        private bool? _replace;
        private string _schedule;
        private int? _scheduleOffset;
        private string _scheduleTimezone;
        private string _startDate;
        private string _windowId;

        /// <summary>
        /// Gets and sets the property AllowUnassociatedTargets. 
        /// <para>
        /// Whether targets must be registered with the maintenance window before tasks can be
        /// defined for those targets.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Cutoff. 
        /// <para>
        /// The number of hours before the end of the maintenance window that Amazon Web Services
        /// Systems Manager stops scheduling new tasks for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=23)]
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
        /// An optional description for the update request.
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
        [AWSProperty(Min=1, Max=24)]
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the maintenance window is enabled.
        /// </para>
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
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
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property Replace. 
        /// <para>
        /// If <code>True</code>, then all fields that are required by the <a>CreateMaintenanceWindow</a>
        /// operation are also required for this API request. Optional fields that aren't specified
        /// are set to null. 
        /// </para>
        /// </summary>
        public bool Replace
        {
            get { return this._replace.GetValueOrDefault(); }
            set { this._replace = value; }
        }

        // Check to see if Replace property is set
        internal bool IsSetReplace()
        {
            return this._replace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the maintenance window in the form of a cron or rate expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// For example, the following cron expression schedules a maintenance window to run the
        /// third Tuesday of every month at 11:30 PM.
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
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

    }
}