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
    /// Describes the information about a task invocation for a particular target as part
    /// of a task execution performed as part of a maintenance window execution.
    /// </summary>
    public partial class MaintenanceWindowExecutionTaskInvocationIdentity
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the invocation finished.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The ID of the action performed in the service that actually handled the task invocation.
        /// If the task type is <c>RUN_COMMAND</c>, this value is the command ID.
        /// </para>
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The ID of the task invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string InvocationId { get; set; }

        /// <summary>
        /// Checks to see if the InvocationId property is set.
        /// </summary>
        internal bool IsSetInvocationId() => this.InvocationId != null;

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// User-provided value that was specified when the target was registered with the maintenance
        /// window. This was also included in any Amazon CloudWatch Events events raised during
        /// the task invocation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string OwnerInformation { get; set; }

        /// <summary>
        /// Checks to see if the OwnerInformation property is set.
        /// </summary>
        internal bool IsSetOwnerInformation() => this.OwnerInformation != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters that were provided for the invocation when it was run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the invocation started.
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
        /// The status of the task invocation.
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
        /// The details explaining the status of the task invocation. Not available for all status
        /// values. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property TaskExecutionId. 
        /// <para>
        /// The ID of the specific task execution in the maintenance window execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string TaskExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the TaskExecutionId property is set.
        /// </summary>
        internal bool IsSetTaskExecutionId() => this.TaskExecutionId != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The task type.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;

        /// <summary>
        /// Gets and sets the property WindowExecutionId. 
        /// <para>
        /// The ID of the maintenance window execution that ran the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string WindowExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the WindowExecutionId property is set.
        /// </summary>
        internal bool IsSetWindowExecutionId() => this.WindowExecutionId != null;

        /// <summary>
        /// Gets and sets the property WindowTargetId. 
        /// <para>
        /// The ID of the target definition in this maintenance window the invocation was performed
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string WindowTargetId { get; set; }

        /// <summary>
        /// Checks to see if the WindowTargetId property is set.
        /// </summary>
        internal bool IsSetWindowTargetId() => this.WindowTargetId != null;
    }
}
