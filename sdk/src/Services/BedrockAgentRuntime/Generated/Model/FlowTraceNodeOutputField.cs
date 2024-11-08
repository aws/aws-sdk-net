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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
        private FlowTraceNodeOutputContent _content;
        private string _nodeOutputName;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the node output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowTraceNodeOutputContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property NodeOutputName. 
        /// <para>
        /// The name of the node output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NodeOutputName
        {
            get { return this._nodeOutputName; }
            set { this._nodeOutputName = value; }
        }

        // Check to see if NodeOutputName property is set
        internal bool IsSetNodeOutputName()
        {
            return this._nodeOutputName != null;
        }

    }
}