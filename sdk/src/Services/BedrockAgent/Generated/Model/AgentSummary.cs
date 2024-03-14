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
    /// Summary of Agent.
    /// </summary>
    public partial class AgentSummary
    {
        private string _agentId;
        private string _agentName;
        private AgentStatus _agentStatus;
        private string _description;
        private string _latestAgentVersion;
        private DateTime? _updatedAt;

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
        /// Gets and sets the property AgentName.
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentName
        {
            get { return this._agentName; }
            set { this._agentName = value; }
        }

        // Check to see if AgentName property is set
        internal bool IsSetAgentName()
        {
            return this._agentName != null;
        }

        /// <summary>
        /// Gets and sets the property AgentStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
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
        /// Gets and sets the property LatestAgentVersion.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public string LatestAgentVersion
        {
            get { return this._latestAgentVersion; }
            set { this._latestAgentVersion = value; }
        }

        // Check to see if LatestAgentVersion property is set
        internal bool IsSetLatestAgentVersion()
        {
            return this._latestAgentVersion != null;
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