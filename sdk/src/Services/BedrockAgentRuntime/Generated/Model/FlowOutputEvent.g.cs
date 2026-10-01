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
    /// Contains information about an output from prompt flow invoction.
    /// </summary>
    public partial class FlowOutputEvent : Amazon.Runtime.EventStreams.IEventStreamEvent
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content in the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FlowOutputContent Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property NodeName. 
        /// <para>
        /// The name of the flow output node that the output is from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string NodeName { get; set; }

        /// <summary>
        /// Checks to see if the NodeName property is set.
        /// </summary>
        internal bool IsSetNodeName() => this.NodeName != null;

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The type of the node that the output is from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public NodeType NodeType { get; set; }

        /// <summary>
        /// Checks to see if the NodeType property is set.
        /// </summary>
        internal bool IsSetNodeType() => this.NodeType != null;
    }
}
