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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
        private string _agentSpaceId;
        private DateTime? _createdAt;
        private string _description;
        private string _executionId;
        private bool? _hasLinkedTasks;
        private Amazon.Runtime.Documents.Document _metadata;
        private string _primaryTaskId;
        private Priority _priority;
        private ReferenceOutput _reference;
        private TaskStatus _status;
        private string _statusReason;
        private Amazon.Runtime.Documents.Document _supportMetadata;
        private string _taskId;
        private TaskType _taskType;
        private string _title;
        private DateTime? _updatedAt;
        private int? _version;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing this task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this task was created
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional detailed description of the task
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
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution ID associated with this task, if any
        /// </para>
        /// </summary>
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property HasLinkedTasks. 
        /// <para>
        /// Indicates if this task has other tasks linked to it
        /// </para>
        /// </summary>
        public bool? HasLinkedTasks
        {
            get { return this._hasLinkedTasks; }
            set { this._hasLinkedTasks = value; }
        }

        // Check to see if HasLinkedTasks property is set
        internal bool IsSetHasLinkedTasks()
        {
            return this._hasLinkedTasks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Optional metadata for the task
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return !this._metadata.IsNull();
        }

        /// <summary>
        /// Gets and sets the property PrimaryTaskId. 
        /// <para>
        /// The task ID of the primary investigation this task is linked to
        /// </para>
        /// </summary>
        public string PrimaryTaskId
        {
            get { return this._primaryTaskId; }
            set { this._primaryTaskId = value; }
        }

        // Check to see if PrimaryTaskId property is set
        internal bool IsSetPrimaryTaskId()
        {
            return this._primaryTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Priority Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// Optional reference information linking this task to external systems
        /// </para>
        /// </summary>
        public ReferenceOutput Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Explanation for why the task status was changed (e.g., linked reason)
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SupportMetadata. 
        /// <para>
        /// Optional support metadata for the task
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document SupportMetadata
        {
            get { return this._supportMetadata; }
            set { this._supportMetadata = value; }
        }

        // Check to see if SupportMetadata property is set
        internal bool IsSetSupportMetadata()
        {
            return !this._supportMetadata.IsNull();
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier for this task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of this task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the task
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this task was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version number for optimistic locking
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}