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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAgentKnowledgeBase operation. Associates
    /// a knowledge base with an agent. If a knowledge base is associated and its <c>indexState</c>
    /// is set to <c>Enabled</c>, the agent queries the knowledge base for information to
    /// augment its response to the user.
    /// </summary>
    public partial class AssociateAgentKnowledgeBaseRequest : AmazonBedrockAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent with which you want to associate the knowledge
        /// base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the agent with which you want to associate the knowledge base.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of what the agent should use the knowledge base for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The unique identifier of the knowledge base to associate with the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseState. 
        /// <para>
        /// Specifies whether to use the knowledge base or not when sending an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
        /// request.
        /// </para>
        /// </summary>
        public KnowledgeBaseState KnowledgeBaseState { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseState property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseState() => this.KnowledgeBaseState != null;
    }
}
