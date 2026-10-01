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

namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// Contains information about a field in the output from a node. For more information,
    /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-trace.html">Track
    /// each step in your prompt flow by viewing its trace in Amazon Bedrock</a>.
    /// </summary>
    public partial class FlowTraceNodeOutputField
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the node output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowTraceNodeOutputContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Next. 
        /// <para>
        /// The next node that receives output data from this field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FlowTraceNodeOutputNext> Next { get; set; } = AWSConfigs.InitializeCollections ? new List<FlowTraceNodeOutputNext>() : null;

        /// <summary>
        /// Checks to see if the Next property is set.
        /// </summary>
        internal bool IsSetNext() => this.Next != null && (this.Next.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NodeOutputName. 
        /// <para>
        /// The name of the node output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeOutputName { get; set; }

        /// <summary>
        /// Checks to see if the NodeOutputName property is set.
        /// </summary>
        internal bool IsSetNodeOutputName() => this.NodeOutputName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The data type of the output field for compatibility validation.
        /// </para>
        /// </summary>
        public FlowNodeIODataType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
