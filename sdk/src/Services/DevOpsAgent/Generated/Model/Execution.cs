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
    /// Represents an execution instance with its lifecycle information
    /// </summary>
    public partial class Execution
    {
        private string _agentSpaceId;
        private string _agentSubTask;
        private string _agentType;
        private DateTime? _createdAt;
        private string _executionId;
        private ExecutionStatus _executionStatus;
        private string _parentExecutionId;
        private string _uid;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing this execution
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
        /// Gets and sets the property AgentSubTask. 
        /// <para>
        /// The specific subtask being executed by the agent
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSubTask
        {
            get { return this._agentSubTask; }
            set { this._agentSubTask = value; }
        }

        // Check to see if AgentSubTask property is set
        internal bool IsSetAgentSubTask()
        {
            return this._agentSubTask != null;
        }

        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// The type of agent that performed this execution.
        /// </para>
        /// </summary>
        public string AgentType
        {
            get { return this._agentType; }
            set { this._agentType = value; }
        }

        // Check to see if AgentType property is set
        internal bool IsSetAgentType()
        {
            return this._agentType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this execution was created
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
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for this execution
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The current status of this execution
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus ExecutionStatus
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
        /// Gets and sets the property ParentExecutionId. 
        /// <para>
        /// The identifier of the parent execution, if this is a child execution
        /// </para>
        /// </summary>
        public string ParentExecutionId
        {
            get { return this._parentExecutionId; }
            set { this._parentExecutionId = value; }
        }

        // Check to see if ParentExecutionId property is set
        internal bool IsSetParentExecutionId()
        {
            return this._parentExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier for the user session associated with this execution
        /// </para>
        /// </summary>
        public string Uid
        {
            get { return this._uid; }
            set { this._uid = value; }
        }

        // Check to see if Uid property is set
        internal bool IsSetUid()
        {
            return this._uid != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this execution was last updated
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

    }
}