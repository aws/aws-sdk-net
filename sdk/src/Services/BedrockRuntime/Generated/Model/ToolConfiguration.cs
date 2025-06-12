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
    /// Configuration information for the tools that you pass to a model. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/tool-use.html">Tool
    /// use (function calling)</a> in the Amazon Bedrock User Guide.
    /// </summary>
    public partial class ToolConfiguration
    {
        private ToolChoice _toolChoice;
        private List<Tool> _tools = AWSConfigs.InitializeCollections ? new List<Tool>() : null;

        /// <summary>
        /// Gets and sets the property ToolChoice. 
        /// <para>
        /// If supported by model, forces the model to request a tool.
        /// </para>
        /// </summary>
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
        /// An array of tools that you want to pass to a model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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