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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Summary information for a task
    /// </summary>
    public partial class TaskSummary
    {
        private string _agentSpaceId;
        private DateTime? _createdAt;
        private TaskExecutionStatus _executionStatus;
        private string _pentestId;
        private string _pentestJobId;
        private RiskType _riskType;
        private string _taskId;
        private string _title;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Identifier of the agent space this task belongs to
        /// </para>
        /// </summary>
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
        /// Timestamp when the task was created
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// Current status of the task execution
        /// </para>
        /// </summary>
        public TaskExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PentestId. 
        /// <para>
        /// Identifier of the parent pentest
        /// </para>
        /// </summary>
        public string PentestId
        {
            get { return this._pentestId; }
            set { this._pentestId = value; }
        }

        // Check to see if PentestId property is set
        internal bool IsSetPentestId()
        {
            return this._pentestId != null;
        }

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// Identifier of the pentest job this task belongs to
        /// </para>
        /// </summary>
        public string PentestJobId
        {
            get { return this._pentestJobId; }
            set { this._pentestJobId = value; }
        }

        // Check to see if PentestJobId property is set
        internal bool IsSetPentestJobId()
        {
            return this._pentestJobId != null;
        }

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// Type of security risk this task is designed to test
        /// </para>
        /// </summary>
        public RiskType RiskType
        {
            get { return this._riskType; }
            set { this._riskType = value; }
        }

        // Check to see if RiskType property is set
        internal bool IsSetRiskType()
        {
            return this._riskType != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Unique identifier for the task
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
        /// Gets and sets the property Title. 
        /// <para>
        /// Title or name of the task
        /// </para>
        /// </summary>
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
        /// Timestamp when the task was last updated
        /// </para>
        /// </summary>
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

    }
}