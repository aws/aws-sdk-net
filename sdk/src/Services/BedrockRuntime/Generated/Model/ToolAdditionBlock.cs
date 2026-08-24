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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
    /// A content block for adding a tool to the available tool set mid-conversation. Each
    /// block references a single tool via its <c>tool</c> field. Use within a <c>system</c>
    /// role message to make a tool available without re-sending the full tool configuration.
    /// </summary>
    public partial class ToolAdditionBlock
    {
        private ToolReference _tool;

        /// <summary>
        /// Gets and sets the property Tool. 
        /// <para>
        /// A reference to the tool to add to the available tool set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToolReference Tool
        {
            get { return this._tool; }
            set { this._tool = value; }
        }

        // Check to see if Tool property is set
        internal bool IsSetTool()
        {
            return this._tool != null;
        }

    }
}