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
    /// Contains the message for a prompt. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/prompt-management.html">Construct
    /// and store reusable prompts with Prompt management in Amazon Bedrock</a>.
    /// </summary>
    public partial class PromptTemplateConfiguration
    {
        private ChatPromptTemplateConfiguration _chat;
        private TextPromptTemplateConfiguration _text;

        /// <summary>
        /// Gets and sets the property Chat. 
        /// <para>
        /// Contains configurations to use the prompt in a conversational format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ChatPromptTemplateConfiguration Chat
        {
            get { return this._chat; }
            set { this._chat = value; }
        }

        // Check to see if Chat property is set
        internal bool IsSetChat()
        {
            return this._chat != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// Contains configurations for the text in a message for a prompt.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TextPromptTemplateConfiguration Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}