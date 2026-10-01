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
    /// The agent card definition for A2A descriptors, including the schema version and inline
    /// content that describes the agent's capabilities.
    /// </summary>
    public partial class AgentCardDefinition
    {
        /// <summary>
        /// Gets and sets the property InlineContent. 
        /// <para>
        ///  The inline content of the agent card definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 409600)]
        public string InlineContent { get; set; }

        /// <summary>
        /// Checks to see if the InlineContent property is set.
        /// </summary>
        internal bool IsSetInlineContent() => this.InlineContent != null;

        /// <summary>
        /// Gets and sets the property SchemaVersion. 
        /// <para>
        ///  The schema version of the agent card definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// Checks to see if the SchemaVersion property is set.
        /// </summary>
        internal bool IsSetSchemaVersion() => this.SchemaVersion != null;
    }
}
