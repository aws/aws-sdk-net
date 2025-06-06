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
    /// Specifies parameters that control how the service populates the agent prompt for an
    /// <c>InvokeAgent</c> or <c>InvokeInlineAgent</c> request. You can control which aspects
    /// of previous invocations in the same agent session the service uses to populate the
    /// agent prompt. This gives you more granular control over the contextual history that
    /// is used to process the current request.
    /// </summary>
    public partial class PromptCreationConfigurations
    {
        private bool? _excludePreviousThinkingSteps;
        private int? _previousConversationTurnsToInclude;

        /// <summary>
        /// Gets and sets the property ExcludePreviousThinkingSteps. 
        /// <para>
        /// If <c>true</c>, the service removes any content between <c>&lt;thinking&gt;</c> tags
        /// from previous conversations in an agent session. The service will only remove content
        /// from already processed turns. This helps you remove content which might not be useful
        /// for current and subsequent invocations. This can reduce the input token count and
        /// potentially save costs. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ExcludePreviousThinkingSteps
        {
            get { return this._excludePreviousThinkingSteps; }
            set { this._excludePreviousThinkingSteps = value; }
        }

        // Check to see if ExcludePreviousThinkingSteps property is set
        internal bool IsSetExcludePreviousThinkingSteps()
        {
            return this._excludePreviousThinkingSteps.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousConversationTurnsToInclude. 
        /// <para>
        /// The number of previous conversations from the ongoing agent session to include in
        /// the conversation history of the agent prompt, during the current invocation. This
        /// gives you more granular control over the context that the model is made aware of,
        /// and helps the model remove older context which is no longer useful during the ongoing
        /// agent session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PreviousConversationTurnsToInclude
        {
            get { return this._previousConversationTurnsToInclude; }
            set { this._previousConversationTurnsToInclude = value; }
        }

        // Check to see if PreviousConversationTurnsToInclude property is set
        internal bool IsSetPreviousConversationTurnsToInclude()
        {
            return this._previousConversationTurnsToInclude.HasValue; 
        }

    }
}