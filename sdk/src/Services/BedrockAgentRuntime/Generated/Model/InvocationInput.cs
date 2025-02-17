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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information pertaining to the action group or knowledge base that is being
    /// invoked.
    /// </summary>
    public partial class InvocationInput
    {
        private ActionGroupInvocationInput _actionGroupInvocationInput;
        private AgentCollaboratorInvocationInput _agentCollaboratorInvocationInput;
        private CodeInterpreterInvocationInput _codeInterpreterInvocationInput;
        private InvocationType _invocationType;
        private KnowledgeBaseLookupInput _knowledgeBaseLookupInput;
        private string _traceId;

        /// <summary>
        /// Gets and sets the property ActionGroupInvocationInput. 
        /// <para>
        /// Contains information about the action group to be invoked.
        /// </para>
        /// </summary>
        public ActionGroupInvocationInput ActionGroupInvocationInput
        {
            get { return this._actionGroupInvocationInput; }
            set { this._actionGroupInvocationInput = value; }
        }

        // Check to see if ActionGroupInvocationInput property is set
        internal bool IsSetActionGroupInvocationInput()
        {
            return this._actionGroupInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCollaboratorInvocationInput. 
        /// <para>
        /// The collaborator's invocation input.
        /// </para>
        /// </summary>
        public AgentCollaboratorInvocationInput AgentCollaboratorInvocationInput
        {
            get { return this._agentCollaboratorInvocationInput; }
            set { this._agentCollaboratorInvocationInput = value; }
        }

        // Check to see if AgentCollaboratorInvocationInput property is set
        internal bool IsSetAgentCollaboratorInvocationInput()
        {
            return this._agentCollaboratorInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property CodeInterpreterInvocationInput. 
        /// <para>
        /// Contains information about the code interpreter to be invoked.
        /// </para>
        /// </summary>
        public CodeInterpreterInvocationInput CodeInterpreterInvocationInput
        {
            get { return this._codeInterpreterInvocationInput; }
            set { this._codeInterpreterInvocationInput = value; }
        }

        // Check to see if CodeInterpreterInvocationInput property is set
        internal bool IsSetCodeInterpreterInvocationInput()
        {
            return this._codeInterpreterInvocationInput != null;
        }

        /// <summary>
        /// Gets and sets the property InvocationType. 
        /// <para>
        /// Specifies whether the agent is invoking an action group or a knowledge base.
        /// </para>
        /// </summary>
        public InvocationType InvocationType
        {
            get { return this._invocationType; }
            set { this._invocationType = value; }
        }

        // Check to see if InvocationType property is set
        internal bool IsSetInvocationType()
        {
            return this._invocationType != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseLookupInput. 
        /// <para>
        /// Contains details about the knowledge base to look up and the query to be made.
        /// </para>
        /// </summary>
        public KnowledgeBaseLookupInput KnowledgeBaseLookupInput
        {
            get { return this._knowledgeBaseLookupInput; }
            set { this._knowledgeBaseLookupInput = value; }
        }

        // Check to see if KnowledgeBaseLookupInput property is set
        internal bool IsSetKnowledgeBaseLookupInput()
        {
            return this._knowledgeBaseLookupInput != null;
        }

        /// <summary>
        /// Gets and sets the property TraceId. 
        /// <para>
        /// The unique identifier of the trace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=16)]
        public string TraceId
        {
            get { return this._traceId; }
            set { this._traceId = value; }
        }

        // Check to see if TraceId property is set
        internal bool IsSetTraceId()
        {
            return this._traceId != null;
        }

    }
}