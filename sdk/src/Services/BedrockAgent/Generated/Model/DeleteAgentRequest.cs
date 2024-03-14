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
    /// Container for the parameters to the DeleteAgent operation.
    /// Deletes an Agent for existing Amazon Bedrock Agent
    /// </summary>
    public partial class DeleteAgentRequest : AmazonBedrockAgentRequest
    {
        private string _agentId;
        private bool? _skipResourceInUseCheck;

        /// <summary>
        /// Gets and sets the property AgentId. 
        /// <para>
        /// Id generated at the server side when an Agent is created
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
        /// Gets and sets the property SkipResourceInUseCheck. 
        /// <para>
        /// Skips checking if resource is in use when set to true. Defaults to false
        /// </para>
        /// </summary>
        public bool? SkipResourceInUseCheck
        {
            get { return this._skipResourceInUseCheck; }
            set { this._skipResourceInUseCheck = value; }
        }

        // Check to see if SkipResourceInUseCheck property is set
        internal bool IsSetSkipResourceInUseCheck()
        {
            return this._skipResourceInUseCheck.HasValue; 
        }

    }
}