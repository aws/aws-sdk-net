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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The streaming configuration for an MCP gateway. This structure defines settings that
    /// control response streaming behavior.
    /// </summary>
    public partial class StreamingConfiguration
    {
        private bool? _enableResponseStreaming;

        /// <summary>
        /// Gets and sets the property EnableResponseStreaming. 
        /// <para>
        /// Indicates whether response streaming is enabled for the gateway. When set to <c>true</c>,
        /// the gateway streams responses from targets back to the client.
        /// </para>
        /// </summary>
        public bool? EnableResponseStreaming
        {
            get { return this._enableResponseStreaming; }
            set { this._enableResponseStreaming = value; }
        }

        // Check to see if EnableResponseStreaming property is set
        internal bool IsSetEnableResponseStreaming()
        {
            return this._enableResponseStreaming.HasValue; 
        }

    }
}