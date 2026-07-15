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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The response from the <c>UpdateProfileWithAgent</c> operation.
    /// </summary>
    public partial class UpdateProfileWithAgentResponse : AmazonWebServiceResponse
    {
        private AgentOutputMessage _agentResponse;
        private string _conversationId;

        /// <summary>
        /// Gets and sets the property AgentResponse. 
        /// <para>
        /// The response message from the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentOutputMessage AgentResponse
        {
            get { return this._agentResponse; }
            set { this._agentResponse = value; }
        }

        // Check to see if AgentResponse property is set
        internal bool IsSetAgentResponse()
        {
            return this._agentResponse != null;
        }

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The conversation identifier to use for follow-up messages in this conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

    }
}