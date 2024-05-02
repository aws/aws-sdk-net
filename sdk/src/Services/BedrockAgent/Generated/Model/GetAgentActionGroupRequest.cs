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
    /// Container for the parameters to the GetAgentActionGroup operation.
    /// Gets information about an action group for an agent.
    /// </summary>
    public partial class GetAgentActionGroupRequest : AmazonBedrockAgentRequest
    {
        private string _actionGroupId;
        private string _agentId;
        private string _agentVersion;

        /// <summary>
        /// Gets and sets the property ActionGroupId. 
        /// <para>
        /// The unique identifier of the action group for which to get information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ActionGroupId
        {
            get { return this._actionGroupId; }
            set { this._actionGroupId = value; }
        }

        // Check to see if ActionGroupId property is set
        internal bool IsSetActionGroupId()
        {
            return this._actionGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// The unique identifier of the agent that the action group belongs to.
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
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// The version of the agent that the action group belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

    }
}