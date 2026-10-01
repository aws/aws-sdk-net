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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Data about the result of tool usage.
    /// </summary>
    public partial class ToolUseResultData
    {
        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool use result.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Amazon.Runtime.Documents.Document InputSchema { get; set; }

        /// <summary>
        /// Checks to see if the InputSchema property is set.
        /// </summary>
        internal bool IsSetInputSchema() => !this.InputSchema.IsNull();

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool that was used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ToolName { get; set; }

        /// <summary>
        /// Checks to see if the ToolName property is set.
        /// </summary>
        internal bool IsSetToolName() => this.ToolName != null;

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// The result of the tool usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public Amazon.Runtime.Documents.Document ToolResult { get; set; }

        /// <summary>
        /// Checks to see if the ToolResult property is set.
        /// </summary>
        internal bool IsSetToolResult() => !this.ToolResult.IsNull();

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// The identifier of the tool use instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string ToolUseId { get; set; }

        /// <summary>
        /// Checks to see if the ToolUseId property is set.
        /// </summary>
        internal bool IsSetToolUseId() => this.ToolUseId != null;
    }
}
