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
    /// Contains details about an alias of an agent.
    /// </summary>
    public partial class AgentAliasSummary
    {
        /// <summary>
        /// Gets and sets the property AgentAliasId. 
        /// <para>
        /// Contains details about 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string AgentAliasId { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasId property is set.
        /// </summary>
        internal bool IsSetAgentAliasId() => this.AgentAliasId != null;

        /// <summary>
        /// Gets and sets the property AgentAliasName. 
        /// <para>
        /// The name of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentAliasName { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasName property is set.
        /// </summary>
        internal bool IsSetAgentAliasName() => this.AgentAliasName != null;

        /// <summary>
        /// Gets and sets the property AgentAliasStatus. 
        /// <para>
        /// The status of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AgentAliasStatus AgentAliasStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentAliasStatus property is set.
        /// </summary>
        internal bool IsSetAgentAliasStatus() => this.AgentAliasStatus != null;

        /// <summary>
        /// Gets and sets the property AliasInvocationState. 
        /// <para>
        /// The invocation state for the agent alias. If the agent alias is running, the value
        /// is <c>ACCEPT_INVOCATIONS</c>. If the agent alias is paused, the value is <c>REJECT_INVOCATIONS</c>.
        /// Use the <c>UpdateAgentAlias</c> operation to change the invocation state.
        /// </para>
        /// </summary>
        public AliasInvocationState AliasInvocationState { get; set; }

        /// <summary>
        /// Checks to see if the AliasInvocationState property is set.
        /// </summary>
        internal bool IsSetAliasInvocationState() => this.AliasInvocationState != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the alias of the agent was created.
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
        /// The description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// Contains details about the version of the agent with which the alias is associated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 1)]
        public List<AgentAliasRoutingConfigurationListItem> RoutingConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentAliasRoutingConfigurationListItem>() : null;

        /// <summary>
        /// Checks to see if the RoutingConfiguration property is set.
        /// </summary>
        internal bool IsSetRoutingConfiguration() => this.RoutingConfiguration != null && (this.RoutingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the alias was last updated.
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
