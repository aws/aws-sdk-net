/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the UpdateMaintenanceWindow operation.
    /// </summary>
    public partial class UpdateMaintenanceWindowResponse : AmazonWebServiceResponse
    {
        private bool? _allowUnassociatedTargets;
        private int? _cutoff;
        private string _description;
        private int? _duration;
        private bool? _enabled;
        private string _endDate;
        private string _name;
        private string _schedule;
        private string _scheduleTimezone;
        private string _startDate;
        private string _windowId;

        /// <summary>
        /// Gets and sets the property AllowUnassociatedTargets. 
        /// <para>
        /// Whether targets must be registered with the Maintenance Window before tasks can be
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
        /// The number of hours before the end of the Maintenance Window that Systems Manager
        /// stops scheduling new tasks for execution.
        /// </para>
        /// </summary>
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
        /// An optional description of the update.
        /// </para>
        /// </summary>
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
        /// The duration of the Maintenance Window in hours.
        /// </para>
        /// </summary>
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
        /// Whether the Maintenance Window is enabled.
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
        /// The date and time, in ISO-8601 Extended format, for when the Maintenance Window is
        /// scheduled to become inactive. The Maintenance Window will not run after this specified
        /// time.
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
        /// The name of the Maintenance Window.
        /// </para>
        /// </summary>
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
        /// The schedule of the Maintenance Window in the form of a cron or rate expression.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ScheduleTimezone. 
        /// <para>
        /// The time zone that the scheduled Maintenance Window executions are based on, in Internet
        /// Assigned Numbers Authority (IANA) format. For example: "America/Los_Angeles", "etc/UTC",
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
        /// The date and time, in ISO-8601 Extended format, for when the Maintenance Window is
        /// scheduled to become active. The Maintenance Window will not run before this specified
        /// time.
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
        /// The ID of the created Maintenance Window.
        /// </para>
        /// </summary>
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