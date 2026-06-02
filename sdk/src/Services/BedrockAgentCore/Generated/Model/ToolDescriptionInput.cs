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
    /// A tool description input containing the tool name and its current description.
    /// </summary>
    public partial class ToolDescriptionInput
    {
        private ToolDescriptionConfig _toolDescription;
        private string _toolName;

        /// <summary>
        /// Gets and sets the property ToolDescription. 
        /// <para>
        /// The current description of the tool to optimize.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ToolDescriptionConfig ToolDescription
        {
            get { return this._toolDescription; }
            set { this._toolDescription = value; }
        }

        // Check to see if ToolDescription property is set
        internal bool IsSetToolDescription()
        {
            return this._toolDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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

    }
}