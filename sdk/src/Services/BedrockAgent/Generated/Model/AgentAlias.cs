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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    public partial class AgentAlias
    {
        private string _agentAliasArn;
        private List<AgentAliasHistoryEvent> _agentAliasHistoryEvents = AWSConfigs.InitializeCollections ? new List<AgentAliasHistoryEvent>() : null;
        private string _agentAliasId;
        private string _agentAliasName;
        private AgentAliasStatus _agentAliasStatus;
        private string _agentId;
        private AliasInvocationState _aliasInvocationState;
        private string _clientToken;
        private DateTime? _createdAt;
        private string _description;
        private List<string> _failureReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<AgentAliasRoutingConfigurationListItem> _routingConfiguration = AWSConfigs.InitializeCollections ? new List<AgentAliasRoutingConfigurationListItem>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentAliasArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alias of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string AgentAliasArn
        {
            get { return this._agentAliasArn; }
            set { this._agentAliasArn = value; }
        }

        // Check to see if AgentAliasArn property is set
        internal bool IsSetAgentAliasArn()
        {
            return this._agentAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentAliasHistoryEvents. 
        /// <para>
        /// Contains details about the history of the alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<AgentAliasHistoryEvent> AgentAliasHistoryEvents
        {
            get { return this._agentAliasHistoryEvents; }
            set { this._agentAliasHistoryEvents = value; }
        }

        // Check to see if AgentAliasHistoryEvents property is set
        internal bool IsSetAgentAliasHistoryEvents()
        {
            return this._agentAliasHistoryEvents != null && (this._agentAliasHistoryEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentAliasId. 
        /// <para>
        /// The unique identifier of the alias of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string AgentAliasId
        {
            get { return this._agentAliasId; }
            set { this._agentAliasId = value; }
        }

        // Check to see if AgentAliasId property is set
        internal bool IsSetAgentAliasId()
        {
            return this._agentAliasId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentAliasName. 
        /// <para>
        /// The name of the alias of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentAliasName
        {
            get { return this._agentAliasName; }
            set { this._agentAliasName = value; }
        }

        // Check to see if AgentAliasName property is set
        internal bool IsSetAgentAliasName()
        {
            return this._agentAliasName != null;
        }

        /// <summary>
        /// Gets and sets the property AgentAliasStatus. 
        /// <para>
        /// The status of the alias of the agent and whether it is ready for use. The following
        /// statuses are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING – The agent alias is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PREPARED – The agent alias is finished being created or updated and is ready to be
        /// invoked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED – The agent alias API operation failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The agent alias is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – The agent alias is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISSOCIATED - The agent alias has no version associated with it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentAliasStatus AgentAliasStatus
        {
            get { return this._agentAliasStatus; }
            set { this._agentAliasStatus = value; }
        }

        // Check to see if AgentAliasStatus property is set
        internal bool IsSetAgentAliasStatus()
        {
            return this._agentAliasStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentId
        {
            get { return this._agentId; }
            set { this._agentId = value; }
        }

        // Check to see if AgentId property is set
        internal bool IsSetAgentId()
        {
            return this._agentId != null;
        }

        /// <summary>
        /// Gets and sets the property AliasInvocationState. 
        /// <para>
        /// The invocation state for the agent alias. If the agent alias is running, the value
        /// is <c>ACCEPT_INVOCATIONS</c>. If the agent alias is paused, the value is <c>REJECT_INVOCATIONS</c>.
        /// Use the <c>UpdateAgentAlias</c> operation to change the invocation state.
        /// </para>
        /// </summary>
        public AliasInvocationState AliasInvocationState
        {
            get { return this._aliasInvocationState; }
            set { this._aliasInvocationState = value; }
        }

        // Check to see if AliasInvocationState property is set
        internal bool IsSetAliasInvocationState()
        {
            return this._aliasInvocationState != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the alias of the agent was created.
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
        /// The description of the alias of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Information on the failure of Provisioned Throughput assigned to an agent alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public List<string> FailureReasons
        {
            get { return this._failureReasons; }
            set { this._failureReasons = value; }
        }

        // Check to see if FailureReasons property is set
        internal bool IsSetFailureReasons()
        {
            return this._failureReasons != null && (this._failureReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingConfiguration. 
        /// <para>
        /// Contains details about the routing configuration of the alias.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public List<AgentAliasRoutingConfigurationListItem> RoutingConfiguration
        {
            get { return this._routingConfiguration; }
            set { this._routingConfiguration = value; }
        }

        // Check to see if RoutingConfiguration property is set
        internal bool IsSetRoutingConfiguration()
        {
            return this._routingConfiguration != null && (this._routingConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the alias was last updated.
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