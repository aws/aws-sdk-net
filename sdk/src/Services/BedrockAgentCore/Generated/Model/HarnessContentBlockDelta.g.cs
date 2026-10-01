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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// A delta update to a content block.
    /// </summary>
    public partial class HarnessContentBlockDelta
    {
        /// <summary>
        /// Gets and sets the property ReasoningContent. 
        /// <para>
        /// A reasoning content delta.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public HarnessReasoningContentBlockDelta ReasoningContent { get; set; }

        /// <summary>
        /// Checks to see if the ReasoningContent property is set.
        /// </summary>
        internal bool IsSetReasoningContent() => this.ReasoningContent != null;

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// A text delta.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1)]
        public string Text { get; set; }

        /// <summary>
        /// Checks to see if the Text property is set.
        /// </summary>
        internal bool IsSetText() => this.Text != null;

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// A tool result delta.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<HarnessToolResultBlockDelta> ToolResult { get; set; } = AWSConfigs.InitializeCollections ? new List<HarnessToolResultBlockDelta>() : null;

        /// <summary>
        /// Checks to see if the ToolResult property is set.
        /// </summary>
        internal bool IsSetToolResult() => this.ToolResult != null && (this.ToolResult.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ToolResultMetadata. 
        /// <para>
        /// A tool result metadata delta.
        /// </para>
        /// </summary>
        public HarnessToolResultMetadataBlockDelta ToolResultMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ToolResultMetadata property is set.
        /// </summary>
        internal bool IsSetToolResultMetadata() => this.ToolResultMetadata != null;

        /// <summary>
        /// Gets and sets the property ToolUse. 
        /// <para>
        /// A tool use input delta.
        /// </para>
        /// </summary>
        public HarnessToolUseBlockDelta ToolUse { get; set; }

        /// <summary>
        /// Checks to see if the ToolUse property is set.
        /// </summary>
        internal bool IsSetToolUse() => this.ToolUse != null;
    }
}
