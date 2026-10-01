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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a backlog task with all its properties and metadata
    /// </summary>
    public partial class Task
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing this task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this task was created
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional detailed description of the task
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution ID associated with this task, if any
        /// </para>
        /// </summary>
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property HasLinkedTasks. 
        /// <para>
        /// Indicates if this task has other tasks linked to it
        /// </para>
        /// </summary>
        public bool? HasLinkedTasks { get; set; }

        /// <summary>
        /// Checks to see if the HasLinkedTasks property is set.
        /// </summary>
        internal bool IsSetHasLinkedTasks() => this.HasLinkedTasks.HasValue;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Optional metadata for the task
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => !this.Metadata.IsNull();

        /// <summary>
        /// Gets and sets the property PrimaryTaskId. 
        /// <para>
        /// The task ID of the primary investigation this task is linked to
        /// </para>
        /// </summary>
        public string PrimaryTaskId { get; set; }

        /// <summary>
        /// Checks to see if the PrimaryTaskId property is set.
        /// </summary>
        internal bool IsSetPrimaryTaskId() => this.PrimaryTaskId != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Priority Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// Optional reference information linking this task to external systems
        /// </para>
        /// </summary>
        public ReferenceOutput Reference { get; set; }

        /// <summary>
        /// Checks to see if the Reference property is set.
        /// </summary>
        internal bool IsSetReference() => this.Reference != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Explanation for why the task status was changed (e.g., linked reason)
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property SupportMetadata. 
        /// <para>
        /// Optional support metadata for the task
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document SupportMetadata { get; set; }

        /// <summary>
        /// Checks to see if the SupportMetadata property is set.
        /// </summary>
        internal bool IsSetSupportMetadata() => !this.SupportMetadata.IsNull();

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier for this task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TaskType TaskType { get; set; }

        /// <summary>
        /// Checks to see if the TaskType property is set.
        /// </summary>
        internal bool IsSetTaskType() => this.TaskType != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this task was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version number for optimistic locking
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version.HasValue;
    }
}
