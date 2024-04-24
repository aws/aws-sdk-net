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
    /// This is the response object from the UpdateAgentKnowledgeBase operation.
    /// </summary>
    public partial class UpdateAgentKnowledgeBaseResponse : AmazonWebServiceResponse
    {
        private AgentKnowledgeBase _agentKnowledgeBase;

        /// <summary>
        /// Gets and sets the property AgentKnowledgeBase. 
        /// <para>
        /// Contains details about the knowledge base that has been associated with an agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentKnowledgeBase AgentKnowledgeBase
        {
            get { return this._agentKnowledgeBase; }
            set { this._agentKnowledgeBase = value; }
        }

        // Check to see if AgentKnowledgeBase property is set
        internal bool IsSetAgentKnowledgeBase()
        {
            return this._agentKnowledgeBase != null;
        }

    }
}