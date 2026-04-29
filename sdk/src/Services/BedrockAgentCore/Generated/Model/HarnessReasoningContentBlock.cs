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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Reasoning content from the model.
    /// </summary>
    public partial class HarnessReasoningContentBlock
    {
        private HarnessReasoningTextBlock _reasoningText;
        private MemoryStream _redactedContent;

        /// <summary>
        /// Gets and sets the property ReasoningText. 
        /// <para>
        /// The reasoning text.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public HarnessReasoningTextBlock ReasoningText
        {
            get { return this._reasoningText; }
            set { this._reasoningText = value; }
        }

        // Check to see if ReasoningText property is set
        internal bool IsSetReasoningText()
        {
            return this._reasoningText != null;
        }

        /// <summary>
        /// Gets and sets the property RedactedContent. 
        /// <para>
        /// Redacted reasoning content.
        /// </para>
        /// </summary>
        public MemoryStream RedactedContent
        {
            get { return this._redactedContent; }
            set { this._redactedContent = value; }
        }

        // Check to see if RedactedContent property is set
        internal bool IsSetRedactedContent()
        {
            return this._redactedContent != null;
        }

    }
}