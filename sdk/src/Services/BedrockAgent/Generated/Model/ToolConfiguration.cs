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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configuration information for the tools that the model can use when generating a response.
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Use
    /// a tool to complete an Amazon Bedrock model response</a>.
    /// </summary>
    public partial class ToolConfiguration
    {
        private ToolChoice _toolChoice;
        private List<Tool> _tools = AWSConfigs.InitializeCollections ? new List<Tool>() : null;

        /// <summary>
        /// Gets and sets the property ToolChoice. 
        /// <para>
        /// Defines which tools the model should request when invoked.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ToolChoice ToolChoice
        {
            get { return this._toolChoice; }
            set { this._toolChoice = value; }
        }

        // Check to see if ToolChoice property is set
        internal bool IsSetToolChoice()
        {
            return this._toolChoice != null;
        }

        /// <summary>
        /// Gets and sets the property Tools. 
        /// <para>
        /// An array of tools to pass to a model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public List<Tool> Tools
        {
            get { return this._tools; }
            set { this._tools = value; }
        }

        // Check to see if Tools property is set
        internal bool IsSetTools()
        {
            return this._tools != null && (this._tools.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}