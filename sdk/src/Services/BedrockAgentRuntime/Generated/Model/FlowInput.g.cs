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
    /// Contains information about an input into the prompt flow and where to send it.
    /// </summary>
    public partial class FlowInput
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Contains information about an input into the prompt flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public FlowInputContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property NodeInputName. 
        /// <para>
        /// The name of the input from the flow input node.
        /// </para>
        /// </summary>
        public string NodeInputName { get; set; }

        /// <summary>
        /// Checks to see if the NodeInputName property is set.
        /// </summary>
        internal bool IsSetNodeInputName() => this.NodeInputName != null;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the flow input node that begins the prompt flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property NodeOutputName. 
        /// <para>
        /// The name of the output from the flow input node that begins the prompt flow.
        /// </para>
        /// </summary>
        public string NodeOutputName { get; set; }

        /// <summary>
        /// Checks to see if the NodeOutputName property is set.
        /// </summary>
        internal bool IsSetNodeOutputName() => this.NodeOutputName != null;
    }
}
