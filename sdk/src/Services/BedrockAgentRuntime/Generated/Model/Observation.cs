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
    /// Contains the result or output of an action group or knowledge base, or the response
    /// to the user.
    /// </summary>
    public partial class Observation
    {
        private ActionGroupInvocationOutput _actionGroupInvocationOutput;
        private AgentCollaboratorInvocationOutput _agentCollaboratorInvocationOutput;
        private CodeInterpreterInvocationOutput _codeInterpreterInvocationOutput;
        private FinalResponse _finalResponse;
        private KnowledgeBaseLookupOutput _knowledgeBaseLookupOutput;
        private RepromptResponse _repromptResponse;
        private string _traceId;
        private Type _type;

        /// <summary>
        /// Gets and sets the property ActionGroupInvocationOutput. 
        /// <para>
        /// Contains the JSON-formatted string returned by the API invoked by the action group.
        /// </para>
        /// </summary>
        public ActionGroupInvocationOutput ActionGroupInvocationOutput
        {
            get { return this._actionGroupInvocationOutput; }
            set { this._actionGroupInvocationOutput = value; }
        }

        // Check to see if ActionGroupInvocationOutput property is set
        internal bool IsSetActionGroupInvocationOutput()
        {
            return this._actionGroupInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property AgentCollaboratorInvocationOutput. 
        /// <para>
        /// A collaborator's invocation output.
        /// </para>
        /// </summary>
        public AgentCollaboratorInvocationOutput AgentCollaboratorInvocationOutput
        {
            get { return this._agentCollaboratorInvocationOutput; }
            set { this._agentCollaboratorInvocationOutput = value; }
        }

        // Check to see if AgentCollaboratorInvocationOutput property is set
        internal bool IsSetAgentCollaboratorInvocationOutput()
        {
            return this._agentCollaboratorInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property CodeInterpreterInvocationOutput. 
        /// <para>
        /// Contains the JSON-formatted string returned by the API invoked by the code interpreter.
        /// </para>
        /// </summary>
        public CodeInterpreterInvocationOutput CodeInterpreterInvocationOutput
        {
            get { return this._codeInterpreterInvocationOutput; }
            set { this._codeInterpreterInvocationOutput = value; }
        }

        // Check to see if CodeInterpreterInvocationOutput property is set
        internal bool IsSetCodeInterpreterInvocationOutput()
        {
            return this._codeInterpreterInvocationOutput != null;
        }

        /// <summary>
        /// Gets and sets the property FinalResponse. 
        /// <para>
        /// Contains details about the response to the user.
        /// </para>
        /// </summary>
        public FinalResponse FinalResponse
        {
            get { return this._finalResponse; }
            set { this._finalResponse = value; }
        }

        // Check to see if FinalResponse property is set
        internal bool IsSetFinalResponse()
        {
            return this._finalResponse != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseLookupOutput. 
        /// <para>
        /// Contains details about the results from looking up the knowledge base.
        /// </para>
        /// </summary>
        public KnowledgeBaseLookupOutput KnowledgeBaseLookupOutput
        {
            get { return this._knowledgeBaseLookupOutput; }
            set { this._knowledgeBaseLookupOutput = value; }
        }

        // Check to see if KnowledgeBaseLookupOutput property is set
        internal bool IsSetKnowledgeBaseLookupOutput()
        {
            return this._knowledgeBaseLookupOutput != null;
        }

        /// <summary>
        /// Gets and sets the property RepromptResponse. 
        /// <para>
        /// Contains details about the response to reprompt the input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public RepromptResponse RepromptResponse
        {
            get { return this._repromptResponse; }
            set { this._repromptResponse = value; }
        }

        // Check to see if RepromptResponse property is set
        internal bool IsSetRepromptResponse()
        {
            return this._repromptResponse != null;
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies what kind of information the agent returns in the observation. The following
        /// values are possible.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTION_GROUP</c> – The agent returns the result of an action group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KNOWLEDGE_BASE</c> – The agent returns information from a knowledge base.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FINISH</c> – The agent returns a final response to the user with no follow-up.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ASK_USER</c> – The agent asks the user a question.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPROMPT</c> – The agent prompts the user again for the same information.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}