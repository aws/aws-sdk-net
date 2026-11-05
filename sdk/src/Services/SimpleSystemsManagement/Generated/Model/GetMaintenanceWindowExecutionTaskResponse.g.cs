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
    /// This is the response object from the GetMaintenanceWindowExecutionTask operation.
    /// </summary>
    public partial class GetMaintenanceWindowExecutionTaskResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm you applied to your maintenance window task.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AlarmConfiguration property is set.
        /// </summary>
        internal bool IsSetAlarmConfiguration() => this.AlarmConfiguration != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the task execution completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The defined maximum number of task executions that could be run in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxConcurrency { get; set; }

        /// <summary>
        /// Checks to see if the MaxConcurrency property is set.
        /// </summary>
        internal bool IsSetMaxConcurrency() => this.MaxConcurrency != null;

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The defined maximum number of task execution errors allowed before scheduling of the
        /// task execution would have been stopped.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 7)]
        public string MaxErrors { get; set; }

        /// <summary>
        /// Checks to see if the MaxErrors property is set.
        /// </summary>
        internal bool IsSetMaxErrors() => this.MaxErrors != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The role that was assumed when running the task.
        /// </para>
        /// </summary>
        public string ServiceRole { get; set; }

        /// <summary>
        /// Checks to see if the ServiceRole property is set.
        /// </summary>
        internal bool IsSetServiceRole() => this.ServiceRole != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the task execution started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the task.
        /// </para>
        /// </summary>
        public MaintenanceWindowExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// The details explaining the status. Not available for all status values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task that ran.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string TaskArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskArn property is set.
        /// </summary>
        internal bool IsSetTaskArn() => this.TaskArn != null;

        /// <summary>
        /// Gets and sets the property TaskExecutionId. 
        /// <para>
        /// The ID of the specific task execution in the maintenance window task that was retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the TaskExecutionId property is set.
        /// </summary>
        internal bool IsSetTaskExecutionId() => this.TaskExecutionId != null;

        /// <summary>
        /// Gets and sets the property TaskParameters. 
        /// <para>
        /// The parameters passed to the task when it was run.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>TaskParameters</c> has been deprecated. To specify parameters to pass to a task
        /// when it runs, instead use the <c>Parameters</c> option in the <c>TaskInvocationParameters</c>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The map has the following format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Key</c>: string, between 1 and 255 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Value</c>: an array of strings, each between 1 and 255 characters
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public List<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>> TaskParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<Dictionary<string, MaintenanceWindowTaskParameterValueExpression>>() : null;

        /// <summary>
        /// Checks to see if the TaskParameters property is set.
        /// </summary>
        internal bool IsSetTaskParameters() => this.TaskParameters != null && (this.TaskParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TriggeredAlarms. 
        /// <para>
        /// The CloudWatch alarms that were invoked by the maintenance window task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<AlarmStateInformation> TriggeredAlarms { get; set; } = AWSConfigs.InitializeCollections ? new List<AlarmStateInformation>() : null;

        /// <summary>
        /// Checks to see if the TriggeredAlarms property is set.
        /// </summary>
        internal bool IsSetTriggeredAlarms() => this.TriggeredAlarms != null && (this.TriggeredAlarms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of task that was run.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property WindowExecutionId. 
        /// <para>
        /// The ID of the maintenance window execution that includes the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WindowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WindowExecutionId property is set.
        /// </summary>
        internal bool IsSetWindowExecutionId() => this.WindowExecutionId != null;
    }
}
