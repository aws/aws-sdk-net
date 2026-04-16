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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the SendMessage operation.
    /// Sends a chat message and streams the response for the specified agent space execution
    /// </summary>
    public partial class SendMessageRequest : AmazonDevOpsAgentRequest
    {
        private string _agentSpaceId;
        private string _content;
        private SendMessageContext _context;
        private string _executionId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The agent space identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The user message content
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=32768)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Optional context for the message
        /// </para>
        /// </summary>
        public SendMessageContext Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// The execution identifier for the chat session
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ExecutionId
        {
            get { return this._executionId; }
            set { this._executionId = value; }
        }

        // Check to see if ExecutionId property is set
        internal bool IsSetExecutionId()
        {
            return this._executionId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// User identifier. This field is deprecated and will be ignored — the service resolves
        /// user identity from the authenticated session.
        /// </para>
        /// </summary>
        [Obsolete("userId is managed by the service and should not be provided by the caller")]
        [AWSProperty(Min=1, Max=128)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}