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
    /// Container for the parameters to the CreateBacklogTask operation. Creates a new backlog
    /// task in the specified agent space
    /// </summary>
    public partial class CreateBacklogTaskRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier for the agent space where the task will be created
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client-provided token for idempotent operations
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional detailed description of the task
        /// </para>
        /// </summary>
        [AWSProperty(Max = 10000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority level of the task
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
        /// Optional reference information for the task
        /// </para>
        /// </summary>
        public ReferenceInput Reference { get; set; }

        /// <summary>
        /// Checks to see if the Reference property is set.
        /// </summary>
        internal bool IsSetReference() => this.Reference != null;

        /// <summary>
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task being created
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
        /// The title of the backlog task
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 400)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
