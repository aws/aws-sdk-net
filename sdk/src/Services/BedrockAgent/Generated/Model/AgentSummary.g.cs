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
    /// Contains details about an agent.
    /// </summary>
    public partial class AgentSummary
    {
        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// Checks to see if the AgentId property is set.
        /// </summary>
        internal bool IsSetAgentId() => this.AgentId != null;

        /// <summary>
        /// Gets and sets the property AgentName. 
        /// <para>
        /// The name of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentName { get; set; }

        /// <summary>
        /// Checks to see if the AgentName property is set.
        /// </summary>
        internal bool IsSetAgentName() => this.AgentName != null;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentStatus AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GuardrailConfiguration. 
        /// <para>
        /// Details about the guardrail associated with the agent.
        /// </para>
        /// </summary>
        public GuardrailConfiguration GuardrailConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailConfiguration property is set.
        /// </summary>
        internal bool IsSetGuardrailConfiguration() => this.GuardrailConfiguration != null;

        /// <summary>
        /// Gets and sets the property LatestAgentVersion. 
        /// <para>
        /// The latest version of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public string LatestAgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestAgentVersion property is set.
        /// </summary>
        internal bool IsSetLatestAgentVersion() => this.LatestAgentVersion != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the agent was last updated.
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
