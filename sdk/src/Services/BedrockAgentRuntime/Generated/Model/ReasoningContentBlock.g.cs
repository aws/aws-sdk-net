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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains content regarding the reasoning that the foundation model made with respect
    /// to the content in the content block. Reasoning refers to a Chain of Thought (CoT)
    /// that the model generates to enhance the accuracy of its final response.
    /// </summary>
    public partial class ReasoningContentBlock
    {
        /// <summary>
        /// Gets and sets the property ReasoningText. 
        /// <para>
        /// Contains information about the reasoning that the model used to return the content
        /// in the content block.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ReasoningTextBlock ReasoningText { get; set; }

        /// <summary>
        /// Checks to see if the ReasoningText property is set.
        /// </summary>
        internal bool IsSetReasoningText() => this.ReasoningText != null;

        /// <summary>
        /// Gets and sets the property RedactedContent. 
        /// <para>
        /// The content in the reasoning that was encrypted by the model provider for trust and
        /// safety reasons.
        /// </para>
        /// </summary>
        public MemoryStream RedactedContent { get; set; }

        /// <summary>
        /// Checks to see if the RedactedContent property is set.
        /// </summary>
        internal bool IsSetRedactedContent() => this.RedactedContent != null;
    }
}
