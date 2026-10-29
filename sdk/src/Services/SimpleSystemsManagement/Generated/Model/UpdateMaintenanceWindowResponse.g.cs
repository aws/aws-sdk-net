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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the UpdateMaintenanceWindow operation.
    /// </summary>
    public partial class UpdateMaintenanceWindowResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowUnassociatedTargets. 
        /// <para>
        /// Whether targets must be registered with the maintenance window before tasks can be
        /// defined for those targets.
        /// </para>
        /// </summary>
        public bool? AllowUnassociatedTargets { get; set; }

        /// <summary>
        /// Checks to see if the AllowUnassociatedTargets property is set.
        /// </summary>
        internal bool IsSetAllowUnassociatedTargets() => this.AllowUnassociatedTargets.HasValue;

        /// <summary>
        /// Gets and sets the property Cutoff. 
        /// <para>
        /// The number of hours before the end of the maintenance window that Amazon Web Services
        /// Systems Manager stops scheduling new tasks for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 23)]
        public int? Cutoff { get; set; }

        /// <summary>
        /// Checks to see if the Cutoff property is set.
        /// </summary>
        internal bool IsSetCutoff() => this.Cutoff.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the update.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the maintenance window in hours.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 24)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether the maintenance window is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, for when the maintenance window is
        /// scheduled to become inactive. The maintenance window won't run after this specified
        /// time.
        /// </para>
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// Checks to see if the EndDate property is set.
        /// </summary>
        internal bool IsSetEndDate() => this.EndDate != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule of the maintenance window in the form of a cron or rate expression.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ScheduleOffset. 
        /// <para>
        /// The number of days to wait to run a maintenance window after the scheduled cron expression
        /// date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 6)]
        public int? ScheduleOffset { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleOffset property is set.
        /// </summary>
        internal bool IsSetScheduleOffset() => this.ScheduleOffset.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduleTimezone. 
        /// <para>
        /// The time zone that the scheduled maintenance window executions are based on, in Internet
        /// Assigned Numbers Authority (IANA) format. For example: "America/Los_Angeles", "UTC",
        /// or "Asia/Seoul". For more information, see the <a href="https://www.iana.org/time-zones">Time
        /// Zone Database</a> on the IANA website.
        /// </para>
        /// </summary>
        public string ScheduleTimezone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleTimezone property is set.
        /// </summary>
        internal bool IsSetScheduleTimezone() => this.ScheduleTimezone != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, for when the maintenance window is
        /// scheduled to become active. The maintenance window won't run before this specified
        /// time.
        /// </para>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the created maintenance window.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 20)]
        public string WindowId { get; set; }

        /// <summary>
        /// Checks to see if the WindowId property is set.
        /// </summary>
        internal bool IsSetWindowId() => this.WindowId != null;
    }
}
