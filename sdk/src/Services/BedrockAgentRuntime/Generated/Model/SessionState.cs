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
    /// Contains parameters that specify various attributes that persist across a session
    /// or prompt. You can define session state attributes as key-value pairs when writing
    /// a <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-lambda.html">Lambda
    /// function</a> for an action group or pass them when making an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
    /// request. Use session state attributes to control and provide conversational context
    /// for your agent and to help customize your agent's behavior. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
    /// session context</a>.
    /// </summary>
    public partial class SessionState
    {
        private ConversationHistory _conversationHistory;
        private List<InputFile> _files = AWSConfigs.InitializeCollections ? new List<InputFile>() : null;
        private string _invocationId;
        private List<KnowledgeBaseConfiguration> _knowledgeBaseConfigurations = AWSConfigs.InitializeCollections ? new List<KnowledgeBaseConfiguration>() : null;
        private Dictionary<string, string> _promptSessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<InvocationResultMember> _returnControlInvocationResults = AWSConfigs.InitializeCollections ? new List<InvocationResultMember>() : null;
        private Dictionary<string, string> _sessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ConversationHistory. 
        /// <para>
        /// The state's conversation history.
        /// </para>
        /// </summary>
        public ConversationHistory ConversationHistory
        {
            get { return this._conversationHistory; }
            set { this._conversationHistory = value; }
        }

        // Check to see if ConversationHistory property is set
        internal bool IsSetConversationHistory()
        {
            return this._conversationHistory != null;
        }

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// Contains information about the files used by code interpreter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InputFile> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && (this._files.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InvocationId. 
        /// <para>
        /// The identifier of the invocation of an action. This value must match the <c>invocationId</c>
        /// returned in the <c>InvokeAgent</c> response for the action whose results are provided
        /// in the <c>returnControlInvocationResults</c> field. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-returncontrol.html">Return
        /// control to the agent developer</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
        /// session context</a>.
        /// </para>
        /// </summary>
        public string InvocationId
        {
            get { return this._invocationId; }
            set { this._invocationId = value; }
        }

        // Check to see if InvocationId property is set
        internal bool IsSetInvocationId()
        {
            return this._invocationId != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseConfigurations. 
        /// <para>
        /// An array of configurations, each of which applies to a knowledge base attached to
        /// the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<KnowledgeBaseConfiguration> KnowledgeBaseConfigurations
        {
            get { return this._knowledgeBaseConfigurations; }
            set { this._knowledgeBaseConfigurations = value; }
        }

        // Check to see if KnowledgeBaseConfigurations property is set
        internal bool IsSetKnowledgeBaseConfigurations()
        {
            return this._knowledgeBaseConfigurations != null && (this._knowledgeBaseConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PromptSessionAttributes. 
        /// <para>
        /// Contains attributes that persist across a prompt and the values of those attributes.
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// In orchestration prompt template, these attributes replace the $prompt_session_attributes$
        /// placeholder variable. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-placeholders.html">Prompt
        /// template placeholder variables</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-multi-agent-collaboration.html">multi-agent
        /// collaboration</a>, the <c>promptSessionAttributes</c> will only be used by supervisor
        /// agent when $prompt_session_attributes$ is present in prompt template. 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> PromptSessionAttributes
        {
            get { return this._promptSessionAttributes; }
            set { this._promptSessionAttributes = value; }
        }

        // Check to see if PromptSessionAttributes property is set
        internal bool IsSetPromptSessionAttributes()
        {
            return this._promptSessionAttributes != null && (this._promptSessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReturnControlInvocationResults. 
        /// <para>
        /// Contains information about the results from the action group invocation. For more
        /// information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-returncontrol.html">Return
        /// control to the agent developer</a> and <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-session-state.html">Control
        /// session context</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you include this field, the <c>inputText</c> field will be ignored.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<InvocationResultMember> ReturnControlInvocationResults
        {
            get { return this._returnControlInvocationResults; }
            set { this._returnControlInvocationResults = value; }
        }

        // Check to see if ReturnControlInvocationResults property is set
        internal bool IsSetReturnControlInvocationResults()
        {
            return this._returnControlInvocationResults != null && (this._returnControlInvocationResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Contains attributes that persist across a session and the values of those attributes.
        /// If <c>sessionAttributes</c> are passed to a supervisor agent in <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-multi-agent-collaboration.html">multi-agent
        /// collaboration</a>, it will be forwarded to all agent collaborators.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> SessionAttributes
        {
            get { return this._sessionAttributes; }
            set { this._sessionAttributes = value; }
        }

        // Check to see if SessionAttributes property is set
        internal bool IsSetSessionAttributes()
        {
            return this._sessionAttributes != null && (this._sessionAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}