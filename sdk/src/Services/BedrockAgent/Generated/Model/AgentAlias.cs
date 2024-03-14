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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains the information of an agent alias
    /// </summary>
    public partial class AgentAlias
    {
        private string _agentAliasArn;
        private List<AgentAliasHistoryEvent> _agentAliasHistoryEvents = new List<AgentAliasHistoryEvent>();
        private string _agentAliasId;
        private string _agentAliasName;
        private AgentAliasStatus _agentAliasStatus;
        private string _agentId;
        private string _clientToken;
        private DateTime? _createdAt;
        private string _description;
        private List<AgentAliasRoutingConfigurationListItem> _routingConfiguration = new List<AgentAliasRoutingConfigurationListItem>();
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentAliasArn.
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
            return this._agentAliasHistoryEvents != null && this._agentAliasHistoryEvents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AgentAliasId.
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
        /// Gets and sets the property ClientToken.
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
        /// Gets and sets the property RoutingConfiguration.
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
            return this._routingConfiguration != null && this._routingConfiguration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt.
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