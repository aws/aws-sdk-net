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
    /// Information about the maintenance window.
    /// </summary>
    public partial class MaintenanceWindowIdentity
    {
        private int? _cutoff;
        private string _description;
        private int? _duration;
        private bool? _enabled;
        private string _endDate;
        private string _name;
        private string _nextExecutionTime;
        private string _schedule;
        private int? _scheduleOffset;
        private string _scheduleTimezone;
        private string _startDate;
        private string _windowId;

        /// <summary>
        /// Gets and sets the property Cutoff. 
        /// <para>
        /// The number of hours before the end of the maintenance window that Systems Manager
        /// stops scheduling new tasks for execution.
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
        /// A description of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Indicates whether the maintenance window is enabled.
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
        /// The date and time, in ISO-8601 Extended format, for when the maintenance window is
        /// scheduled to become inactive.
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
        /// Gets and sets the property NextExecutionTime. 
        /// <para>
        /// The next time the maintenance window will actually run, taking into account any specified
        /// times for the maintenance window to become active or inactive.
        /// </para>
        /// </summary>
        public string NextExecutionTime
        {
            get { return this._nextExecutionTime; }
            set { this._nextExecutionTime = value; }
        }

        // Check to see if NextExecutionTime property is set
        internal bool IsSetNextExecutionTime()
        {
            return this._nextExecutionTime != null;
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
        /// The number of days to wait to run a maintenance window after the scheduled CRON expression
        /// date and time.
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
        /// Assigned Numbers Authority (IANA) format.
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
        /// The date and time, in ISO-8601 Extended format, for when the maintenance window is
        /// scheduled to become active.
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
        /// The ID of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
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