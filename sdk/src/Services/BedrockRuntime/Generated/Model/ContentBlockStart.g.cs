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
    /// Content block start information.
    /// </summary>
    public partial class ContentBlockStart
    {
        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The initial event indicating the start of a streaming image block.
        /// </para>
        /// </summary>
        public ImageBlockStart Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// The 
        /// </para>
        /// </summary>
        public ToolResultBlockStart ToolResult { get; set; }

        /// <summary>
        /// Checks to see if the ToolResult property is set.
        /// </summary>
        internal bool IsSetToolResult() => this.ToolResult != null;

        /// <summary>
        /// Gets and sets the property ToolUse. 
        /// <para>
        /// Information about a tool that the model is requesting to use.
        /// </para>
        /// </summary>
        public ToolUseBlockStart ToolUse { get; set; }

        /// <summary>
        /// Checks to see if the ToolUse property is set.
        /// </summary>
        internal bool IsSetToolUse() => this.ToolUse != null;
    }
}
