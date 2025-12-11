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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
        private Amazon.Runtime.Documents.Document _inputSchema;
        private string _toolName;
        private Amazon.Runtime.Documents.Document _toolResult;
        private string _toolUseId;

        /// <summary>
        /// Gets and sets the property InputSchema. 
        /// <para>
        /// The input schema for the tool use result.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document InputSchema
        {
            get { return this._inputSchema; }
            set { this._inputSchema = value; }
        }

        // Check to see if InputSchema property is set
        internal bool IsSetInputSchema()
        {
            return !this._inputSchema.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool that was used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ToolName
        {
            get { return this._toolName; }
            set { this._toolName = value; }
        }

        // Check to see if ToolName property is set
        internal bool IsSetToolName()
        {
            return this._toolName != null;
        }

        /// <summary>
        /// Gets and sets the property ToolResult. 
        /// <para>
        /// The result of the tool usage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document ToolResult
        {
            get { return this._toolResult; }
            set { this._toolResult = value; }
        }

        // Check to see if ToolResult property is set
        internal bool IsSetToolResult()
        {
            return !this._toolResult.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ToolUseId. 
        /// <para>
        /// The identifier of the tool use instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string ToolUseId
        {
            get { return this._toolUseId; }
            set { this._toolUseId = value; }
        }

        // Check to see if ToolUseId property is set
        internal bool IsSetToolUseId()
        {
            return this._toolUseId != null;
        }

    }
}