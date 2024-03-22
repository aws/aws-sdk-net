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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains parameters that specify various attributes that persist across a session
    /// or prompt. You can define session state attributes as key-value pairs when writing
    /// a <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/agents-lambda.html">Lambda
    /// function</a> for an action group or pass them when making an <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html">InvokeAgent</a>
    /// request. Use session state attributes to control and provide conversational context
    /// for your agent and to help customize your agent's behavior. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/sessionstate.html">Session
    /// context</a>.
    /// </summary>
    public partial class SessionState
    {
        private Dictionary<string, string> _promptSessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _sessionAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property PromptSessionAttributes. 
        /// <para>
        /// Contains attributes that persist across a prompt and the values of those attributes.
        /// These attributes replace the $prompt_session_attributes$ placeholder variable in the
        /// orchestration prompt template. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-placeholders.html">Prompt
        /// template placeholder variables</a>.
        /// </para>
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
        /// Gets and sets the property SessionAttributes. 
        /// <para>
        /// Contains attributes that persist across a session and the values of those attributes.
        /// </para>
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