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
    /// Contains the template for the prompt that's sent to the model for response generation.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html#kb-test-config-sysprompt">Knowledge
    /// base prompt templates</a>.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_RequestSyntax">RetrieveAndGenerate
    /// request</a> – in the <c>filter</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PromptTemplate
    {
        private string _textPromptTemplate;

        /// <summary>
        /// Gets and sets the property TextPromptTemplate. 
        /// <para>
        /// The template for the prompt that's sent to the model for response generation. You
        /// can include prompt placeholders, which become replaced before the prompt is sent to
        /// the model to provide instructions and context to the model. In addition, you can include
        /// XML tags to delineate meaningful sections of the prompt template.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/kb-test-config.html#kb-test-config-sysprompt">Knowledge
        /// base prompt templates</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.anthropic.com/claude/docs/use-xml-tags">Use XML tags with Anthropic
        /// Claude models</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4000)]
        public string TextPromptTemplate
        {
            get { return this._textPromptTemplate; }
            set { this._textPromptTemplate = value; }
        }

        // Check to see if TextPromptTemplate property is set
        internal bool IsSetTextPromptTemplate()
        {
            return this._textPromptTemplate != null;
        }

    }
}