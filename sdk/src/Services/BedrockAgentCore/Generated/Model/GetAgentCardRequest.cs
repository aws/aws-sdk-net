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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Container for the parameters to the GetAgentCard operation.
    /// Retrieves the A2A agent card associated with an AgentCore Runtime agent.
    /// </summary>
    public partial class GetAgentCardRequest : AmazonBedrockAgentCoreRequest
    {
        private string _agentRuntimeArn;
        private string _qualifier;
        private string _runtimeSessionId;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The ARN of the AgentCore Runtime agent for which you want to get the A2A agent card.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// Optional qualifier to specify an agent alias, such as <c>prod</c>code&gt; or <c>dev</c>.
        /// If you don't provide a value, the DEFAULT alias is used. 
        /// </para>
        /// </summary>
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeSessionId. 
        /// <para>
        /// The session ID that the AgentCore Runtime agent is using. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string RuntimeSessionId
        {
            get { return this._runtimeSessionId; }
            set { this._runtimeSessionId = value; }
        }

        // Check to see if RuntimeSessionId property is set
        internal bool IsSetRuntimeSessionId()
        {
            return this._runtimeSessionId != null;
        }

    }
}