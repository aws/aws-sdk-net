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
    /// Contains information of the usage of the foundation model.
    /// </summary>
    public partial class Usage
    {
        private int? _inputTokens;
        private int? _outputTokens;

        /// <summary>
        /// Gets and sets the property InputTokens. 
        /// <para>
        /// Contains information about the input tokens from the foundation model usage.
        /// </para>
        /// </summary>
        public int? InputTokens
        {
            get { return this._inputTokens; }
            set { this._inputTokens = value; }
        }

        // Check to see if InputTokens property is set
        internal bool IsSetInputTokens()
        {
            return this._inputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputTokens. 
        /// <para>
        /// Contains information about the output tokens from the foundation model usage.
        /// </para>
        /// </summary>
        public int? OutputTokens
        {
            get { return this._outputTokens; }
            set { this._outputTokens = value; }
        }

        // Check to see if OutputTokens property is set
        internal bool IsSetOutputTokens()
        {
            return this._outputTokens.HasValue; 
        }

    }
}