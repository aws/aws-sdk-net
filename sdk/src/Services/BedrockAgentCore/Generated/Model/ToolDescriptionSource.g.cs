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
    /// The source of tool descriptions, either inline text or from a configuration bundle.
    /// </summary>
    public partial class ToolDescriptionSource
    {
        /// <summary>
        /// Gets and sets the property ConfigurationBundle. 
        /// <para>
        /// Tool descriptions sourced from a configuration bundle version.
        /// </para>
        /// </summary>
        public ToolDescriptionConfigurationBundle ConfigurationBundle { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationBundle property is set.
        /// </summary>
        internal bool IsSetConfigurationBundle() => this.ConfigurationBundle != null;

        /// <summary>
        /// Gets and sets the property ToolDescriptionText. 
        /// <para>
        /// Tool descriptions provided as inline text.
        /// </para>
        /// </summary>
        public ToolDescriptionTextInput ToolDescriptionText { get; set; }

        /// <summary>
        /// Checks to see if the ToolDescriptionText property is set.
        /// </summary>
        internal bool IsSetToolDescriptionText() => this.ToolDescriptionText != null;
    }
}
