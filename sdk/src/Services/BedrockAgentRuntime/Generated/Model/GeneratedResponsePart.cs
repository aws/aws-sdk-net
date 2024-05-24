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
    /// Contains metadata about a part of the generated response that is accompanied by a
    /// citation.
    /// 
    ///  
    /// <para>
    /// This data type is used in the following API operations:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_InvokeAgent.html#API_agent-runtime_InvokeAgent_ResponseSyntax">InvokeAgent
    /// response</a> – in the <c>generatedResponsePart</c> field
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_agent-runtime_RetrieveAndGenerate.html#API_agent-runtime_RetrieveAndGenerate_ResponseSyntax">RetrieveAndGenerate
    /// response</a> – in the <c>generatedResponsePart</c> field
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GeneratedResponsePart
    {
        private TextResponsePart _textResponsePart;

        /// <summary>
        /// Gets and sets the property TextResponsePart. 
        /// <para>
        /// Contains metadata about a textual part of the generated response that is accompanied
        /// by a citation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public TextResponsePart TextResponsePart
        {
            get { return this._textResponsePart; }
            set { this._textResponsePart = value; }
        }

        // Check to see if TextResponsePart property is set
        internal bool IsSetTextResponsePart()
        {
            return this._textResponsePart != null;
        }

    }
}