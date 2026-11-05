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

namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The start of a tool result block. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Call
    /// a tool with the Converse API</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ToolResultBlockStart
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the tool result block.
        /// </para>
        /// </summary>
        public ToolResultStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// The ID of the tool that was used to generate this tool result block.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ToolUseId { get; set; }

        /// <summary>
        /// Checks to see if the ToolUseId property is set.
        /// </summary>
        internal bool IsSetToolUseId() => this.ToolUseId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type for the tool that was used to generate this tool result block.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
