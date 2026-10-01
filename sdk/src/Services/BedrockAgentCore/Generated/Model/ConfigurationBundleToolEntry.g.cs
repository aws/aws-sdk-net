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
    /// Maps a tool name to its JSON path within a configuration bundle.
    /// </summary>
    public partial class ConfigurationBundleToolEntry
    {
        /// <summary>
        /// Gets and sets the property ToolDescriptionJsonPath. 
        /// <para>
        /// The JSON path within the configuration bundle's components that contains the tool
        /// description.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ToolDescriptionJsonPath { get; set; }

        /// <summary>
        /// Checks to see if the ToolDescriptionJsonPath property is set.
        /// </summary>
        internal bool IsSetToolDescriptionJsonPath() => this.ToolDescriptionJsonPath != null;

        /// <summary>
        /// Gets and sets the property ToolName. 
        /// <para>
        /// The name of the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ToolName { get; set; }

        /// <summary>
        /// Checks to see if the ToolName property is set.
        /// </summary>
        internal bool IsSetToolName() => this.ToolName != null;
    }
}
