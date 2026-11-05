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
    /// Container for the parameters to the CreateMaintenanceWindow operation. Creates a new
    /// maintenance window. <note> <para> The value you specify for <c>Duration</c> determines
    /// the specific end time for the maintenance window based on the time it begins. No maintenance
    /// window tasks are permitted to start after the resulting endtime minus the number of
    /// hours you specify for <c>Cutoff</c>. For example, if the maintenance window starts
    /// at 3 PM, the duration is three hours, and the value you specify for <c>Cutoff</c>
    /// is one hour, no maintenance window tasks can start after 5 PM. </para> </note>
    /// </summary>
    public partial class CreateMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
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
        [AWSProperty(Required = true)]
        public bool? AllowUnassociatedTargets { get; set; }

        /// <summary>
        /// Checks to see if the AllowUnassociatedTargets property is set.
        /// </summary>
        internal bool IsSetAllowUnassociatedTargets() => this.AllowUnassociatedTargets.HasValue;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Cutoff. 
        /// <para>
        /// The number of hours before the end of the maintenance window that Amazon Web Services
        /// Systems Manager stops scheduling new tasks for execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 23)]
        public int? Cutoff { get; set; }

        /// <summary>
        /// Checks to see if the Cutoff property is set.
        /// </summary>
        internal bool IsSetCutoff() => this.Cutoff.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the maintenance window. We recommend specifying a description
        /// to help you organize your maintenance windows. 
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
        [AWSProperty(Required = true, Min = 1, Max = 24)]
        public int? Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration.HasValue;

        /// <summary>
        /// Gets and sets the property EndDate. 
        /// <para>
        /// The date and time, in ISO-8601 Extended format, for when you want the maintenance
        /// window to become inactive. <c>EndDate</c> allows you to set a date and time in the
        /// future when the maintenance window will no longer run.
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
        [AWSProperty(Required = true, Min = 3, Max = 128)]
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
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

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
        ///  <c>cron(30 23 ? * TUE#3 *)</c> 
        /// </para>
        ///  
        /// <para>
        /// If the schedule offset is <c>2</c>, the maintenance window won't run until two days
        /// later.
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
        /// The date and time, in ISO-8601 Extended format, for when you want the maintenance
        /// window to become active. <c>StartDate</c> allows you to delay activation of the maintenance
        /// window until the specified future date.
        /// </para>
        ///  <note> 
        /// <para>
        /// When using a rate schedule, if you provide a start date that occurs in the past, the
        /// current date and time are used as the start date. 
        /// </para>
        ///  </note>
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate != null;

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
        ///  <c>Key=TaskType,Value=AgentUpdate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=OS,Value=Windows</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Key=Environment,Value=Production</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// To add tags to an existing maintenance window, use the <a>AddTagsToResource</a> operation.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
