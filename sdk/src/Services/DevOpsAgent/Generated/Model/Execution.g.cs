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
    /// Represents an execution instance with its lifecycle information
    /// </summary>
    public partial class Execution
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space containing this execution
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AgentSubTask. 
        /// <para>
        /// The specific subtask being executed by the agent
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSubTask { get; set; }

        /// <summary>
        /// Checks to see if the AgentSubTask property is set.
        /// </summary>
        internal bool IsSetAgentSubTask() => this.AgentSubTask != null;

        /// <summary>
        /// Gets and sets the property AgentType. 
        /// <para>
        /// The type of agent that performed this execution.
        /// </para>
        /// </summary>
        public string AgentType { get; set; }

        /// <summary>
        /// Checks to see if the AgentType property is set.
        /// </summary>
        internal bool IsSetAgentType() => this.AgentType != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when this execution was created
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The unique identifier for this execution
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The current status of this execution
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus ExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionStatus property is set.
        /// </summary>
        internal bool IsSetExecutionStatus() => this.ExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property ParentExecutionId. 
        /// <para>
        /// The identifier of the parent execution, if this is a child execution
        /// </para>
        /// </summary>
        public string ParentExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ParentExecutionId property is set.
        /// </summary>
        internal bool IsSetParentExecutionId() => this.ParentExecutionId != null;

        /// <summary>
        /// Gets and sets the property Uid. 
        /// <para>
        /// The unique identifier for the user session associated with this execution
        /// </para>
        /// </summary>
        public string Uid { get; set; }

        /// <summary>
        /// Checks to see if the Uid property is set.
        /// </summary>
        internal bool IsSetUid() => this.Uid != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when this execution was last updated
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
